using CRUD.Models;
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

namespace CRUD.ProductWindows
{
    public partial class AddProduct : Form
    {
        List<string> categories = new();
        ProductService productService = new();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // save
        private void button2_Click(object sender, EventArgs e)
        {
            string? selectedItem = categorySelect.SelectedItem.ToString();
            int selectedId = int.Parse(selectedItem.Split('.')[0]);
            productService.AddProduct(name.Text, description.Text, decimal.Parse(price.Text), selectedId);
            this.Close();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            CategoryService categoryService = new();
            categories.AddRange(categoryService.GetCategories().Select(c => $"{c.Id}. {c.Name}").ToList());

            categorySelect.DataSource = categories;
            categorySelect.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
