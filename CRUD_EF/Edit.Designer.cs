namespace CRUD_EF
{
    partial class Edit
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
            button2 = new Button();
            button1 = new Button();
            age = new MaskedTextBox();
            label3 = new Label();
            address = new TextBox();
            label4 = new Label();
            email = new TextBox();
            label2 = new Label();
            fullname = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.PaleGreen;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(452, 214);
            button2.Name = "button2";
            button2.Size = new Size(174, 54);
            button2.TabIndex = 19;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(186, 214);
            button1.Name = "button1";
            button1.Size = new Size(174, 54);
            button1.TabIndex = 18;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // age
            // 
            age.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            age.Location = new Point(427, 147);
            age.Mask = "000";
            age.Name = "age";
            age.Size = new Size(320, 33);
            age.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(427, 119);
            label3.Name = "label3";
            label3.Size = new Size(45, 25);
            label3.TabIndex = 16;
            label3.Text = "Age";
            // 
            // address
            // 
            address.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            address.Location = new Point(66, 147);
            address.Name = "address";
            address.Size = new Size(320, 33);
            address.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(66, 119);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 14;
            label4.Text = "Address";
            // 
            // email
            // 
            email.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(427, 56);
            email.Name = "email";
            email.Size = new Size(320, 33);
            email.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(427, 28);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 12;
            label2.Text = "Email";
            // 
            // fullname
            // 
            fullname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            fullname.Location = new Point(66, 56);
            fullname.Name = "fullname";
            fullname.Size = new Size(320, 33);
            fullname.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(66, 28);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 10;
            label1.Text = "Full Name";
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 313);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(age);
            Controls.Add(label3);
            Controls.Add(address);
            Controls.Add(label4);
            Controls.Add(email);
            Controls.Add(label2);
            Controls.Add(fullname);
            Controls.Add(label1);
            Name = "Edit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit";
            Load += Edit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private MaskedTextBox age;
        private Label label3;
        private TextBox address;
        private Label label4;
        private TextBox email;
        private Label label2;
        private TextBox fullname;
        private Label label1;
    }
}