namespace CRUD_EF
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
            panel2 = new Panel();
            delete = new Button();
            edit = new Button();
            add = new Button();
            refresh = new Button();
            dataGridView1 = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(834, 66);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(delete);
            panel2.Controls.Add(edit);
            panel2.Controls.Add(add);
            panel2.Controls.Add(refresh);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 431);
            panel2.Name = "panel2";
            panel2.Size = new Size(834, 66);
            panel2.TabIndex = 1;
            // 
            // delete
            // 
            delete.Anchor = AnchorStyles.None;
            delete.BackColor = Color.FromArgb(255, 128, 128);
            delete.Enabled = false;
            delete.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            delete.Location = new Point(634, 9);
            delete.Name = "delete";
            delete.Size = new Size(166, 48);
            delete.TabIndex = 3;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // edit
            // 
            edit.Anchor = AnchorStyles.None;
            edit.BackColor = Color.FromArgb(224, 224, 224);
            edit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            edit.Location = new Point(434, 9);
            edit.Name = "edit";
            edit.Size = new Size(166, 48);
            edit.TabIndex = 2;
            edit.Text = "Edit";
            edit.UseVisualStyleBackColor = false;
            edit.Click += edit_Click;
            // 
            // add
            // 
            add.Anchor = AnchorStyles.None;
            add.BackColor = Color.FromArgb(128, 255, 128);
            add.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            add.Location = new Point(234, 9);
            add.Name = "add";
            add.Size = new Size(166, 48);
            add.TabIndex = 1;
            add.Text = "Add new";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // refresh
            // 
            refresh.Anchor = AnchorStyles.None;
            refresh.BackColor = Color.FromArgb(192, 255, 255);
            refresh.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            refresh.Location = new Point(34, 9);
            refresh.Name = "refresh";
            refresh.Size = new Size(166, 48);
            refresh.TabIndex = 0;
            refresh.Text = "Refresh";
            refresh.UseVisualStyleBackColor = false;
            refresh.Click += refresh_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(0, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(834, 365);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 497);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button delete;
        private Button edit;
        private Button add;
        private Button refresh;
    }
}