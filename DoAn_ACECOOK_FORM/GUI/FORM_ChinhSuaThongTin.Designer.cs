namespace GUI
{
    partial class FORM_ChinhSuaThongTin
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
            groupBox1 = new GroupBox();
            btn_Sua = new PictureBox();
            groupBox3 = new GroupBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            txt_DiaChi = new TextBox();
            label7 = new Label();
            txt_MatKhau = new TextBox();
            label6 = new Label();
            txt_CCCD = new TextBox();
            label5 = new Label();
            txt_SDT = new TextBox();
            label4 = new Label();
            txt_Email = new TextBox();
            label3 = new Label();
            txt_TenNhanVien = new TextBox();
            label2 = new Label();
            txt_MaNhanVien = new TextBox();
            label1 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_Sua).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btn_Sua);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(txt_DiaChi);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txt_MatKhau);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_CCCD);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_SDT);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_Email);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_TenNhanVien);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_MaNhanVien);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(683, 305);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // btn_Sua
            // 
            btn_Sua.Image = Properties.Resources.update;
            btn_Sua.Location = new Point(359, 222);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(35, 35);
            btn_Sua.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Sua.TabIndex = 17;
            btn_Sua.TabStop = false;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBox6);
            groupBox3.Controls.Add(checkBox5);
            groupBox3.Controls.Add(checkBox4);
            groupBox3.Controls.Add(checkBox3);
            groupBox3.Controls.Add(checkBox2);
            groupBox3.Controls.Add(checkBox1);
            groupBox3.Location = new Point(524, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(153, 276);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Quyền của bạn";
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Enabled = false;
            checkBox6.Font = new Font("Segoe UI", 9F);
            checkBox6.Location = new Point(32, 240);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(65, 19);
            checkBox6.TabIndex = 5;
            checkBox6.Text = "Sao lưu";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Enabled = false;
            checkBox5.Font = new Font("Segoe UI", 9F);
            checkBox5.Location = new Point(32, 197);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(72, 19);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Khai phá";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Enabled = false;
            checkBox4.Font = new Font("Segoe UI", 9F);
            checkBox4.Location = new Point(32, 154);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(75, 19);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Thống kê";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Enabled = false;
            checkBox3.Font = new Font("Segoe UI", 9F);
            checkBox3.Location = new Point(32, 111);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(76, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Phân tích";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Enabled = false;
            checkBox2.Font = new Font("Segoe UI", 9F);
            checkBox2.Location = new Point(32, 68);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(87, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Nạp dữ liệu";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Enabled = false;
            checkBox1.Font = new Font("Segoe UI", 9F);
            checkBox1.Location = new Point(32, 25);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(69, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Quản trị";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Font = new Font("Segoe UI", 9F);
            txt_DiaChi.Location = new Point(284, 176);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(209, 23);
            txt_DiaChi.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(284, 158);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 12;
            label7.Text = "Địa chỉ";
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Font = new Font("Segoe UI", 9F);
            txt_MatKhau.Location = new Point(284, 118);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new Size(209, 23);
            txt_MatKhau.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(284, 100);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 10;
            label6.Text = "Mật khẩu";
            // 
            // txt_CCCD
            // 
            txt_CCCD.Font = new Font("Segoe UI", 9F);
            txt_CCCD.Location = new Point(284, 60);
            txt_CCCD.Name = "txt_CCCD";
            txt_CCCD.Size = new Size(209, 23);
            txt_CCCD.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(284, 42);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 8;
            label5.Text = "Căn cước công dân";
            // 
            // txt_SDT
            // 
            txt_SDT.Font = new Font("Segoe UI", 9F);
            txt_SDT.Location = new Point(30, 234);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(209, 23);
            txt_SDT.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(30, 216);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 6;
            label4.Text = "Số điện thoại";
            // 
            // txt_Email
            // 
            txt_Email.Font = new Font("Segoe UI", 9F);
            txt_Email.Location = new Point(30, 176);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(209, 23);
            txt_Email.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(30, 158);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // txt_TenNhanVien
            // 
            txt_TenNhanVien.Font = new Font("Segoe UI", 9F);
            txt_TenNhanVien.Location = new Point(30, 118);
            txt_TenNhanVien.Name = "txt_TenNhanVien";
            txt_TenNhanVien.Size = new Size(209, 23);
            txt_TenNhanVien.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(30, 100);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 2;
            label2.Text = "Tên nhân viên";
            // 
            // txt_MaNhanVien
            // 
            txt_MaNhanVien.Font = new Font("Segoe UI", 9F);
            txt_MaNhanVien.Location = new Point(30, 60);
            txt_MaNhanVien.Name = "txt_MaNhanVien";
            txt_MaNhanVien.Size = new Size(209, 23);
            txt_MaNhanVien.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(30, 42);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(400, 231);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 18;
            label8.Text = "Lưu thông tin";
            // 
            // FORM_ChinhSuaThongTin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(707, 329);
            Controls.Add(groupBox1);
            Name = "FORM_ChinhSuaThongTin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "THÔNG TIN NHÂN VIÊN";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_Sua).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox btn_Sua;
        private GroupBox groupBox3;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private TextBox txt_DiaChi;
        private Label label7;
        private TextBox txt_MatKhau;
        private Label label6;
        private TextBox txt_CCCD;
        private Label label5;
        private TextBox txt_SDT;
        private Label label4;
        private TextBox txt_Email;
        private Label label3;
        private TextBox txt_TenNhanVien;
        private Label label2;
        private TextBox txt_MaNhanVien;
        private Label label1;
        private Label label8;
    }
}