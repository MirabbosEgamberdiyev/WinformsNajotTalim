namespace CRUD
{
    partial class Categories
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
            categoryGrid = new DataGridView();
            addBtn = new Button();
            editBtn = new Button();
            deleteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)categoryGrid).BeginInit();
            SuspendLayout();
            // 
            // categoryGrid
            // 
            categoryGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            categoryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categoryGrid.Dock = DockStyle.Top;
            categoryGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            categoryGrid.Location = new Point(0, 0);
            categoryGrid.Name = "categoryGrid";
            categoryGrid.RowTemplate.Height = 25;
            categoryGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            categoryGrid.Size = new Size(589, 413);
            categoryGrid.TabIndex = 0;
            categoryGrid.CellClick += categoryGrid_CellClick;
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
            // Categories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(addBtn);
            Controls.Add(categoryGrid);
            Name = "Categories";
            Size = new Size(589, 482);
            Load += Categories_Load;
            ((System.ComponentModel.ISupportInitialize)categoryGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView categoryGrid;
        private Button addBtn;
        private Button editBtn;
        private Button deleteBtn;
    }
}
