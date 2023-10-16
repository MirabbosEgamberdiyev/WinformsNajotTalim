using InventoryManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            InventoryDbContext dbContext = new();
            string phoneNumber = phone.Text.Replace("-", "").Replace("+", "");
            var admin = dbContext.Admins
                .FirstOrDefault(a => a.PhoneNumber == phoneNumber &&
                                     a.Password == password.Text);

            if (admin != null)
            {
                MessageBox.Show("You are logged in",
                                "Info",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                Form1 form = new();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid phoneNumber or password",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void showpassword_CheckStateChanged(object sender, EventArgs e)
        {
            if (showpassword.Checked)
            {
                password.UseSystemPasswordChar = false;
                password.PasswordChar = '\0';
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }
    }
}
