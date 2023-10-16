namespace InventoryManagementSystem.Forms
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            phone = new MaskedTextBox();
            label3 = new Label();
            password = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            showpassword = new Guna.UI2.WinForms.Guna2CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(83, 164);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 0;
            label1.Text = "Phone Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(96, 42);
            label2.Name = "label2";
            label2.Size = new Size(259, 49);
            label2.TabIndex = 1;
            label2.Text = "Log in to IMS";
            // 
            // phone
            // 
            phone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            phone.Location = new Point(83, 192);
            phone.Mask = "+000-00-0000000 ";
            phone.Name = "phone";
            phone.Size = new Size(284, 33);
            phone.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(83, 255);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // password
            // 
            password.CustomizableEdges = customizableEdges1;
            password.DefaultText = "";
            password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            password.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            password.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            password.ForeColor = Color.Black;
            password.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            password.Location = new Point(83, 285);
            password.Margin = new Padding(5);
            password.Name = "password";
            password.PasswordChar = '●';
            password.PlaceholderText = "";
            password.SelectedText = "";
            password.ShadowDecoration.CustomizableEdges = customizableEdges2;
            password.Size = new Size(284, 44);
            password.TabIndex = 4;
            password.UseSystemPasswordChar = true;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 5;
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(135, 360);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(180, 45);
            guna2Button1.TabIndex = 5;
            guna2Button1.Text = "Log in";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // showpassword
            // 
            showpassword.AutoSize = true;
            showpassword.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            showpassword.CheckedState.BorderRadius = 0;
            showpassword.CheckedState.BorderThickness = 0;
            showpassword.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            showpassword.Location = new Point(260, 261);
            showpassword.Name = "showpassword";
            showpassword.Size = new Size(107, 19);
            showpassword.TabIndex = 6;
            showpassword.Text = "show password";
            showpassword.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            showpassword.UncheckedState.BorderRadius = 0;
            showpassword.UncheckedState.BorderThickness = 0;
            showpassword.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            showpassword.CheckedChanged += guna2CheckBox1_CheckedChanged;
            showpassword.CheckStateChanged += showpassword_CheckStateChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 452);
            Controls.Add(showpassword);
            Controls.Add(guna2Button1);
            Controls.Add(password);
            Controls.Add(label3);
            Controls.Add(phone);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosed += Login_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MaskedTextBox phone;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox password;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2CheckBox showpassword;
    }
}