namespace NguyenMinhKhang_Buoi1._1
{
    partial class Bai2
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
            label5 = new Label();
            label6 = new Label();
            txt_nhapso = new TextBox();
            txt_dayvuanhap = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            btn_nhapso = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(84, 40);
            label1.Name = "label1";
            label1.Size = new Size(464, 45);
            label1.TabIndex = 0;
            label1.Text = "Nhập Dãy Số Và Tính Tổng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 129);
            label2.Name = "label2";
            label2.Size = new Size(100, 29);
            label2.TabIndex = 1;
            label2.Text = "Nhập số";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 182);
            label3.Name = "label3";
            label3.Size = new Size(167, 29);
            label3.TabIndex = 2;
            label3.Text = "Dãy Vừa Nhập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 241);
            label4.Name = "label4";
            label4.Size = new Size(310, 29);
            label4.TabIndex = 1;
            label4.Text = "Tổng các phần tử trong dãy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 300);
            label5.Name = "label5";
            label5.Size = new Size(132, 29);
            label5.TabIndex = 2;
            label5.Text = "Tổng chẵn ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(326, 300);
            label6.Name = "label6";
            label6.Size = new Size(92, 29);
            label6.TabIndex = 2;
            label6.Text = "Tổng lẽ";
            // 
            // txt_nhapso
            // 
            txt_nhapso.BorderStyle = BorderStyle.FixedSingle;
            txt_nhapso.Location = new Point(136, 129);
            txt_nhapso.Name = "txt_nhapso";
            txt_nhapso.Size = new Size(137, 36);
            txt_nhapso.TabIndex = 3;
            txt_nhapso.TextChanged += textBox1_TextChanged;
            // 
            // txt_dayvuanhap
            // 
            txt_dayvuanhap.BorderStyle = BorderStyle.FixedSingle;
            txt_dayvuanhap.Location = new Point(185, 182);
            txt_dayvuanhap.Name = "txt_dayvuanhap";
            txt_dayvuanhap.Size = new Size(258, 36);
            txt_dayvuanhap.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(343, 238);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 36);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(150, 297);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(151, 36);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(424, 297);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(136, 36);
            textBox5.TabIndex = 3;
            // 
            // btn_nhapso
            // 
            btn_nhapso.BackColor = Color.Cyan;
            btn_nhapso.Location = new Point(301, 124);
            btn_nhapso.Name = "btn_nhapso";
            btn_nhapso.Size = new Size(99, 41);
            btn_nhapso.TabIndex = 4;
            btn_nhapso.Text = "Nhập";
            btn_nhapso.UseVisualStyleBackColor = false;
            btn_nhapso.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGoldenrod;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(100, 381);
            button2.Name = "button2";
            button2.Size = new Size(144, 41);
            button2.TabIndex = 4;
            button2.Text = "Tiếp Tục";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Salmon;
            button3.Location = new Point(344, 381);
            button3.Name = "button3";
            button3.Size = new Size(141, 41);
            button3.TabIndex = 4;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(618, 708);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btn_nhapso);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(txt_dayvuanhap);
            Controls.Add(txt_nhapso);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Bai2";
            Text = "Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_nhapso;
        private TextBox txt_dayvuanhap;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button btn_nhapso;
        private Button button2;
        private Button button3;
    }
}