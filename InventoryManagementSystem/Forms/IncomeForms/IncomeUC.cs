using DocumentFormat.OpenXml.Drawing.Diagrams;
using InventoryManagementSystem.Data;

namespace InventoryManagementSystem.Forms.IncomeForms;

public partial class IncomeUC : UserControl
{
    InventoryDbContext dbContext = new();
    int selectedId = 0;
    public IncomeUC()
    {
        InitializeComponent();
    }

    //refresh
    private void guna2Button4_Click(object sender, EventArgs e)
    {
        LoadData();
    }

    //add
    private void guna2Button1_Click(object sender, EventArgs e)
    {
        new AddIncome().ShowDialog();
    }
    //edit
    private void guna2Button2_Click(object sender, EventArgs e)
    {
        if (selectedId != 0)
        {
            EditIncome edit = new(selectedId);
            edit.ShowDialog();
        }
    }
    //delete
    private void guna2Button3_Click(object sender, EventArgs e)
    {
        DialogResult dialog = MessageBox.Show("Are you sure delete this item?",
                                              "Warning",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);
        if (dialog == DialogResult.Yes && selectedId != 0)
        {
            var income = dbContext.IncomeProducts.FirstOrDefault(p => p.Id == selectedId);
            dbContext.IncomeProducts.Remove(income);
            dbContext.SaveChanges();
        }
    }

    private void LoadData()
    {
        incomeList.DataSource = dbContext.IncomeProducts
                  .Select(i => new
                  {
                      Id = i.Id,
                      Quantity = i.Quantity,
                      IncomingPrice = i.IncomingPrice,
                      OutcomingPrice = i.OutcomingPrice,
                      IncomingDate = i.IncomingDate,
                      ProductName = dbContext.Products
                            .FirstOrDefault(p => p.Id == i.ProductId)
                            .Name
                  }).ToList();
    }

    private void incomeList_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        selectedId = int.Parse(incomeList.SelectedRows[0].Cells[0].Value.ToString());
    }

    private void IncomeUC_Load(object sender, EventArgs e)
    {
        Thread thread = new(LoadDataInBackground);
        thread.IsBackground = true;
        thread.Start();
    }

    private void LoadDataInBackground()
    {
        InventoryDbContext dbContext = new();
        var categories = dbContext.IncomeProducts.Select(i => new
        {
            Id = i.Id,
            Quantity = i.Quantity,
            IncomingPrice = i.IncomingPrice,
            OutcomingPrice = i.OutcomingPrice,
            IncomingDate = i.IncomingDate,
            ProductName = dbContext.Products
                            .FirstOrDefault(p => p.Id == i.ProductId)
                            .Name
        }).ToList();
        incomeList.Invoke((MethodInvoker)delegate
        {
            incomeList.DataSource = categories;
        });
    }
}
