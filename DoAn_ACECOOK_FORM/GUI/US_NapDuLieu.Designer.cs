namespace GUI
{
    partial class US_NapDuLieu
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ckb_Excel = new CheckBox();
            ckb_Website = new CheckBox();
            ckb_HeThong = new CheckBox();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            lbl_TenBang = new Label();
            listBox1 = new ListBox();
            dataGridView1 = new DataGridView();
            btn_LamSach = new Button();
            btn_Nap = new Button();
            btn_NapLai = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1226, 88);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(388, 14);
            label1.Name = "label1";
            label1.Size = new Size(482, 47);
            label1.TabIndex = 0;
            label1.Text = "NẠP DỮ LIỆU KINH DOANH";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(ckb_Excel);
            groupBox1.Controls.Add(ckb_Website);
            groupBox1.Controls.Add(ckb_HeThong);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1226, 193);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hình thức nạp";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.office365;
            pictureBox4.Location = new Point(739, 32);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 100);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.world_wide_web;
            pictureBox2.Location = new Point(567, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.database_storage;
            pictureBox1.Location = new Point(395, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // ckb_Excel
            // 
            ckb_Excel.AutoSize = true;
            ckb_Excel.Location = new Point(764, 151);
            ckb_Excel.Name = "ckb_Excel";
            ckb_Excel.Size = new Size(55, 19);
            ckb_Excel.TabIndex = 3;
            ckb_Excel.Text = "Excel";
            ckb_Excel.UseVisualStyleBackColor = true;
            ckb_Excel.CheckedChanged += ckb_Excel_CheckedChanged;
            // 
            // ckb_Website
            // 
            ckb_Website.AutoSize = true;
            ckb_Website.Location = new Point(584, 151);
            ckb_Website.Name = "ckb_Website";
            ckb_Website.Size = new Size(72, 19);
            ckb_Website.TabIndex = 1;
            ckb_Website.Text = "Website";
            ckb_Website.UseVisualStyleBackColor = true;
            ckb_Website.CheckedChanged += ckb_Website_CheckedChanged;
            // 
            // ckb_HeThong
            // 
            ckb_HeThong.AutoSize = true;
            ckb_HeThong.Location = new Point(407, 151);
            ckb_HeThong.Name = "ckb_HeThong";
            ckb_HeThong.Size = new Size(78, 19);
            ckb_HeThong.TabIndex = 0;
            ckb_HeThong.Text = "Hệ thống";
            ckb_HeThong.UseVisualStyleBackColor = true;
            ckb_HeThong.CheckedChanged += ckb_HeThong_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(lbl_TenBang);
            groupBox2.Controls.Add(listBox1);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(3, 351);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1226, 346);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kho dữ liệu làm sạch";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.Gray;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kho dữ liệu chuẩn hóa", "Kho dữ liệu đa chiều" });
            comboBox1.Location = new Point(13, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 29);
            comboBox1.TabIndex = 8;
            comboBox1.Text = "Chọn kho dữ liệu";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lbl_TenBang
            // 
            lbl_TenBang.AutoSize = true;
            lbl_TenBang.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_TenBang.ForeColor = Color.Red;
            lbl_TenBang.Location = new Point(249, 22);
            lbl_TenBang.Name = "lbl_TenBang";
            lbl_TenBang.Size = new Size(144, 25);
            lbl_TenBang.TabIndex = 2;
            lbl_TenBang.Text = "Chọn tên bảng";
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Control;
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.ForeColor = Color.CornflowerBlue;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Items.AddRange(new object[] { "Chi Nhánh", "Chi Phí Vận Chuyển", "Chi Tiết Đơn Hàng", "Đơn Hàng", "Giảm Giá", "Khách Hàng", "Khu Vực", "Loại Sản Phẩm", "Nhân Viên", "Nhập Hàng", "Nhà Phân Phối", "Sản Phẩm" });
            listBox1.Location = new Point(13, 63);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(165, 277);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(184, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1036, 277);
            dataGridView1.TabIndex = 0;
            // 
            // btn_LamSach
            // 
            btn_LamSach.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_LamSach.Image = Properties.Resources.broom;
            btn_LamSach.ImageAlign = ContentAlignment.MiddleRight;
            btn_LamSach.Location = new Point(226, 296);
            btn_LamSach.Name = "btn_LamSach";
            btn_LamSach.Size = new Size(191, 49);
            btn_LamSach.TabIndex = 5;
            btn_LamSach.Text = "Làm sạch";
            btn_LamSach.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_LamSach.UseVisualStyleBackColor = true;
            btn_LamSach.Click += btn_LamSach_Click;
            // 
            // btn_Nap
            // 
            btn_Nap.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_Nap.Image = Properties.Resources.upload;
            btn_Nap.ImageAlign = ContentAlignment.MiddleRight;
            btn_Nap.Location = new Point(616, 296);
            btn_Nap.Name = "btn_Nap";
            btn_Nap.Size = new Size(104, 49);
            btn_Nap.TabIndex = 6;
            btn_Nap.Text = "Nạp";
            btn_Nap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Nap.UseVisualStyleBackColor = true;
            btn_Nap.Click += btn_Nap_Click;
            // 
            // btn_NapLai
            // 
            btn_NapLai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_NapLai.Image = Properties.Resources.data_recovery;
            btn_NapLai.ImageAlign = ContentAlignment.MiddleRight;
            btn_NapLai.Location = new Point(726, 296);
            btn_NapLai.Name = "btn_NapLai";
            btn_NapLai.Size = new Size(168, 49);
            btn_NapLai.TabIndex = 7;
            btn_NapLai.Text = "Nạp lại";
            btn_NapLai.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_NapLai.UseVisualStyleBackColor = true;
            btn_NapLai.Click += btn_NapLai_Click;
            // 
            // US_NapDuLieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_NapLai);
            Controls.Add(btn_Nap);
            Controls.Add(btn_LamSach);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "US_NapDuLieu";
            Size = new Size(1232, 700);
            Load += US_NapDuLieu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btn_LamSach;
        private Button btn_Nap;
        private Button btn_NapLai;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private CheckBox ckb_Excel;
        private CheckBox ckb_Website;
        private CheckBox ckb_HeThong;
        private DataGridView dataGridView1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private Label lbl_TenBang;
        private ListBox listBox1;
    }
}
