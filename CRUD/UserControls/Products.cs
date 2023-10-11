using CRUD.ProductWindows;
using CRUD.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD.UserControls
{
    public partial class Products : UserControl
    {
        ProductService productService = new();
        private int selectedId;

        public Products()
        {
            InitializeComponent();
        }

        //open add window
        private void addBtn_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new();
            addProduct.ShowDialog();
            MessageBox.Show("Successfully added!");
            Refresh();
        }

        //open Edit window
        private void editBtn_Click(object sender, EventArgs e)
        {
            var product = productService.GetProduct(selectedId);
            EditProduct editProduct = new(product.Id,
                                          product.Name,
                                          product.Description,
                                          product.Price,
                                          product.CategoryId);
            editProduct.ShowDialog();
            MessageBox.Show("Updated!");
            Refresh();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure delete this item?",
                                            "Warning",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                productService.DeleteProduct(selectedId);

                MessageBox.Show("Successfully deleted!");
                Refresh();
            }
        }

        private void Products_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            productGrid.DataSource = productService.GetProducts();
        }

        private void productGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = int.Parse(productGrid.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(search.Text))
            {
                productGrid.DataSource = productService.SearchProducts(search.Text);
            }
            else
            {
                Refresh();
            }
        }
    }
}
