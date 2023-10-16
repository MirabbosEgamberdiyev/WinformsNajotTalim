using DocumentFormat.OpenXml.Drawing.Diagrams;
using Guna.UI2.WinForms.Suite;
using InventoryManagementSystem.Data;

namespace InventoryManagementSystem.Forms.Products;

public partial class ProductsUC : UserControl
{
    private int selectedId = 0;

    public ProductsUC()
    {
        InitializeComponent();
    }

    private void ProductsUC_Load(object sender, EventArgs e)
    {
        Thread thread = new(LoadDataInBackground);
        thread.IsBackground = true;
        thread.Start();
    }

    private void LoadDataInBackground()
    {
        InventoryDbContext dbContext = new();
        var categories = dbContext.Products.Select(p => new
        {
            Id = p.Id,
            Name = p.Name,
            Qantity = dbContext.IncomeProducts.Where(i => i.ProductId == p.Id).Sum(p => p.Quantity),
            Price = p.Price,
            Description = p.Description,
            Category = dbContext.Categories.FirstOrDefault(c => c.Id == p.CategoryId).Name,
        }).ToList();

        productList.Invoke((MethodInvoker)delegate
        {
            productList.DataSource = categories;
        });
    }
    private void guna2Button4_Click(object sender, EventArgs e)
    {
        LoadData();
    }

    private void LoadData()
    {
        InventoryDbContext dbContext = new();
        productList.DataSource = dbContext.Products
            .Select(p => new
            {
                Id = p.Id,
                Name = p.Name,
                Qantity = dbContext.IncomeProducts.Where(i => i.ProductId == p.Id).Sum(p => p.Quantity),
                Price = p.Price,
                Description = p.Description,
                Category = dbContext.Categories.FirstOrDefault(c => c.Id == p.CategoryId).Name,
            })
            .ToList();
    }

    //add btn
    private void guna2Button1_Click(object sender, EventArgs e)
    {
        new AddProduct().ShowDialog();
    }

    private void guna2Button2_Click(object sender, EventArgs e)
    {
        if (selectedId != 0)
        {
            EditProduct edit = new(selectedId);
            edit.ShowDialog();
        }
    }

    private void productList_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        selectedId = int.Parse(productList.SelectedRows[0].Cells[0].Value.ToString());
    }

    private void guna2Button3_Click(object sender, EventArgs e)
    {
        DialogResult dialog = MessageBox.Show("Are you sure delete this item?",
                                              "Warning",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);
        if (dialog == DialogResult.Yes && selectedId != 0)
        {
            InventoryDbContext dbContext = new();
            var product = dbContext.Products.FirstOrDefault(p => p.Id == selectedId);
            dbContext.Products.Remove(product);
            dbContext.SaveChanges();
        }
    }

    private void guna2Button5_Click(object sender, EventArgs e)
    {
        string path = "Products.xlsx";
        using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
        {
            // Set the properties of the FolderBrowserDialog
            folderBrowserDialog.Description = "Select a folder:";
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;

            // Show the dialog and check if the user selected a folder
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                path = Path.Combine(folderBrowserDialog.SelectedPath, path);
            }
        }
        using InventoryDbContext dbContext = new();
        var excelExport = new ExcelExport();
        excelExport.ExportToExcel(dbContext.Products.ToList(), path);
    }

    private void search_TextChanged(object sender, EventArgs e)
    {
        InventoryDbContext dbContext = new();
        productList.DataSource = dbContext.Products
            .Where(c => c.Name.ToLower().Contains(search.Text.ToLower()))
            .Select(p => new
            {
                Id = p.Id,
                Name = p.Name,
                Qantity = dbContext.IncomeProducts.Where(i => i.ProductId == p.Id).Sum(p => p.Quantity),
                Price = p.Price,
                Description = p.Description,
                Category = dbContext.Categories.FirstOrDefault(c => c.Id == p.CategoryId).Name
            })
            .ToList();
    }
}
