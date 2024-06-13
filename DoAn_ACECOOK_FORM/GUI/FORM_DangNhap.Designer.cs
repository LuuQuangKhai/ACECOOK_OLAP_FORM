namespace GUI
{
    partial class FORM_DangNhap
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
            panel1 = new Panel();
            pictureBox_AnHienMatKhau = new PictureBox();
            label5 = new Label();
            btn_QuenMatKhau = new Button();
            btn_DangNhap = new Button();
            txt_MatKhau = new TextBox();
            txt_TenDangNhap = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_AnHienMatKhau).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(pictureBox_AnHienMatKhau);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btn_QuenMatKhau);
            panel1.Controls.Add(btn_DangNhap);
            panel1.Controls.Add(txt_MatKhau);
            panel1.Controls.Add(txt_TenDangNhap);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 399);
            panel1.TabIndex = 0;
            // 
            // pictureBox_AnHienMatKhau
            // 
            pictureBox_AnHienMatKhau.Image = Properties.Resources.an;
            pictureBox_AnHienMatKhau.Location = new Point(324, 245);
            pictureBox_AnHienMatKhau.Name = "pictureBox_AnHienMatKhau";
            pictureBox_AnHienMatKhau.Size = new Size(27, 23);
            pictureBox_AnHienMatKhau.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_AnHienMatKhau.TabIndex = 10;
            pictureBox_AnHienMatKhau.TabStop = false;
            pictureBox_AnHienMatKhau.Click += pictureBox_AnHienMatKhau_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(33, 91);
            label5.Name = "label5";
            label5.Size = new Size(351, 40);
            label5.TabIndex = 9;
            label5.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // btn_QuenMatKhau
            // 
            btn_QuenMatKhau.Enabled = false;
            btn_QuenMatKhau.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_QuenMatKhau.ForeColor = Color.Gray;
            btn_QuenMatKhau.Location = new Point(79, 309);
            btn_QuenMatKhau.Name = "btn_QuenMatKhau";
            btn_QuenMatKhau.Size = new Size(125, 34);
            btn_QuenMatKhau.TabIndex = 8;
            btn_QuenMatKhau.Text = "Quên mật khẩu";
            btn_QuenMatKhau.UseVisualStyleBackColor = true;
            btn_QuenMatKhau.Click += btn_QuenMatKhau_Click;
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.BackColor = Color.Red;
            btn_DangNhap.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_DangNhap.ForeColor = Color.White;
            btn_DangNhap.Location = new Point(253, 309);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(98, 34);
            btn_DangNhap.TabIndex = 7;
            btn_DangNhap.Text = "Đăng nhập";
            btn_DangNhap.UseVisualStyleBackColor = false;
            btn_DangNhap.Click += btn_DangNhap_Click;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Location = new Point(76, 245);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new Size(242, 23);
            txt_MatKhau.TabIndex = 6;
            // 
            // txt_TenDangNhap
            // 
            txt_TenDangNhap.Location = new Point(76, 158);
            txt_TenDangNhap.Name = "txt_TenDangNhap";
            txt_TenDangNhap.Size = new Size(275, 23);
            txt_TenDangNhap.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(185, 271);
            label4.Name = "label4";
            label4.Size = new Size(166, 15);
            label4.TabIndex = 4;
            label4.Text = "* Mật khẩu chứa ít nhất 5 kí tự";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(171, 184);
            label3.Name = "label3";
            label3.Size = new Size(180, 15);
            label3.TabIndex = 3;
            label3.Text = "* Tên đăng nhập là Mã nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(76, 227);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(76, 140);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng nhập:";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Red;
            pictureBox2.Image = Properties.Resources.logo_acecook;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(420, 88);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.lichsuhinhthanh;
            pictureBox1.Location = new Point(419, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(554, 399);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FORM_DangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(973, 399);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FORM_DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ĐĂNG NHẬP HỆ THỐNG ACECOOK";
            Load += FORM_DangNhap_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_AnHienMatKhau).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Button btn_QuenMatKhau;
        private Button btn_DangNhap;
        private TextBox txt_MatKhau;
        private TextBox txt_TenDangNhap;
        private Label label4;
        private PictureBox pictureBox_AnHienMatKhau;
    }
}