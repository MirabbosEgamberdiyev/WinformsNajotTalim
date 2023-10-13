using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Forms.CategoryForms
{
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using var dbContext = new InventoryDbContext();
            dbContext.Categories.Add(new Category()
            {
                Name = name.Text
            });
            dbContext.SaveChanges();
            this.Close();
        }
    }
}
