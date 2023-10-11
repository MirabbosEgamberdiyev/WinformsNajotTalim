using CRUD.Models;
using CRUD.UserControls;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace CRUD.Services;

internal class ProductService
{
    const string connectionString = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=ShopDB;";
    SqlConnection? connection;
    SqlCommand? command;
    SqlDataAdapter? adapter;
    SqlDataReader? reader;

    public List<Product> GetProducts()
    {
        List<Product> products = new List<Product>();
        connection = new SqlConnection(connectionString);
        connection.Open();
        string query = "SELECT * FROM Products";
        command = new SqlCommand(query, connection);

        using (SqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                Product Product = new();
                Product.Id = reader.GetInt32(0);
                Product.Name = reader.GetString(1);
                Product.Description = reader.GetString(2);
                Product.CategoryId = reader.GetInt32(3);
                Product.Price = reader.GetDecimal(4);
                products.Add(Product);
            }
        }
        connection.Close();
        return products.OrderBy(p => p.Id).ToList();
    }

    public void AddProduct(string name, string description, decimal price, int categoryId)
    {
        try
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = $"INSERT INTO Products VALUES ('{name}', '{description}', {categoryId}, {price});";
            command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }

    public void DeleteProduct(int selectedId)
    {
        try
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = $"DELETE FROM Products WHERE Id = {selectedId}";
            command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }

    public void UpdateProduct(int id, string name, string desc, decimal price, int categoryId)
    {
        try
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = $"UPDATE Products SET Name='{name}', Description='{desc}', Price={price}, CategoryId={categoryId} WHERE Id = {id}";
            command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }

    public Product GetProduct(int id)
    {
        Product Product = new();
        connection = new SqlConnection(connectionString);
        connection.Open();
        string query = $"SELECT * FROM Products WHERE Id = {id}";
        command = new SqlCommand(query, connection);

        using (SqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                Product.Id = reader.GetInt32(0);
                Product.Name = reader.GetString(1);
                Product.Description = reader.GetString(2);
                Product.CategoryId = reader.GetInt32(3);
                Product.Price = reader.GetDecimal(4);
            }
        }
        connection.Close();
        return Product;
    }

    public List<Product> SearchProducts(string text)
    {
        List<Product> products = new List<Product>();
        connection = new SqlConnection(connectionString);
        connection.Open();
        string query = $"SELECT * FROM Products WHERE Name LIKE '%{text}%'";
        command = new SqlCommand(query, connection);

        using (SqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                Product Product = new();
                Product.Id = reader.GetInt32(0);
                Product.Name = reader.GetString(1);
                Product.Description = reader.GetString(2);
                Product.CategoryId = reader.GetInt32(3);
                Product.Price = reader.GetDecimal(4);
                products.Add(Product);
            }
        }
        connection.Close();
        return products.OrderBy(p => p.Id).ToList();
    }
}