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

namespace CRUD.CategoryWindows
{
    public partial class EditCategory : Form
    {
        private int Id;
        private string Name = string.Empty;

        public EditCategory(int id, string name)
        {
            InitializeComponent();
            Id = id;
            Name = name;

            this.name.Text = name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            CategoryService categoryService = new();
            categoryService.UpdateCategory(Id, name.Text);
            this.Close();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
