using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Forms.IncomeForms;

public partial class AddIncome : Form
{
    InventoryDbContext dbContext = new();
    public AddIncome()
    {
        InitializeComponent();
    }

    private void guna2Button2_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void guna2Button1_Click(object sender, EventArgs e)
    {
        int selectedId = int.Parse((productSelect.SelectedItem as string).Split('.')[0]);
        IncomeProduct income = new()
        {
            Quantity = int.Parse(quantity.Text),
            IncomingPrice = decimal.Parse(inprice.Text),
            OutcomingPrice = decimal.Parse(outprice.Text),
            IncomingDate = DateTime.Parse(inDate.Text),
            ProductId = selectedId,
            Product = null
        };

        dbContext.IncomeProducts.Add(income);
        dbContext.SaveChanges();
        this.Close();
    }

    private void AddIncome_Load(object sender, EventArgs e)
    {
        productSelect.DataSource = dbContext.Products
            .Select(p => $"{p.Id}. {p.Name}")
            .ToList();
    }
}
