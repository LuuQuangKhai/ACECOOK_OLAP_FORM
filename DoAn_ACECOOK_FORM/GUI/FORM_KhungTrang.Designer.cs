namespace GUI
{
    partial class FORM_KhungTrang
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
            menuStrip1 = new MenuStrip();
            menuItem_TrangChu = new ToolStripMenuItem();
            menuItem_QuanTri = new ToolStripMenuItem();
            panel_KhungTrang = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuItem_TrangChu, menuItem_QuanTri });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1429, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuItem_TrangChu
            // 
            menuItem_TrangChu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            menuItem_TrangChu.ForeColor = Color.Red;
            menuItem_TrangChu.Name = "menuItem_TrangChu";
            menuItem_TrangChu.Size = new Size(81, 21);
            menuItem_TrangChu.Text = "Trang chủ";
            menuItem_TrangChu.Click += menuItem_TrangChu_Click;
            // 
            // menuItem_QuanTri
            // 
            menuItem_QuanTri.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            menuItem_QuanTri.ForeColor = Color.Red;
            menuItem_QuanTri.Name = "menuItem_QuanTri";
            menuItem_QuanTri.Size = new Size(71, 21);
            menuItem_QuanTri.Text = "Quản trị";
            menuItem_QuanTri.Click += menuItem_QuanTri_Click;
            // 
            // panel_KhungTrang
            // 
            panel_KhungTrang.Location = new Point(12, 27);
            panel_KhungTrang.Name = "panel_KhungTrang";
            panel_KhungTrang.Size = new Size(1404, 706);
            panel_KhungTrang.TabIndex = 1;
            // 
            // FORM_KhungTrang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1429, 745);
            Controls.Add(panel_KhungTrang);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FORM_KhungTrang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HỆ THỐNG PHÂN TÍCH DỮ LIỆU ACECOOK";
            Load += FORM_KhungTrang_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuItem_TrangChu;
        private ToolStripMenuItem menuItem_QuanTri;
        private Panel panel_KhungTrang;
    }
}