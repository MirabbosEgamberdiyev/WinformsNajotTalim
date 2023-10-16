using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Forms.IncomeForms
{
    public partial class EditIncome : Form
    {
        IncomeProduct income = new();
        InventoryDbContext dbContext = new();
        public EditIncome(int id)
        {
            InitializeComponent();
            income.Id = id;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditIncome_Load(object sender, EventArgs e)
        {
            income = dbContext.IncomeProducts.FirstOrDefault(i => i.Id == income.Id);
            quantity.Text = income.Quantity.ToString();
            inprice.Text = income.IncomingPrice.ToString();
            outprice.Text = income.OutcomingPrice.ToString();
            inDate.Text = income.IncomingDate.ToString();

            var products = dbContext.Products
                    .Select(c => $"{c.Id}. {c.Name}")
                    .ToList();
            productSelect.DataSource = products;
            var product = dbContext.Products.FirstOrDefault(x => x.Id == income.ProductId);
            productSelect.SelectedIndex = dbContext.Products.ToList().IndexOf(product);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            income.Quantity = int.Parse(quantity.Text);
            income.IncomingPrice = decimal.Parse(inprice.Text);
            income.OutcomingPrice = decimal.Parse(outprice.Text);
            income.IncomingDate = DateTime.Parse(inDate.Text);
            income.ProductId = int.Parse((productSelect.SelectedItem as string).Split('.')[0]);

            dbContext.IncomeProducts.Update(income);
            dbContext.SaveChanges();
            this.Close();
        }
    }
}
