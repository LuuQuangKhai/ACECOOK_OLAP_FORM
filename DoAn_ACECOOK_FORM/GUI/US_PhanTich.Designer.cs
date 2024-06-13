namespace GUI
{
    partial class US_PhanTich
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            rdo_ChiPhiVanChuyen = new RadioButton();
            rdo_SoLuongBan = new RadioButton();
            rdo_LoiNhuan = new RadioButton();
            rdo_DoanhThu = new RadioButton();
            groupBox2 = new GroupBox();
            rdo_Quy = new RadioButton();
            rdo_Nam = new RadioButton();
            rdo_Thang = new RadioButton();
            btn_PhanTich = new Button();
            groupBox3 = new GroupBox();
            cbo_ChiNhanh = new ComboBox();
            cbo_KhuVuc = new ComboBox();
            groupBox4 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            dateTimePicker_DenNgay = new DateTimePicker();
            dateTimePicker_TuNgay = new DateTimePicker();
            btn_XuatWord = new Button();
            btn_XuatExcel = new Button();
            groupBox5 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox6 = new GroupBox();
            radioButton4 = new RadioButton();
            btn_LamMoiChucNang = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1226, 88);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(318, 16);
            label1.Name = "label1";
            label1.Size = new Size(600, 47);
            label1.TabIndex = 0;
            label1.Text = "PHÂN TÍCH DỮ LIỆU KINH DOANH";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 336);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1226, 361);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdo_ChiPhiVanChuyen);
            groupBox1.Controls.Add(rdo_SoLuongBan);
            groupBox1.Controls.Add(rdo_LoiNhuan);
            groupBox1.Controls.Add(rdo_DoanhThu);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(442, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(541, 55);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chiều dữ liệu";
            // 
            // rdo_ChiPhiVanChuyen
            // 
            rdo_ChiPhiVanChuyen.AutoSize = true;
            rdo_ChiPhiVanChuyen.Font = new Font("Segoe UI", 9F);
            rdo_ChiPhiVanChuyen.Location = new Point(398, 22);
            rdo_ChiPhiVanChuyen.Name = "rdo_ChiPhiVanChuyen";
            rdo_ChiPhiVanChuyen.Size = new Size(127, 19);
            rdo_ChiPhiVanChuyen.TabIndex = 3;
            rdo_ChiPhiVanChuyen.TabStop = true;
            rdo_ChiPhiVanChuyen.Text = "Chi phí vận chuyển";
            rdo_ChiPhiVanChuyen.UseVisualStyleBackColor = true;
            rdo_ChiPhiVanChuyen.CheckedChanged += rdo_ChiPhiVanChuyen_CheckedChanged;
            // 
            // rdo_SoLuongBan
            // 
            rdo_SoLuongBan.AutoSize = true;
            rdo_SoLuongBan.Font = new Font("Segoe UI", 9F);
            rdo_SoLuongBan.Location = new Point(256, 22);
            rdo_SoLuongBan.Name = "rdo_SoLuongBan";
            rdo_SoLuongBan.Size = new Size(95, 19);
            rdo_SoLuongBan.TabIndex = 2;
            rdo_SoLuongBan.TabStop = true;
            rdo_SoLuongBan.Text = "Số lượng bán";
            rdo_SoLuongBan.UseVisualStyleBackColor = true;
            rdo_SoLuongBan.CheckedChanged += rdo_SoLuongBan_CheckedChanged;
            // 
            // rdo_LoiNhuan
            // 
            rdo_LoiNhuan.AutoSize = true;
            rdo_LoiNhuan.Font = new Font("Segoe UI", 9F);
            rdo_LoiNhuan.Location = new Point(133, 22);
            rdo_LoiNhuan.Name = "rdo_LoiNhuan";
            rdo_LoiNhuan.Size = new Size(78, 19);
            rdo_LoiNhuan.TabIndex = 1;
            rdo_LoiNhuan.TabStop = true;
            rdo_LoiNhuan.Text = "Lợi nhuận";
            rdo_LoiNhuan.UseVisualStyleBackColor = true;
            rdo_LoiNhuan.CheckedChanged += rdo_LoiNhuan_CheckedChanged;
            // 
            // rdo_DoanhThu
            // 
            rdo_DoanhThu.AutoSize = true;
            rdo_DoanhThu.Font = new Font("Segoe UI", 9F);
            rdo_DoanhThu.Location = new Point(6, 22);
            rdo_DoanhThu.Name = "rdo_DoanhThu";
            rdo_DoanhThu.Size = new Size(81, 19);
            rdo_DoanhThu.TabIndex = 0;
            rdo_DoanhThu.TabStop = true;
            rdo_DoanhThu.Text = "Doanh thu";
            rdo_DoanhThu.UseVisualStyleBackColor = true;
            rdo_DoanhThu.CheckedChanged += rdo_DoanhThu_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdo_Quy);
            groupBox2.Controls.Add(rdo_Nam);
            groupBox2.Controls.Add(rdo_Thang);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(442, 226);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(361, 55);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thời gian";
            // 
            // rdo_Quy
            // 
            rdo_Quy.AutoSize = true;
            rdo_Quy.Font = new Font("Segoe UI", 9F);
            rdo_Quy.Location = new Point(133, 20);
            rdo_Quy.Name = "rdo_Quy";
            rdo_Quy.Size = new Size(47, 19);
            rdo_Quy.TabIndex = 2;
            rdo_Quy.TabStop = true;
            rdo_Quy.Text = "Quý";
            rdo_Quy.UseVisualStyleBackColor = true;
            rdo_Quy.CheckedChanged += rdo_Quy_CheckedChanged;
            // 
            // rdo_Nam
            // 
            rdo_Nam.AutoSize = true;
            rdo_Nam.Font = new Font("Segoe UI", 9F);
            rdo_Nam.Location = new Point(256, 20);
            rdo_Nam.Name = "rdo_Nam";
            rdo_Nam.Size = new Size(51, 19);
            rdo_Nam.TabIndex = 1;
            rdo_Nam.TabStop = true;
            rdo_Nam.Text = "Năm";
            rdo_Nam.UseVisualStyleBackColor = true;
            rdo_Nam.CheckedChanged += rdo_Nam_CheckedChanged;
            // 
            // rdo_Thang
            // 
            rdo_Thang.AutoSize = true;
            rdo_Thang.Font = new Font("Segoe UI", 9F);
            rdo_Thang.Location = new Point(6, 22);
            rdo_Thang.Name = "rdo_Thang";
            rdo_Thang.Size = new Size(58, 19);
            rdo_Thang.TabIndex = 0;
            rdo_Thang.TabStop = true;
            rdo_Thang.Text = "Tháng";
            rdo_Thang.UseVisualStyleBackColor = true;
            rdo_Thang.CheckedChanged += rdo_Thang_CheckedChanged;
            // 
            // btn_PhanTich
            // 
            btn_PhanTich.BackColor = Color.IndianRed;
            btn_PhanTich.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_PhanTich.ForeColor = Color.White;
            btn_PhanTich.Location = new Point(809, 167);
            btn_PhanTich.Name = "btn_PhanTich";
            btn_PhanTich.Size = new Size(174, 54);
            btn_PhanTich.TabIndex = 4;
            btn_PhanTich.Text = "Phân tích";
            btn_PhanTich.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_PhanTich.UseVisualStyleBackColor = false;
            btn_PhanTich.Click += btn_PhanTich_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbo_ChiNhanh);
            groupBox3.Controls.Add(cbo_KhuVuc);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(237, 104);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(199, 82);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lựa chọn theo:";
            // 
            // cbo_ChiNhanh
            // 
            cbo_ChiNhanh.ForeColor = Color.Gray;
            cbo_ChiNhanh.FormattingEnabled = true;
            cbo_ChiNhanh.Location = new Point(6, 50);
            cbo_ChiNhanh.Name = "cbo_ChiNhanh";
            cbo_ChiNhanh.Size = new Size(184, 23);
            cbo_ChiNhanh.TabIndex = 1;
            cbo_ChiNhanh.Text = "Chi nhánh ...";
            cbo_ChiNhanh.MouseClick += cbo_ChiNhanh_MouseClick;
            // 
            // cbo_KhuVuc
            // 
            cbo_KhuVuc.ForeColor = Color.Gray;
            cbo_KhuVuc.FormattingEnabled = true;
            cbo_KhuVuc.Items.AddRange(new object[] { "1", "2", "3" });
            cbo_KhuVuc.Location = new Point(6, 21);
            cbo_KhuVuc.Name = "cbo_KhuVuc";
            cbo_KhuVuc.Size = new Size(184, 23);
            cbo_KhuVuc.TabIndex = 0;
            cbo_KhuVuc.Text = "Khu vực ...";
            cbo_KhuVuc.SelectedIndexChanged += cbo_KhuVuc_SelectedIndexChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(dateTimePicker_DenNgay);
            groupBox4.Controls.Add(dateTimePicker_TuNgay);
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(237, 199);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(199, 82);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thời gian";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(6, 57);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Đến ngày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(6, 28);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "Từ ngày";
            // 
            // dateTimePicker_DenNgay
            // 
            dateTimePicker_DenNgay.CustomFormat = "dd/MM/yyyy";
            dateTimePicker_DenNgay.Font = new Font("Segoe UI", 9F);
            dateTimePicker_DenNgay.Format = DateTimePickerFormat.Custom;
            dateTimePicker_DenNgay.Location = new Point(84, 49);
            dateTimePicker_DenNgay.Name = "dateTimePicker_DenNgay";
            dateTimePicker_DenNgay.Size = new Size(106, 23);
            dateTimePicker_DenNgay.TabIndex = 1;
            // 
            // dateTimePicker_TuNgay
            // 
            dateTimePicker_TuNgay.CustomFormat = "dd/MM/yyyy";
            dateTimePicker_TuNgay.Font = new Font("Segoe UI", 9F);
            dateTimePicker_TuNgay.Format = DateTimePickerFormat.Custom;
            dateTimePicker_TuNgay.Location = new Point(84, 22);
            dateTimePicker_TuNgay.Name = "dateTimePicker_TuNgay";
            dateTimePicker_TuNgay.Size = new Size(106, 23);
            dateTimePicker_TuNgay.TabIndex = 0;
            // 
            // btn_XuatWord
            // 
            btn_XuatWord.Enabled = false;
            btn_XuatWord.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn_XuatWord.ImageAlign = ContentAlignment.MiddleLeft;
            btn_XuatWord.Location = new Point(487, 287);
            btn_XuatWord.Name = "btn_XuatWord";
            btn_XuatWord.Size = new Size(155, 40);
            btn_XuatWord.TabIndex = 7;
            btn_XuatWord.Text = "Xuất file Word";
            btn_XuatWord.TextAlign = ContentAlignment.MiddleRight;
            btn_XuatWord.UseVisualStyleBackColor = true;
            btn_XuatWord.Click += btn_XuatWord_Click;
            // 
            // btn_XuatExcel
            // 
            btn_XuatExcel.Enabled = false;
            btn_XuatExcel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn_XuatExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btn_XuatExcel.Location = new Point(648, 287);
            btn_XuatExcel.Name = "btn_XuatExcel";
            btn_XuatExcel.Size = new Size(155, 40);
            btn_XuatExcel.TabIndex = 8;
            btn_XuatExcel.Text = "Xuất file Excel";
            btn_XuatExcel.TextAlign = ContentAlignment.MiddleRight;
            btn_XuatExcel.UseVisualStyleBackColor = true;
            btn_XuatExcel.Click += btn_XuatExcel_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(radioButton1);
            groupBox5.Controls.Add(radioButton3);
            groupBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.Location = new Point(442, 165);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(244, 55);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chiều khách hàng";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 9F);
            radioButton1.Location = new Point(133, 20);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(70, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Giới tính";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 9F);
            radioButton3.Location = new Point(6, 22);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(112, 19);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "Loại khách hàng";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(radioButton4);
            groupBox6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox6.Location = new Point(692, 165);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(111, 55);
            groupBox6.TabIndex = 10;
            groupBox6.TabStop = false;
            groupBox6.Text = "Chiều sản phẩm";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI", 9F);
            radioButton4.Location = new Point(6, 22);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(78, 19);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "Sản phẩm";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // btn_LamMoiChucNang
            // 
            btn_LamMoiChucNang.BackColor = Color.Silver;
            btn_LamMoiChucNang.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_LamMoiChucNang.ForeColor = Color.White;
            btn_LamMoiChucNang.Location = new Point(809, 229);
            btn_LamMoiChucNang.Name = "btn_LamMoiChucNang";
            btn_LamMoiChucNang.Size = new Size(174, 54);
            btn_LamMoiChucNang.TabIndex = 11;
            btn_LamMoiChucNang.Text = "Làm mới chức năng";
            btn_LamMoiChucNang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_LamMoiChucNang.UseVisualStyleBackColor = false;
            btn_LamMoiChucNang.Click += btn_LamMoiChucNang_Click;
            // 
            // US_PhanTich
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_LamMoiChucNang);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(btn_XuatExcel);
            Controls.Add(dataGridView1);
            Controls.Add(btn_XuatWord);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(btn_PhanTich);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "US_PhanTich";
            Size = new Size(1232, 700);
            Load += US_PhanTich_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton rdo_Quy;
        private RadioButton rdo_Nam;
        private RadioButton rdo_Thang;
        private RadioButton rdo_ChiPhiVanChuyen;
        private RadioButton rdo_SoLuongBan;
        private RadioButton rdo_LoiNhuan;
        private RadioButton rdo_DoanhThu;
        private Button btn_PhanTich;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private ComboBox cbo_KhuVuc;
        private ComboBox cbo_ChiNhanh;
        private GroupBox groupBox4;
        private DateTimePicker dateTimePicker_DenNgay;
        private DateTimePicker dateTimePicker_TuNgay;
        private Button btn_XuatWord;
        private Button btn_XuatExcel;
        private Label label3;
        private Label label2;
        private GroupBox groupBox5;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private GroupBox groupBox6;
        private RadioButton radioButton4;
        private Button btn_LamMoiChucNang;
    }
}
