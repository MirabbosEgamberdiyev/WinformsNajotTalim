namespace CRUD.CategoryWindows
{
    partial class EditCategory
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
            saveBtn = new Button();
            name = new TextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(57, 113);
            button2.Name = "button2";
            button2.Size = new Size(141, 51);
            button2.TabIndex = 5;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // saveBtn
            // 
            saveBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            saveBtn.Location = new Point(204, 113);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(141, 51);
            saveBtn.TabIndex = 4;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // name
            // 
            name.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(33, 32);
            name.Name = "name";
            name.Size = new Size(329, 39);
            name.TabIndex = 3;
            name.TextChanged += name_TextChanged;
            // 
            // EditCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 214);
            Controls.Add(button2);
            Controls.Add(saveBtn);
            Controls.Add(name);
            Name = "EditCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditCategory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button saveBtn;
        private TextBox name;
    }
}