namespace PhoneBook
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtFerstName = new TextBox();
            txtPhone = new MaskedTextBox();
            lblCount = new Label();
            btnLeft = new Button();
            btnAdd = new Button();
            btnNext = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Имя";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 98);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Телефон";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 144);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 3;
            label4.Text = "Почта";
            label4.Click += label4_Click;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(93, 6);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(174, 27);
            txtLastName.TabIndex = 4;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(93, 141);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(174, 27);
            txtEmail.TabIndex = 5;
            txtEmail.TextChanged += txtLastName_TextChanged;
            // 
            // txtFerstName
            // 
            txtFerstName.Location = new Point(93, 51);
            txtFerstName.Name = "txtFerstName";
            txtFerstName.Size = new Size(174, 27);
            txtFerstName.TabIndex = 7;
            txtFerstName.TextChanged += txtLastName_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(93, 96);
            txtPhone.Mask = "(999) 000-0000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(174, 27);
            txtPhone.TabIndex = 8;
            txtPhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblCount
            // 
            lblCount.BackColor = Color.FromArgb(255, 255, 128);
            lblCount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblCount.Location = new Point(12, 204);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(273, 25);
            lblCount.TabIndex = 9;
            lblCount.Text = "Новая запись";
            lblCount.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLeft
            // 
            btnLeft.Enabled = false;
            btnLeft.ImageAlign = ContentAlignment.MiddleLeft;
            btnLeft.Location = new Point(14, 258);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(94, 29);
            btnLeft.TabIndex = 10;
            btnLeft.Text = "<<";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Click += btnLeft_Click;
            // 
            // btnAdd
            // 
            btnAdd.Enabled = false;
            btnAdd.Location = new Point(98, 318);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnNext
            // 
            btnNext.Enabled = false;
            btnNext.ImageAlign = ContentAlignment.MiddleRight;
            btnNext.Location = new Point(191, 258);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 12;
            btnNext.Text = ">>";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 363);
            Controls.Add(btnNext);
            Controls.Add(btnAdd);
            Controls.Add(btnLeft);
            Controls.Add(lblCount);
            Controls.Add(txtPhone);
            Controls.Add(txtFerstName);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtFerstName;
        private MaskedTextBox txtPhone;
        private Label lblCount;
        private Button btnLeft;
        private Button btnAdd;
        private Button btnNext;
    }
}