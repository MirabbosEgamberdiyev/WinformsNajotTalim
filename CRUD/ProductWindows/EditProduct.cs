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
    public partial class EditProduct : Form
    {
        Product product;
        CategoryService categoryService = new();
        List<string> categories = new();
        public EditProduct(int id, string name, string desc, decimal price, int categoryId)
        {
            InitializeComponent();
            product = new()
            {
                Id  = id,
                Name = name,
                Description = desc,
                Price = price,
                CategoryId = categoryId
            };

            this.name.Text = name;
            this.description.Text = desc;
            this.price.Text = price.ToString();       
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            var list = categoryService.GetCategories();
            categories.AddRange(list.Select(c => $"{c.Id}. {c.Name}").ToList());

            categorySelect.DataSource = categories;
            var productCategory = list.FirstOrDefault(c => c.Id == product.CategoryId);
            categorySelect.SelectedIndex = list.IndexOf(productCategory);

            categorySelect.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductService productService = new();
            string? selectedItem = categorySelect.SelectedItem.ToString();
            int selectedId = int.Parse(selectedItem.Split('.')[0]);
            productService.UpdateProduct(product.Id, name.Text, description.Text, decimal.Parse(price.Text), selectedId);
            this.Close();
        }
    }
}
