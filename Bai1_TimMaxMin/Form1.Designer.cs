namespace Bai1_TimMaxMin
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
            groupBox1 = new GroupBox();
            txtNumber3 = new TextBox();
            txtNumber2 = new TextBox();
            txtNumber1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtMax = new TextBox();
            txtMin = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btnTim = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNumber3);
            groupBox1.Controls.Add(txtNumber2);
            groupBox1.Controls.Add(txtNumber1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(430, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "So Nhap Vao";
            // 
            // txtNumber3
            // 
            txtNumber3.Location = new Point(324, 40);
            txtNumber3.Name = "txtNumber3";
            txtNumber3.Size = new Size(100, 23);
            txtNumber3.TabIndex = 5;
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(167, 40);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(123, 23);
            txtNumber2.TabIndex = 4;
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(27, 40);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(114, 23);
            txtNumber1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(303, 45);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 2;
            label3.Text = "C";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 43);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 1;
            label2.Text = "B";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 0;
            label1.Text = "A";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtMax);
            groupBox2.Controls.Add(txtMin);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(11, 238);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(430, 80);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "KetQua";
            // 
            // txtMax
            // 
            txtMax.Location = new Point(79, 30);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(117, 23);
            txtMax.TabIndex = 6;
            // 
            // txtMin
            // 
            txtMin.Location = new Point(283, 30);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(141, 23);
            txtMin.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(202, 33);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 2;
            label5.Text = "So Nho Nhat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 33);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 1;
            label4.Text = "SoLonNhat";
            // 
            // btnTim
            // 
            btnTim.Location = new Point(187, 197);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(75, 23);
            btnTim.TabIndex = 2;
            btnTim.Text = "Tim";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 330);
            Controls.Add(btnTim);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNumber3;
        private TextBox txtNumber2;
        private TextBox txtNumber1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnTim;
        private TextBox txtMax;
        private TextBox txtMin;
        private Label label5;
        private Label label4;
    }
}
