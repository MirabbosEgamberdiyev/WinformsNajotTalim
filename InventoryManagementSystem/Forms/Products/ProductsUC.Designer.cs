namespace InventoryManagementSystem.Forms.Products
{
    partial class ProductsUC
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

        #region Component Designer generated code

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel2 = new Panel();
            guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            search = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            productList = new DataGridView();
            panel1 = new Panel();
            guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productList).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(guna2Button5);
            panel2.Controls.Add(search);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(739, 68);
            panel2.TabIndex = 3;
            // 
            // guna2Button5
            // 
            guna2Button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button5.BorderRadius = 7;
            guna2Button5.CustomizableEdges = customizableEdges1;
            guna2Button5.DisabledState.BorderColor = Color.DarkGray;
            guna2Button5.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button5.FillColor = Color.FromArgb(0, 192, 0);
            guna2Button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button5.ForeColor = Color.White;
            guna2Button5.Location = new Point(583, 12);
            guna2Button5.Name = "guna2Button5";
            guna2Button5.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button5.Size = new Size(144, 50);
            guna2Button5.TabIndex = 5;
            guna2Button5.Text = "Export to .xlsx";
            guna2Button5.Click += guna2Button5_Click;
            // 
            // search
            // 
            search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            search.BorderRadius = 7;
            search.CustomizableEdges = customizableEdges3;
            search.DefaultText = "";
            search.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            search.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            search.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            search.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            search.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            search.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            search.Location = new Point(276, 16);
            search.Margin = new Padding(4);
            search.Name = "search";
            search.PasswordChar = '\0';
            search.PlaceholderText = "Search";
            search.SelectedText = "";
            search.ShadowDecoration.CustomizableEdges = customizableEdges4;
            search.Size = new Size(278, 39);
            search.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 16);
            label1.Name = "label1";
            label1.Size = new Size(98, 30);
            label1.TabIndex = 0;
            label1.Text = "Products";
            // 
            // productList
            // 
            productList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productList.Dock = DockStyle.Fill;
            productList.EditMode = DataGridViewEditMode.EditProgrammatically;
            productList.Location = new Point(0, 68);
            productList.Name = "productList";
            productList.RowTemplate.Height = 25;
            productList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productList.Size = new Size(739, 342);
            productList.TabIndex = 5;
            productList.CellClick += productList_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(guna2Button4);
            panel1.Controls.Add(guna2Button3);
            panel1.Controls.Add(guna2Button2);
            panel1.Controls.Add(guna2Button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 410);
            panel1.Name = "panel1";
            panel1.Size = new Size(739, 75);
            panel1.TabIndex = 4;
            // 
            // guna2Button4
            // 
            guna2Button4.Anchor = AnchorStyles.None;
            guna2Button4.BorderRadius = 25;
            guna2Button4.CustomizableEdges = customizableEdges5;
            guna2Button4.DisabledState.BorderColor = Color.DarkGray;
            guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button4.FillColor = Color.Fuchsia;
            guna2Button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button4.ForeColor = Color.White;
            guna2Button4.Location = new Point(34, 11);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button4.Size = new Size(136, 50);
            guna2Button4.TabIndex = 4;
            guna2Button4.Text = "Refresh";
            guna2Button4.Click += guna2Button4_Click;
            // 
            // guna2Button3
            // 
            guna2Button3.Anchor = AnchorStyles.None;
            guna2Button3.BorderRadius = 25;
            guna2Button3.CustomizableEdges = customizableEdges7;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.FillColor = Color.FromArgb(192, 0, 0);
            guna2Button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button3.ForeColor = Color.White;
            guna2Button3.Location = new Point(568, 11);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button3.Size = new Size(136, 50);
            guna2Button3.TabIndex = 2;
            guna2Button3.Text = "Delete";
            guna2Button3.Click += guna2Button3_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = AnchorStyles.None;
            guna2Button2.BorderRadius = 25;
            guna2Button2.CustomizableEdges = customizableEdges9;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.LightSeaGreen;
            guna2Button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(390, 11);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Button2.Size = new Size(136, 50);
            guna2Button2.TabIndex = 1;
            guna2Button2.Text = "Edit";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.None;
            guna2Button1.BorderRadius = 25;
            guna2Button1.CustomizableEdges = customizableEdges11;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(0, 192, 0);
            guna2Button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(212, 11);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Button1.Size = new Size(136, 50);
            guna2Button1.TabIndex = 0;
            guna2Button1.Text = "Add";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // ProductsUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(productList);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "ProductsUC";
            Size = new Size(739, 485);
            Load += ProductsUC_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productList).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox search;
        private Label label1;
        private DataGridView productList;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
    }
}
