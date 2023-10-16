namespace InventoryManagementSystem.Forms.CategoryForms
{
    partial class CategoryProducts
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
            productList = new DataGridView();
            panel1 = new Panel();
            cName = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)productList).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // productList
            // 
            productList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productList.Dock = DockStyle.Fill;
            productList.EditMode = DataGridViewEditMode.EditProgrammatically;
            productList.Location = new Point(0, 63);
            productList.Name = "productList";
            productList.RowTemplate.Height = 25;
            productList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productList.Size = new Size(799, 350);
            productList.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(cName);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 63);
            panel1.TabIndex = 7;
            // 
            // cName
            // 
            cName.AutoSize = true;
            cName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cName.Location = new Point(165, 21);
            cName.Name = "cName";
            cName.Size = new Size(143, 25);
            cName.TabIndex = 10;
            cName.Text = "Category Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 21);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 9;
            label1.Text = "Products of:";
            // 
            // CategoryProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 413);
            Controls.Add(productList);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "CategoryProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoryProducts";
            Load += CategoryProducts_Load;
            ((System.ComponentModel.ISupportInitialize)productList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView productList;
        private Panel panel1;
        private Label cName;
        private Label label1;
    }
}