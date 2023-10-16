namespace InventoryManagementSystem.Forms.Products
{
    partial class EditProduct
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            price = new MaskedTextBox();
            description = new RichTextBox();
            label4 = new Label();
            categorySelect = new Guna.UI2.WinForms.Guna2ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            name = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // price
            // 
            price.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            price.Location = new Point(74, 169);
            price.Mask = "000000000000000";
            price.Name = "price";
            price.Size = new Size(305, 33);
            price.TabIndex = 25;
            // 
            // description
            // 
            description.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            description.Location = new Point(438, 64);
            description.Name = "description";
            description.Size = new Size(291, 248);
            description.TabIndex = 24;
            description.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(438, 30);
            label4.Name = "label4";
            label4.Size = new Size(122, 30);
            label4.TabIndex = 23;
            label4.Text = "Description";
            // 
            // categorySelect
            // 
            categorySelect.BackColor = Color.Transparent;
            categorySelect.CustomizableEdges = customizableEdges1;
            categorySelect.DrawMode = DrawMode.OwnerDrawFixed;
            categorySelect.DropDownStyle = ComboBoxStyle.DropDownList;
            categorySelect.FocusedColor = Color.FromArgb(94, 148, 255);
            categorySelect.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            categorySelect.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            categorySelect.ForeColor = Color.FromArgb(68, 88, 112);
            categorySelect.ItemHeight = 30;
            categorySelect.Location = new Point(73, 276);
            categorySelect.Name = "categorySelect";
            categorySelect.ShadowDecoration.CustomizableEdges = customizableEdges2;
            categorySelect.Size = new Size(306, 36);
            categorySelect.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(72, 242);
            label3.Name = "label3";
            label3.Size = new Size(102, 30);
            label3.TabIndex = 21;
            label3.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(72, 136);
            label2.Name = "label2";
            label2.Size = new Size(59, 30);
            label2.TabIndex = 20;
            label2.Text = "Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(72, 30);
            label1.Name = "label1";
            label1.Size = new Size(70, 30);
            label1.TabIndex = 19;
            label1.Text = "Name";
            // 
            // guna2Button2
            // 
            guna2Button2.BorderRadius = 7;
            guna2Button2.CustomizableEdges = customizableEdges3;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Gray;
            guna2Button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(230, 370);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button2.Size = new Size(149, 50);
            guna2Button2.TabIndex = 18;
            guna2Button2.Text = "Cancel";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 7;
            guna2Button1.CustomizableEdges = customizableEdges5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(0, 192, 0);
            guna2Button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(438, 370);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button1.Size = new Size(149, 50);
            guna2Button1.TabIndex = 17;
            guna2Button1.Text = "Save";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // name
            // 
            name.CustomizableEdges = customizableEdges7;
            name.DefaultText = "";
            name.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            name.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            name.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            name.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            name.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            name.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            name.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            name.Location = new Point(73, 64);
            name.Margin = new Padding(5);
            name.Name = "name";
            name.PasswordChar = '\0';
            name.PlaceholderText = "";
            name.SelectedText = "";
            name.ShadowDecoration.CustomizableEdges = customizableEdges8;
            name.Size = new Size(306, 44);
            name.TabIndex = 16;
            // 
            // EditProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(price);
            Controls.Add(description);
            Controls.Add(label4);
            Controls.Add(categorySelect);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button1);
            Controls.Add(name);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "EditProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditProduct";
            Load += EditProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox price;
        private RichTextBox description;
        private Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox categorySelect;
        private Label label3;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox name;
    }
}