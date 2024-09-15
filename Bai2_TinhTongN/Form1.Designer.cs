namespace Bai2_TinhTongN
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
            txtSoN = new TextBox();
            btnTinhTong = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            txtDetail = new TextBox();
            txtSum = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhap vao so nguyen N";
            // 
            // txtSoN
            // 
            txtSoN.Location = new Point(146, 60);
            txtSoN.Name = "txtSoN";
            txtSoN.Size = new Size(181, 23);
            txtSoN.TabIndex = 1;
            // 
            // btnTinhTong
            // 
            btnTinhTong.Location = new Point(333, 59);
            btnTinhTong.Name = "btnTinhTong";
            btnTinhTong.Size = new Size(75, 23);
            btnTinhTong.TabIndex = 2;
            btnTinhTong.Text = "TinhTong";
            btnTinhTong.UseVisualStyleBackColor = true;
            btnTinhTong.Click += btnTinhTong_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSum);
            groupBox1.Controls.Add(txtDetail);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 103);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "KetQua";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 32);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 0;
            label2.Text = "S =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 63);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 1;
            label3.Text = "S =";
            // 
            // txtDetail
            // 
            txtDetail.Location = new Point(36, 29);
            txtDetail.Name = "txtDetail";
            txtDetail.Size = new Size(354, 23);
            txtDetail.TabIndex = 4;
            // 
            // txtSum
            // 
            txtSum.Location = new Point(36, 58);
            txtSum.Name = "txtSum";
            txtSum.Size = new Size(354, 23);
            txtSum.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 228);
            Controls.Add(groupBox1);
            Controls.Add(btnTinhTong);
            Controls.Add(txtSoN);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSoN;
        private Button btnTinhTong;
        private GroupBox groupBox1;
        private TextBox txtSum;
        private TextBox txtDetail;
        private Label label3;
        private Label label2;
    }
}
