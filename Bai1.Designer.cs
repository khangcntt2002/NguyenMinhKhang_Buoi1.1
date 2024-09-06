namespace NguyenMinhKhang_Buoi1._1
{
    partial class Bai1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 24);
            label1.Name = "label1";
            label1.Size = new Size(267, 29);
            label1.TabIndex = 0;
            label1.Text = "Giải Phương Trình Bật 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(121, 29);
            label2.TabIndex = 1;
            label2.Text = "Nhập số a";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 127);
            label3.Name = "label3";
            label3.Size = new Size(121, 29);
            label3.TabIndex = 2;
            label3.Text = "Nhập số b";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 180);
            label4.Name = "label4";
            label4.Size = new Size(119, 29);
            label4.TabIndex = 3;
            label4.Text = "Nhập số c";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 36);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(174, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 36);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(174, 180);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(215, 36);
            textBox3.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 231);
            label5.Name = "label5";
            label5.Size = new Size(99, 29);
            label5.TabIndex = 3;
            label5.Text = "Kết Quả";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(174, 224);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(293, 36);
            textBox4.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(46, 314);
            button1.Name = "button1";
            button1.Size = new Size(85, 46);
            button1.TabIndex = 5;
            button1.Text = "Giải";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(174, 314);
            button2.Name = "button2";
            button2.Size = new Size(100, 46);
            button2.TabIndex = 5;
            button2.Text = "RESET";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(301, 314);
            button3.Name = "button3";
            button3.Size = new Size(122, 46);
            button3.TabIndex = 5;
            button3.Text = "THOÁT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(555, 406);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Bai1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bai1";
            WindowState = FormWindowState.Maximized;
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
        private Label label5;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}