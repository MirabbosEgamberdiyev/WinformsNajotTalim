using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Forms.Products
{
    public partial class AddProduct : Form
    {
        InventoryDbContext dbContext = new();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //save btn
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int selectedId = int.Parse((categorySelect.SelectedItem as string).Split('.')[0]);

            Product product = new()
            {
                Name = name.Text,
                Description = description.Text,
                Price = decimal.Parse(price.Text),
                CategoryId = selectedId,
                Category = null
            };

            dbContext.Products.Add(product);
            dbContext.SaveChanges();
            this.Close();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            categorySelect.DataSource = dbContext.Categories
                    .Select(c => $"{c.Id}. {c.Name}")
                    .ToList();
        }
    }
}
