using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem.Forms.CategoryForms;

public partial class CategorUC : UserControl
{
    int selectedId = 0;
    public CategorUC()
    {
        InitializeComponent();
    }

    private void CategorUC_Load(object sender, EventArgs e)
    {
        //LoadData();
    }


    private void LoadData()
    {
        InventoryDbContext dbContext = new();
        categoryList.DataSource = dbContext.Categories.Select(i => new { Id = i.Id, Name = i.Name }).ToList();
    }

    //add btn click
    private void guna2Button1_Click(object sender, EventArgs e)
    {
        new AddCategory().ShowDialog();
        LoadData();
    }

    //edit btn click
    private void guna2Button2_Click(object sender, EventArgs e)
    {
        if (selectedId != 0)
        {
            var category = GetById(selectedId);
            var edit = new EditCatagory(selectedId, category.Name);
            edit.ShowDialog();
            LoadData();
        }
        else
        {
            MessageBox.Show("Select category!");
        }
    }

    //delete btn click
    private void guna2Button3_Click(object sender, EventArgs e)
    {
        DialogResult dialog = MessageBox.Show("Are you sure delete this item?",
                                              "Warning",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);
        if (dialog == DialogResult.Yes)
        {
            var category = GetById(selectedId);
            if (category != null)
            {
                InventoryDbContext dbContext = new();
                dbContext.Categories.Remove(category);
                dbContext.SaveChanges();
                LoadData();
                MessageBox.Show("Successfully deleted!");
            }

        }
    }

    private void categoryList_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        selectedId = int.Parse(categoryList.SelectedRows[0].Cells[0].Value.ToString());
    }

    private Category? GetById(int id)
    {
        InventoryDbContext dbContext = new();
        return dbContext.Categories.FirstOrDefault(c => c.Id == selectedId);
    }

    private void guna2TextBox1_TextChanged(object sender, EventArgs e)
    {
        InventoryDbContext dbContext = new();
        categoryList.DataSource = dbContext.Categories
            .Where(c => c.Name.ToLower().Contains(search.Text.ToLower()))
            .Select(i => new { Id = i.Id, Name = i.Name }).ToList();
    }

    private void guna2Button4_Click(object sender, EventArgs e)
    {
        LoadData();
    }
}
