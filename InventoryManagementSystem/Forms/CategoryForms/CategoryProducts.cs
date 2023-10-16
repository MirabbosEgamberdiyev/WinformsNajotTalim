using InventoryManagementSystem.Data;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem.Forms.CategoryForms
{
    public partial class CategoryProducts : Form
    {
        int Id = 0;
        public CategoryProducts(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void CategoryProducts_Load(object sender, EventArgs e)
        {
            InventoryDbContext dbContext = new InventoryDbContext();
            var category = dbContext.Categories
                .Include(c => c.Products)
                .FirstOrDefault(c => c.Id == Id);

            cName.Text = category.Name;
            productList.DataSource = category.Products
            .Select(p => new
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Description = p.Description,
                Category = dbContext.Categories.FirstOrDefault(c => c.Id == p.CategoryId).Name
            })
            .ToList();
        }
    }
}
