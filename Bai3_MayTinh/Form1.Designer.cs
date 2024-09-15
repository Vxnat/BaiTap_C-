namespace Bai3_MayTinh
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
            txtInput = new TextBox();
            groupBox1 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn0 = new Button();
            btnReverse = new Button();
            btnDot = new Button();
            groupBox2 = new GroupBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnPlus = new Button();
            btnMinus = new Button();
            btnMark = new Button();
            btnDivide = new Button();
            btnEqual = new Button();
            btnClear = new Button();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.BackColor = SystemColors.ButtonHighlight;
            txtInput.Location = new Point(12, 12);
            txtInput.Name = "txtInput";
            txtInput.ReadOnly = true;
            txtInput.Size = new Size(375, 23);
            txtInput.TabIndex = 0;
            txtInput.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Location = new Point(12, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(255, 198);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Numerical";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btn7);
            flowLayoutPanel1.Controls.Add(btn8);
            flowLayoutPanel1.Controls.Add(btn9);
            flowLayoutPanel1.Controls.Add(btn4);
            flowLayoutPanel1.Controls.Add(btn5);
            flowLayoutPanel1.Controls.Add(btn6);
            flowLayoutPanel1.Controls.Add(btn1);
            flowLayoutPanel1.Controls.Add(btn2);
            flowLayoutPanel1.Controls.Add(btn3);
            flowLayoutPanel1.Controls.Add(btn0);
            flowLayoutPanel1.Controls.Add(btnReverse);
            flowLayoutPanel1.Controls.Add(btnDot);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 19);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(249, 176);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btn7
            // 
            btn7.Location = new Point(3, 3);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 40);
            btn7.TabIndex = 0;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(84, 3);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 40);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(165, 3);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 40);
            btn9.TabIndex = 2;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(3, 49);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 35);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(84, 49);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 35);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(165, 49);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 35);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(3, 90);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 41);
            btn1.TabIndex = 6;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(84, 90);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 41);
            btn2.TabIndex = 7;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(165, 90);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 41);
            btn3.TabIndex = 8;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(3, 137);
            btn0.Name = "btn0";
            btn0.Size = new Size(75, 34);
            btn0.TabIndex = 9;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnReverse
            // 
            btnReverse.Location = new Point(84, 137);
            btnReverse.Name = "btnReverse";
            btnReverse.Size = new Size(75, 34);
            btnReverse.TabIndex = 10;
            btnReverse.Text = "+/-";
            btnReverse.UseVisualStyleBackColor = true;
            btnReverse.Click += btnReverse_Click;
            // 
            // btnDot
            // 
            btnDot.Location = new Point(165, 137);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(75, 34);
            btnDot.TabIndex = 11;
            btnDot.Text = ",";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flowLayoutPanel2);
            groupBox2.Location = new Point(273, 41);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(114, 201);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Operator";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnPlus);
            flowLayoutPanel2.Controls.Add(btnMinus);
            flowLayoutPanel2.Controls.Add(btnMark);
            flowLayoutPanel2.Controls.Add(btnDivide);
            flowLayoutPanel2.Controls.Add(btnEqual);
            flowLayoutPanel2.Controls.Add(btnClear);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 19);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(108, 179);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(3, 3);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(102, 23);
            btnPlus.TabIndex = 12;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(3, 32);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(102, 23);
            btnMinus.TabIndex = 13;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMark
            // 
            btnMark.Location = new Point(3, 61);
            btnMark.Name = "btnMark";
            btnMark.Size = new Size(102, 23);
            btnMark.TabIndex = 14;
            btnMark.Text = "*";
            btnMark.UseVisualStyleBackColor = true;
            btnMark.Click += btnMark_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(3, 90);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(102, 23);
            btnDivide.TabIndex = 15;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(3, 119);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(102, 23);
            btnEqual.TabIndex = 16;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(3, 148);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(102, 23);
            btnClear.TabIndex = 17;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 248);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn0;
        private Button btnReverse;
        private Button btnDot;
        private GroupBox groupBox2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMark;
        private Button btnDivide;
        private Button btnEqual;
        private Button btnClear;
    }
}
