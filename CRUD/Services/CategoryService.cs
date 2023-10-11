using CRUD.Models;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace CRUD.Services;

internal class CategoryService
{
    const string connectionString = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=ShopDB;";
    SqlConnection? connection;
    SqlCommand? command;
    SqlDataAdapter? adapter;
    SqlDataReader? reader;

    public List<Category> GetCategories()
    {
        List<Category> categories = new List<Category>();
        connection = new SqlConnection(connectionString);
        connection.Open();
        string query = "SELECT * FROM Categories";
        command = new SqlCommand(query, connection);

        using (SqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                Category category = new();
                category.Id = reader.GetInt32(0);
                category.Name = reader.GetString(1);
                categories.Add(category);
            }
        }
        connection.Close();
        return categories;
    }

    public void AddCategory(string name)
    {
        try
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = $"INSERT INTO Categories VALUES ('{name}')";
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

    public void DeleteCategory(int selectedId)
    {
        try
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = $"DELETE FROM Categories WHERE Id = {selectedId}";
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

    public void UpdateCategory(int id, string name)
    {
        try
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = $"UPDATE Categories SET Name='{name}' WHERE Id = {id}";
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
}