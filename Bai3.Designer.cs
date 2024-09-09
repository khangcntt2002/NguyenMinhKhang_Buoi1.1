namespace NguyenMinhKhang_Buoi1._1
{
    partial class Bai3
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_Nhap = new TextBox();
            txt_Kq = new TextBox();
            txt_N = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(15, 25);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(464, 40);
            label1.TabIndex = 0;
            label1.Text = "Kiểm Tra Và tìm số nguyên tố";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 85);
            label2.Name = "label2";
            label2.Size = new Size(97, 29);
            label2.TabIndex = 1;
            label2.Text = "Nhập n:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(162, 29);
            label3.TabIndex = 1;
            label3.Text = "Kiểm tra SNT:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 186);
            label4.Name = "label4";
            label4.Size = new Size(180, 29);
            label4.TabIndex = 1;
            label4.Text = "SNT nhỏ hơn n:";
            label4.Click += label3_Click;
            // 
            // txt_Nhap
            // 
            txt_Nhap.Location = new Point(170, 85);
            txt_Nhap.Name = "txt_Nhap";
            txt_Nhap.Size = new Size(225, 36);
            txt_Nhap.TabIndex = 2;
            txt_Nhap.TextChanged += txt_Nhap_TextChanged;
            // 
            // txt_Kq
            // 
            txt_Kq.Location = new Point(170, 127);
            txt_Kq.Name = "txt_Kq";
            txt_Kq.Size = new Size(225, 36);
            txt_Kq.TabIndex = 2;
            // 
            // txt_N
            // 
            txt_N.Location = new Point(198, 179);
            txt_N.Name = "txt_N";
            txt_N.Size = new Size(225, 36);
            txt_N.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Location = new Point(419, 85);
            button1.Name = "button1";
            button1.Size = new Size(84, 68);
            button1.TabIndex = 3;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 280);
            Controls.Add(button1);
            Controls.Add(txt_N);
            Controls.Add(txt_Kq);
            Controls.Add(txt_Nhap);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Bai3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bai3";
            WindowState = FormWindowState.Maximized;
            Load += Bai3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private TextBox txt_Kq;
        private TextBox txt_Nhap;
        private TextBox txt_N;
    }
}