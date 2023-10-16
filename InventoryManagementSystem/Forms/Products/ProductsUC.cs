using InventoryManagementSystem.Data;

namespace InventoryManagementSystem.Forms.Products;

public partial class ProductsUC : UserControl
{
    public ProductsUC()
    {
        InitializeComponent();
    }

    private void ProductsUC_Load(object sender, EventArgs e)
    {
        //LoadData();
    }

    private void guna2Button4_Click(object sender, EventArgs e)
    {
        LoadData();
    }

    private void LoadData()
    {
        InventoryDbContext dbContext = new();
        productList.DataSource = dbContext.Products.ToList();
    }
}
