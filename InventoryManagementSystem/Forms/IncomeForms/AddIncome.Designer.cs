namespace InventoryManagementSystem.Forms.IncomeForms
{
    partial class AddIncome
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
            inprice = new MaskedTextBox();
            productSelect = new Guna.UI2.WinForms.Guna2ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            quantity = new MaskedTextBox();
            outprice = new MaskedTextBox();
            label5 = new Label();
            inDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label4 = new Label();
            SuspendLayout();
            // 
            // inprice
            // 
            inprice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            inprice.Location = new Point(27, 168);
            inprice.Mask = "000000000000000";
            inprice.Name = "inprice";
            inprice.Size = new Size(305, 33);
            inprice.TabIndex = 25;
            // 
            // productSelect
            // 
            productSelect.BackColor = Color.Transparent;
            productSelect.CustomizableEdges = customizableEdges1;
            productSelect.DrawMode = DrawMode.OwnerDrawFixed;
            productSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            productSelect.FocusedColor = Color.FromArgb(94, 148, 255);
            productSelect.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            productSelect.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            productSelect.ForeColor = Color.FromArgb(68, 88, 112);
            productSelect.ItemHeight = 30;
            productSelect.Location = new Point(391, 62);
            productSelect.Name = "productSelect";
            productSelect.ShadowDecoration.CustomizableEdges = customizableEdges2;
            productSelect.Size = new Size(306, 36);
            productSelect.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(391, 29);
            label3.Name = "label3";
            label3.Size = new Size(89, 30);
            label3.TabIndex = 21;
            label3.Text = "Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 135);
            label2.Name = "label2";
            label2.Size = new Size(155, 30);
            label2.TabIndex = 20;
            label2.Text = "Incoming Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 29);
            label1.Name = "label1";
            label1.Size = new Size(96, 30);
            label1.TabIndex = 19;
            label1.Text = "Quantity";
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
            guna2Button2.Location = new Point(183, 352);
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
            guna2Button1.Location = new Point(391, 352);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button1.Size = new Size(149, 50);
            guna2Button1.TabIndex = 17;
            guna2Button1.Text = "Save";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // quantity
            // 
            quantity.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            quantity.Location = new Point(27, 62);
            quantity.Mask = "000000000000000";
            quantity.Name = "quantity";
            quantity.Size = new Size(305, 33);
            quantity.TabIndex = 26;
            // 
            // outprice
            // 
            outprice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            outprice.Location = new Point(27, 267);
            outprice.Mask = "000000000000000";
            outprice.Name = "outprice";
            outprice.Size = new Size(305, 33);
            outprice.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(25, 234);
            label5.Name = "label5";
            label5.Size = new Size(173, 30);
            label5.TabIndex = 27;
            label5.Text = "Outcoming Price";
            // 
            // inDate
            // 
            inDate.BackColor = Color.White;
            inDate.Checked = true;
            inDate.CustomizableEdges = customizableEdges7;
            inDate.FillColor = Color.White;
            inDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            inDate.Format = DateTimePickerFormat.Long;
            inDate.Location = new Point(391, 168);
            inDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            inDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            inDate.Name = "inDate";
            inDate.ShadowDecoration.CustomizableEdges = customizableEdges8;
            inDate.Size = new Size(306, 42);
            inDate.TabIndex = 29;
            inDate.Value = new DateTime(2023, 10, 16, 21, 46, 45, 489);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(391, 135);
            label4.Name = "label4";
            label4.Size = new Size(154, 30);
            label4.TabIndex = 30;
            label4.Text = "Incoming Date";
            // 
            // AddIncome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 427);
            Controls.Add(label4);
            Controls.Add(inDate);
            Controls.Add(outprice);
            Controls.Add(label5);
            Controls.Add(quantity);
            Controls.Add(inprice);
            Controls.Add(productSelect);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddIncome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddIncome";
            Load += AddIncome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox inprice;
        private Guna.UI2.WinForms.Guna2ComboBox productSelect;
        private Label label3;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private MaskedTextBox quantity;
        private MaskedTextBox outprice;
        private Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker inDate;
        private Label label4;
    }
}