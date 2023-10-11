namespace CRUD.ProductWindows
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
            label1 = new Label();
            name = new TextBox();
            label2 = new Label();
            label3 = new Label();
            price = new MaskedTextBox();
            description = new RichTextBox();
            label4 = new Label();
            categorySelect = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 30);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // name
            // 
            name.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(28, 58);
            name.Name = "name";
            name.Size = new Size(256, 33);
            name.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 114);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 2;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(336, 30);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 4;
            label3.Text = "Price";
            // 
            // price
            // 
            price.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            price.Location = new Point(336, 58);
            price.Mask = "0000000000000000000";
            price.Name = "price";
            price.Size = new Size(256, 33);
            price.TabIndex = 5;
            // 
            // description
            // 
            description.Location = new Point(28, 142);
            description.Name = "description";
            description.Size = new Size(564, 159);
            description.TabIndex = 6;
            description.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(28, 321);
            label4.Name = "label4";
            label4.Size = new Size(143, 25);
            label4.TabIndex = 7;
            label4.Text = "Select Category";
            // 
            // categorySelect
            // 
            categorySelect.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            categorySelect.FormattingEnabled = true;
            categorySelect.Location = new Point(28, 349);
            categorySelect.Name = "categorySelect";
            categorySelect.Size = new Size(564, 33);
            categorySelect.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(122, 404);
            button1.Name = "button1";
            button1.Size = new Size(149, 50);
            button1.TabIndex = 9;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(336, 404);
            button2.Name = "button2";
            button2.Size = new Size(149, 50);
            button2.TabIndex = 10;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // EditProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 481);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(categorySelect);
            Controls.Add(label4);
            Controls.Add(description);
            Controls.Add(price);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(name);
            Controls.Add(label1);
            Name = "EditProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditProduct";
            Load += EditProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox name;
        private Label label2;
        private Label label3;
        private MaskedTextBox price;
        private RichTextBox description;
        private Label label4;
        private ComboBox categorySelect;
        private Button button1;
        private Button button2;
    }
}