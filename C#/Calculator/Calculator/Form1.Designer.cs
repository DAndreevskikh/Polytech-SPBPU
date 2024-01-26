namespace Calculator
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
            textBox_Result = new TextBox();
            equation = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            buttonPlus = new Button();
            buttonMinus = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            buttonMultiply = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            buttonDivide = new Button();
            buttonCE = new Button();
            buttonComma = new Button();
            button0 = new Button();
            buttonEquals = new Button();
            SuspendLayout();
            // 
            // textBox_Result
            // 
            textBox_Result.BackColor = Color.Khaki;
            textBox_Result.Location = new Point(12, 12);
            textBox_Result.Name = "textBox_Result";
            textBox_Result.ReadOnly = true;
            textBox_Result.Size = new Size(160, 27);
            textBox_Result.TabIndex = 0;
            // 
            // equation
            // 
            equation.BackColor = Color.Khaki;
            equation.Location = new Point(201, 12);
            equation.Name = "equation";
            equation.ReadOnly = true;
            equation.Size = new Size(50, 27);
            equation.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 55);
            button1.Name = "button1";
            button1.Size = new Size(50, 46);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.Location = new Point(68, 55);
            button2.Name = "button2";
            button2.Size = new Size(50, 46);
            button2.TabIndex = 3;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.Location = new Point(122, 55);
            button3.Name = "button3";
            button3.Size = new Size(50, 46);
            button3.TabIndex = 4;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(201, 55);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(50, 46);
            buttonPlus.TabIndex = 5;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += operator_click;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(201, 107);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(50, 46);
            buttonMinus.TabIndex = 9;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += operator_click;
            // 
            // button6
            // 
            button6.Location = new Point(122, 107);
            button6.Name = "button6";
            button6.Size = new Size(50, 46);
            button6.TabIndex = 8;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            // 
            // button5
            // 
            button5.Location = new Point(68, 107);
            button5.Name = "button5";
            button5.Size = new Size(50, 46);
            button5.TabIndex = 7;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 107);
            button4.Name = "button4";
            button4.Size = new Size(50, 46);
            button4.TabIndex = 6;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(201, 159);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(50, 46);
            buttonMultiply.TabIndex = 13;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += operator_click;
            // 
            // button9
            // 
            button9.Location = new Point(122, 159);
            button9.Name = "button9";
            button9.Size = new Size(50, 46);
            button9.TabIndex = 12;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            // 
            // button8
            // 
            button8.Location = new Point(68, 159);
            button8.Name = "button8";
            button8.Size = new Size(50, 46);
            button8.TabIndex = 11;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            // 
            // button7
            // 
            button7.Location = new Point(12, 159);
            button7.Name = "button7";
            button7.Size = new Size(50, 46);
            button7.TabIndex = 10;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Location = new Point(201, 211);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(50, 46);
            buttonDivide.TabIndex = 17;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += operator_click;
            // 
            // buttonCE
            // 
            buttonCE.Location = new Point(122, 211);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(50, 46);
            buttonCE.TabIndex = 16;
            buttonCE.Text = "C";
            buttonCE.UseVisualStyleBackColor = true;
            buttonCE.Click += buttonCE_Click;
            // 
            // buttonComma
            // 
            buttonComma.Location = new Point(68, 211);
            buttonComma.Name = "buttonComma";
            buttonComma.Size = new Size(50, 46);
            buttonComma.TabIndex = 15;
            buttonComma.Text = ",";
            buttonComma.UseVisualStyleBackColor = true;
            buttonComma.Click += button_Click;
            // 
            // button0
            // 
            button0.Location = new Point(12, 211);
            button0.Name = "button0";
            button0.Size = new Size(50, 46);
            button0.TabIndex = 14;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.Location = new Point(12, 263);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(239, 46);
            buttonEquals.TabIndex = 18;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = true;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 328);
            Controls.Add(buttonEquals);
            Controls.Add(buttonDivide);
            Controls.Add(buttonCE);
            Controls.Add(buttonComma);
            Controls.Add(button0);
            Controls.Add(buttonMultiply);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(buttonMinus);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(buttonPlus);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(equation);
            Controls.Add(textBox_Result);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyPress += CalculatorForm_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Result;
        private TextBox equation;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button buttonPlus;
        private Button buttonMinus;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button buttonMultiply;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button buttonDivide;
        private Button buttonCE;
        private Button buttonComma;
        private Button button0;
        private Button buttonEquals;
    }
}