using InventoryManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Forms.CategoryForms
{
    public partial class EditCatagory : Form
    {
        private int Id { get; set; }
        private string? CategoryName { get; set; }
        public EditCatagory(int id, string categoryName)
        {
            InitializeComponent();
            Id = id;
            CategoryName = categoryName;

            name.Text = CategoryName;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using var dbContext = new InventoryDbContext();
            var category = dbContext.Categories.FirstOrDefault(c => c.Id == Id);
            if (category != null)
            {
                category.Name = name.Text;
                dbContext.Categories.Update(category);
                dbContext.SaveChanges();
                MessageBox.Show("Updated");
            }
            this.Close();
        }
    }
}
