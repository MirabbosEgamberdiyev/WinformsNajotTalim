using InventoryManagementSystem.Forms;

namespace InventoryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //open categories
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenCategories();
        }

        //open products
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenProducts();
        }


        private void CloseAll()
        {
            categoruc1.Visible = false;
            productsuc1.Visible = false;
            incomeuc1.Visible = false;
        }

        private void OpenCategories()
        {
            CloseAll();
            categoruc1.Visible = true;
        }

        private void OpenProducts()
        {
            CloseAll();
            productsuc1.Visible = true;
        }

        private void OpenIncomes()
        {
            CloseAll();
            incomeuc1.Visible = true;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            OpenIncomes();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}