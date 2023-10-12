using CRUD_EF.Repositories;

namespace CRUD_EF
{
    public partial class Form1 : Form
    {
        private IStudentInterface studentInterface;
        int selectedId = 0;
        public Form1()
        {
            InitializeComponent();
            studentInterface = new StudentRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Add add = new();
            add.ShowDialog();
            LoadData();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (selectedId != 0)
            {
                Edit edit = new(selectedId);
                edit.ShowDialog();
                LoadData();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure delete this item?",
                                                        "Warning",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                studentInterface.DeleteStudent(selectedId);
                MessageBox.Show("Successfully deleted!");
                selectedId = 0;
                LoadData();
            }
        }

        private void LoadData()
        {
            studentInterface = new StudentRepository();
            dataGridView1.DataSource = studentInterface.GetStudents();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            if (selectedId != 0)
            {
                delete.Enabled = true;
            }
        }
    }
}