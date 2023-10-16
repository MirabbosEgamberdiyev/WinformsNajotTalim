using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Forms.Products;

public partial class EditProduct : Form
{
    Product product = new();
    InventoryDbContext dbContext = new();
    public EditProduct(int id)
    {
        InitializeComponent();
        product.Id = id;
    }

    private void guna2Button2_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void guna2Button1_Click(object sender, EventArgs e)
    {
        product.Name = name.Text;
        product.Description = description.Text;
        product.Price = decimal.Parse(price.Text);
        product.CategoryId = int.Parse((categorySelect.SelectedItem as string).Split('.')[0]);
        product.Category = null;

        dbContext.Products.Update(product);
        dbContext.SaveChanges();
        this.Close();
    }

    private void EditProduct_Load(object sender, EventArgs e)
    {
        product = dbContext.Products.FirstOrDefault(p => p.Id == product.Id);
        name.Text = product.Name;
        price.Text = product.Price.ToString();
        description.Text = product.Description;
        var categories = dbContext.Categories
                    .Select(c => $"{c.Id}. {c.Name}")
                    .ToList();
        categorySelect.DataSource = categories;
        var category = dbContext.Categories.FirstOrDefault(x => x.Id == product.CategoryId);
        categorySelect.SelectedIndex = dbContext.Categories.ToList().IndexOf(category);
    }
}
