namespace _1_dars
{
    partial class Form3
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
            phoneNumber = new MaskedTextBox();
            label2 = new Label();
            text = new RichTextBox();
            sendBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 0;
            label1.Text = "Tel nomer:";
            // 
            // phoneNumber
            // 
            phoneNumber.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            phoneNumber.Location = new Point(127, 21);
            phoneNumber.Mask = "+000-00-000-00-00";
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Size = new Size(232, 35);
            phoneNumber.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(71, 30);
            label2.TabIndex = 2;
            label2.Text = "Xabar:";
            // 
            // text
            // 
            text.Location = new Point(19, 121);
            text.Name = "text";
            text.Size = new Size(394, 256);
            text.TabIndex = 3;
            text.Text = "";
            // 
            // sendBtn
            // 
            sendBtn.BackColor = Color.FromArgb(0, 192, 0);
            sendBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            sendBtn.Location = new Point(127, 383);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(180, 61);
            sendBtn.TabIndex = 4;
            sendBtn.Text = "Send";
            sendBtn.UseVisualStyleBackColor = false;
            sendBtn.Click += sendBtn_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 456);
            Controls.Add(sendBtn);
            Controls.Add(text);
            Controls.Add(label2);
            Controls.Add(phoneNumber);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox phoneNumber;
        private Label label2;
        private RichTextBox text;
        private Button sendBtn;
    }
}