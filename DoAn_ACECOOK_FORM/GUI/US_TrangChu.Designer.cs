namespace GUI
{
    partial class US_TrangChu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btn_ThongTin = new Button();
            lbl_MaNhanVien = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            btn_SaoLuu = new Button();
            btn_KhaiPha = new Button();
            btn_ThongKe = new Button();
            btn_PhanTich = new Button();
            btn_NapDuLieu = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel_TrangChu = new Panel();
            panel2 = new Panel();
            label8 = new Label();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel_TrangChu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_ThongTin);
            panel1.Controls.Add(lbl_MaNhanVien);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_SaoLuu);
            panel1.Controls.Add(btn_KhaiPha);
            panel1.Controls.Add(btn_ThongKe);
            panel1.Controls.Add(btn_PhanTich);
            panel1.Controls.Add(btn_NapDuLieu);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 700);
            panel1.TabIndex = 0;
            // 
            // btn_ThongTin
            // 
            btn_ThongTin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ThongTin.ForeColor = Color.Gray;
            btn_ThongTin.Location = new Point(7, 636);
            btn_ThongTin.Name = "btn_ThongTin";
            btn_ThongTin.Size = new Size(150, 23);
            btn_ThongTin.TabIndex = 12;
            btn_ThongTin.Text = "Chỉnh sửa thông tin";
            btn_ThongTin.UseVisualStyleBackColor = true;
            btn_ThongTin.Click += btn_ThongTin_Click;
            // 
            // lbl_MaNhanVien
            // 
            lbl_MaNhanVien.AutoSize = true;
            lbl_MaNhanVien.ForeColor = Color.Red;
            lbl_MaNhanVien.Location = new Point(89, 618);
            lbl_MaNhanVien.Name = "lbl_MaNhanVien";
            lbl_MaNhanVien.Size = new Size(41, 15);
            lbl_MaNhanVien.TabIndex = 11;
            lbl_MaNhanVien.Text = "NV001";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(7, 618);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 10;
            label3.Text = "Mã nhân viên:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.avata;
            pictureBox1.Location = new Point(7, 465);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btn_SaoLuu
            // 
            btn_SaoLuu.BackColor = Color.IndianRed;
            btn_SaoLuu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_SaoLuu.ForeColor = Color.White;
            btn_SaoLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btn_SaoLuu.Location = new Point(3, 358);
            btn_SaoLuu.Name = "btn_SaoLuu";
            btn_SaoLuu.Padding = new Padding(6, 0, 0, 0);
            btn_SaoLuu.Size = new Size(159, 43);
            btn_SaoLuu.TabIndex = 8;
            btn_SaoLuu.Text = "SAO LƯU";
            btn_SaoLuu.TextAlign = ContentAlignment.MiddleLeft;
            btn_SaoLuu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_SaoLuu.UseVisualStyleBackColor = false;
            btn_SaoLuu.Click += btn_SaoLuu_Click;
            // 
            // btn_KhaiPha
            // 
            btn_KhaiPha.BackColor = Color.IndianRed;
            btn_KhaiPha.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_KhaiPha.ForeColor = Color.White;
            btn_KhaiPha.ImageAlign = ContentAlignment.MiddleLeft;
            btn_KhaiPha.Location = new Point(3, 309);
            btn_KhaiPha.Name = "btn_KhaiPha";
            btn_KhaiPha.Padding = new Padding(6, 0, 0, 0);
            btn_KhaiPha.Size = new Size(158, 43);
            btn_KhaiPha.TabIndex = 7;
            btn_KhaiPha.Text = "KHAI PHÁ";
            btn_KhaiPha.TextAlign = ContentAlignment.MiddleLeft;
            btn_KhaiPha.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_KhaiPha.UseVisualStyleBackColor = false;
            btn_KhaiPha.Click += btn_KhaiPha_Click;
            // 
            // btn_ThongKe
            // 
            btn_ThongKe.BackColor = Color.IndianRed;
            btn_ThongKe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_ThongKe.ForeColor = Color.White;
            btn_ThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ThongKe.Location = new Point(3, 260);
            btn_ThongKe.Name = "btn_ThongKe";
            btn_ThongKe.Padding = new Padding(6, 0, 0, 0);
            btn_ThongKe.Size = new Size(158, 43);
            btn_ThongKe.TabIndex = 6;
            btn_ThongKe.Text = "THỐNG KÊ";
            btn_ThongKe.TextAlign = ContentAlignment.MiddleLeft;
            btn_ThongKe.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_ThongKe.UseVisualStyleBackColor = false;
            btn_ThongKe.Click += btn_ThongKe_Click;
            // 
            // btn_PhanTich
            // 
            btn_PhanTich.BackColor = Color.IndianRed;
            btn_PhanTich.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_PhanTich.ForeColor = Color.White;
            btn_PhanTich.ImageAlign = ContentAlignment.MiddleLeft;
            btn_PhanTich.Location = new Point(3, 211);
            btn_PhanTich.Name = "btn_PhanTich";
            btn_PhanTich.Padding = new Padding(6, 0, 0, 0);
            btn_PhanTich.Size = new Size(159, 43);
            btn_PhanTich.TabIndex = 5;
            btn_PhanTich.Text = "PHÂN TÍCH";
            btn_PhanTich.TextAlign = ContentAlignment.MiddleLeft;
            btn_PhanTich.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_PhanTich.UseVisualStyleBackColor = false;
            btn_PhanTich.Click += btn_PhanTich_Click;
            // 
            // btn_NapDuLieu
            // 
            btn_NapDuLieu.BackColor = Color.IndianRed;
            btn_NapDuLieu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_NapDuLieu.ForeColor = Color.White;
            btn_NapDuLieu.ImageAlign = ContentAlignment.MiddleLeft;
            btn_NapDuLieu.Location = new Point(3, 162);
            btn_NapDuLieu.Name = "btn_NapDuLieu";
            btn_NapDuLieu.Padding = new Padding(6, 0, 0, 0);
            btn_NapDuLieu.Size = new Size(158, 43);
            btn_NapDuLieu.TabIndex = 4;
            btn_NapDuLieu.Text = "NẠP DỮ LIỆU";
            btn_NapDuLieu.TextAlign = ContentAlignment.MiddleLeft;
            btn_NapDuLieu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_NapDuLieu.UseVisualStyleBackColor = false;
            btn_NapDuLieu.Click += btn_NapDuLieu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(16, 136);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 3;
            label2.Text = "Chức năng hệ thống";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(5, 94);
            label1.Name = "label1";
            label1.Size = new Size(156, 37);
            label1.TabIndex = 2;
            label1.Text = "HỆ THỐNG";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Red;
            pictureBox2.Image = Properties.Resources.logo_acecook;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(159, 88);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel_TrangChu
            // 
            panel_TrangChu.Controls.Add(pictureBox3);
            panel_TrangChu.Controls.Add(panel2);
            panel_TrangChu.Location = new Point(170, 3);
            panel_TrangChu.Name = "panel_TrangChu";
            panel_TrangChu.Size = new Size(1231, 700);
            panel_TrangChu.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Controls.Add(label8);
            panel2.Location = new Point(4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1224, 88);
            panel2.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(32, 18);
            label8.Name = "label8";
            label8.Size = new Size(1149, 47);
            label8.TabIndex = 0;
            label8.Text = "HỆ THỐNG PHÂN TÍCH DỮ LIỆU KINH DOANH ACECOOK VIỆT NAM";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Screenshot_2024_06_20_155311;
            pictureBox3.Location = new Point(4, 97);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1224, 600);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // US_TrangChu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_TrangChu);
            Controls.Add(panel1);
            Name = "US_TrangChu";
            Size = new Size(1404, 706);
            Load += US_TrangChu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel_TrangChu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel_TrangChu;
        private Button btn_SaoLuu;
        private Button btn_KhaiPha;
        private Button btn_ThongKe;
        private Button btn_PhanTich;
        private Button btn_NapDuLieu;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label lbl_MaNhanVien;
        private Button btn_ThongTin;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Label label8;
    }
}
