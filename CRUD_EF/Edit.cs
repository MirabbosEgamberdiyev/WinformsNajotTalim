using CRUD_EF.Models;
using CRUD_EF.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_EF
{
    public partial class Edit : Form
    {
        Student student = new();
        StudentRepository studentRepos = new();
        int id = 0;
        public Edit(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            student.FullName = fullname.Text;
            student.Email = email.Text;
            student.Address = address.Text;
            student.Age = int.Parse(age.Text);
            studentRepos.UpdateStudent(student);
            MessageBox.Show("Updated!");
            this.Close();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            student = studentRepos.GetStudent(id);
            fullname.Text = student.FullName;
            email.Text = student.Email;
            address.Text = student.Address;
            age.Text = student.Age.ToString();
        }
    }
}
