using CRUD.CategoryWindows;
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

namespace CRUD
{
    public partial class Categories : UserControl
    {
        CategoryService categoryService = new();
        int selectedId = 0;
        public Categories()
        {
            InitializeComponent();
        }

        //form load
        private void Categories_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        //open add window
        private void addBtn_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new();
            addCategory.ShowDialog();
            Refresh();
        }

        //refresh data
        private void Refresh()
        {
            categoryGrid.DataSource = categoryService.GetCategories();
        }

        //selectId
        private void categoryGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = int.Parse(categoryGrid.SelectedRows[0].Cells[0].Value.ToString());
        }

        // delete action
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure delete this item?",
                                                        "Warning",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                categoryService.DeleteCategory(selectedId);

                MessageBox.Show("Successfully deleted!");
                Refresh();
            }
        }

        //open edit window
        private void editBtn_Click(object sender, EventArgs e)
        {
            string name = categoryGrid.SelectedRows[0].Cells[1].Value.ToString();
            EditCategory editCategory = new(selectedId, name);
            editCategory.ShowDialog();
            MessageBox.Show("Successfully Updated!");
            Refresh();
        }
    }
}
