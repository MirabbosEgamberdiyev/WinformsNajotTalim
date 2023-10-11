namespace CRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            categoriesBtn = new Button();
            label1 = new Label();
            panel2 = new Panel();
            products = new UserControls.Products();
            categories = new Categories();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(categoriesBtn);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 482);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(23, 214);
            button3.Name = "button3";
            button3.Size = new Size(194, 39);
            button3.TabIndex = 3;
            button3.Text = "Users";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(23, 153);
            button2.Name = "button2";
            button2.Size = new Size(194, 39);
            button2.TabIndex = 2;
            button2.Text = "Products";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // categoriesBtn
            // 
            categoriesBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            categoriesBtn.Location = new Point(23, 92);
            categoriesBtn.Name = "categoriesBtn";
            categoriesBtn.Size = new Size(194, 39);
            categoriesBtn.TabIndex = 1;
            categoriesBtn.Text = "Categories";
            categoriesBtn.UseVisualStyleBackColor = true;
            categoriesBtn.Click += categoriesBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 4);
            label1.Name = "label1";
            label1.Size = new Size(185, 65);
            label1.TabIndex = 0;
            label1.Text = "ADMIN";
            // 
            // panel2
            // 
            panel2.Controls.Add(products);
            panel2.Controls.Add(categories);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(237, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(589, 482);
            panel2.TabIndex = 1;
            // 
            // products
            // 
            products.BackColor = Color.FromArgb(192, 255, 255);
            products.Dock = DockStyle.Fill;
            products.Location = new Point(0, 0);
            products.Name = "products";
            products.Size = new Size(589, 482);
            products.TabIndex = 1;
            // 
            // categories
            // 
            categories.BackColor = Color.FromArgb(192, 255, 255);
            categories.Dock = DockStyle.Fill;
            categories.Location = new Point(0, 0);
            categories.Name = "categories";
            categories.Size = new Size(589, 482);
            categories.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 482);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button categoriesBtn;
        private Label label1;
        private Button button3;
        private Panel panel2;
        private Categories categories;
        private UserControls.Products products;
    }
}