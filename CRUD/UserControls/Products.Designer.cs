namespace CRUD.UserControls
{
    partial class Products
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
            addBtn = new Button();
            editBtn = new Button();
            deleteBtn = new Button();
            panel1 = new Panel();
            search = new TextBox();
            productGrid = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productGrid).BeginInit();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.Anchor = AnchorStyles.None;
            addBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addBtn.Location = new Point(46, 428);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(115, 37);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add new";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Anchor = AnchorStyles.None;
            editBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            editBtn.Location = new Point(230, 428);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(115, 37);
            editBtn.TabIndex = 2;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Anchor = AnchorStyles.None;
            deleteBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deleteBtn.Location = new Point(414, 428);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(115, 37);
            deleteBtn.TabIndex = 3;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(search);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(589, 63);
            panel1.TabIndex = 4;
            // 
            // search
            // 
            search.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            search.Location = new Point(37, 13);
            search.Name = "search";
            search.PlaceholderText = "Search";
            search.Size = new Size(353, 33);
            search.TabIndex = 0;
            search.TextChanged += textBox1_TextChanged;
            // 
            // productGrid
            // 
            productGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productGrid.Dock = DockStyle.Top;
            productGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            productGrid.Location = new Point(0, 63);
            productGrid.Name = "productGrid";
            productGrid.RowTemplate.Height = 25;
            productGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productGrid.Size = new Size(589, 348);
            productGrid.TabIndex = 1;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            Controls.Add(productGrid);
            Controls.Add(panel1);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(addBtn);
            Name = "Products";
            Size = new Size(589, 482);
            Load += Products_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button addBtn;
        private Button editBtn;
        private Button deleteBtn;
        private Panel panel1;
        private TextBox search;
        private DataGridView productGrid;
    }
}
