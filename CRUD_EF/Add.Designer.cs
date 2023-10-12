namespace CRUD_EF
{
    partial class Add
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
            label1 = new Label();
            fullname = new TextBox();
            email = new TextBox();
            label2 = new Label();
            label3 = new Label();
            address = new TextBox();
            label4 = new Label();
            age = new MaskedTextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 25);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 0;
            label1.Text = "Full Name";
            // 
            // fullname
            // 
            fullname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            fullname.Location = new Point(22, 53);
            fullname.Name = "fullname";
            fullname.Size = new Size(320, 33);
            fullname.TabIndex = 1;
            // 
            // email
            // 
            email.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(383, 53);
            email.Name = "email";
            email.Size = new Size(320, 33);
            email.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(383, 25);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(383, 116);
            label3.Name = "label3";
            label3.Size = new Size(45, 25);
            label3.TabIndex = 6;
            label3.Text = "Age";
            // 
            // address
            // 
            address.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            address.Location = new Point(22, 144);
            address.Name = "address";
            address.Size = new Size(320, 33);
            address.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 116);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 4;
            label4.Text = "Address";
            // 
            // age
            // 
            age.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            age.Location = new Point(383, 144);
            age.Mask = "000";
            age.Name = "age";
            age.Size = new Size(320, 33);
            age.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(142, 211);
            button1.Name = "button1";
            button1.Size = new Size(174, 54);
            button1.TabIndex = 8;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleGreen;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(408, 211);
            button2.Name = "button2";
            button2.Size = new Size(174, 54);
            button2.TabIndex = 9;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 288);
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
            Name = "Add";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add new student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox fullname;
        private TextBox email;
        private Label label2;
        private Label label3;
        private TextBox address;
        private Label label4;
        private MaskedTextBox age;
        private Button button1;
        private Button button2;
    }
}