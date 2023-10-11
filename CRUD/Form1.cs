namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void categoriesBtn_Click(object sender, EventArgs e)
        {
            OpenCategories();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenProducts();
        }

        void CloseAll()
        {
            categories.Visible = false;
            products.Visible = false;
        }

        void OpenCategories()
        {
            CloseAll();
            categories.Visible = true;
        }

        void OpenProducts()
        {
            CloseAll();
            products.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenCategories();
        }
    }
}