namespace NguyenMinhKhang_Buoi1._1
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
            menuStrip1 = new MenuStrip();
            bàiTậpToolStripMenuItem = new ToolStripMenuItem();
            bài1ToolStripMenuItem = new ToolStripMenuItem();
            bài2ToolStripMenuItem = new ToolStripMenuItem();
            bài3ToolStripMenuItem = new ToolStripMenuItem();
            bài4ToolStripMenuItem = new ToolStripMenuItem();
            bài5ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { bàiTậpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // bàiTậpToolStripMenuItem
            // 
            bàiTậpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bài1ToolStripMenuItem, bài2ToolStripMenuItem, bài3ToolStripMenuItem, bài4ToolStripMenuItem, bài5ToolStripMenuItem });
            bàiTậpToolStripMenuItem.Name = "bàiTậpToolStripMenuItem";
            bàiTậpToolStripMenuItem.Size = new Size(57, 20);
            bàiTậpToolStripMenuItem.Text = "Bài Tập";
            bàiTậpToolStripMenuItem.Click += bàiTậpToolStripMenuItem_Click;
            // 
            // bài1ToolStripMenuItem
            // 
            bài1ToolStripMenuItem.Name = "bài1ToolStripMenuItem";
            bài1ToolStripMenuItem.Size = new Size(180, 22);
            bài1ToolStripMenuItem.Text = "Bài 1";
            bài1ToolStripMenuItem.Click += bài1ToolStripMenuItem_Click;
            // 
            // bài2ToolStripMenuItem
            // 
            bài2ToolStripMenuItem.Name = "bài2ToolStripMenuItem";
            bài2ToolStripMenuItem.Size = new Size(180, 22);
            bài2ToolStripMenuItem.Text = "Bài 2";
            bài2ToolStripMenuItem.Click += bài2ToolStripMenuItem_Click;
            // 
            // bài3ToolStripMenuItem
            // 
            bài3ToolStripMenuItem.Name = "bài3ToolStripMenuItem";
            bài3ToolStripMenuItem.Size = new Size(180, 22);
            bài3ToolStripMenuItem.Text = "Bài 3";
            bài3ToolStripMenuItem.Click += bài3ToolStripMenuItem_Click;
            // 
            // bài4ToolStripMenuItem
            // 
            bài4ToolStripMenuItem.Name = "bài4ToolStripMenuItem";
            bài4ToolStripMenuItem.Size = new Size(180, 22);
            bài4ToolStripMenuItem.Text = "Bài 4";
            bài4ToolStripMenuItem.Click += bài4ToolStripMenuItem_Click;
            // 
            // bài5ToolStripMenuItem
            // 
            bài5ToolStripMenuItem.Name = "bài5ToolStripMenuItem";
            bài5ToolStripMenuItem.Size = new Size(180, 22);
            bài5ToolStripMenuItem.Text = "Bài 5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem bàiTậpToolStripMenuItem;
        private ToolStripMenuItem bài1ToolStripMenuItem;
        private ToolStripMenuItem bài2ToolStripMenuItem;
        private ToolStripMenuItem bài3ToolStripMenuItem;
        private ToolStripMenuItem bài4ToolStripMenuItem;
        private ToolStripMenuItem bài5ToolStripMenuItem;
    }
}
