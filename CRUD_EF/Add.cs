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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var studentRepository = new StudentRepository();
            Student student = new()
            {
                FullName = fullname.Text,
                Email = email.Text,
                Address = address.Text,
                Age = int.Parse(age.Text)
            };
            studentRepository.AddStudent(student);
            this.Close();
        }
    }
}
