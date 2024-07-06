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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            dataGridView_DuLieuDaPhanTich = new DataGridView();
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
            ckb_LocTheoKhuVuc = new CheckBox();
            cbo_ChiNhanh = new ComboBox();
            cbo_KhuVuc = new ComboBox();
            groupBox4 = new GroupBox();
            ckb_LocTheoNam = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            dateTimePicker_DenNam = new DateTimePicker();
            dateTimePicker_TuNam = new DateTimePicker();
            btn_XuatWord = new Button();
            btn_XuatExcel = new Button();
            groupBox5 = new GroupBox();
            rdo_Tuoi = new RadioButton();
            rdo_LoaiKhachHang = new RadioButton();
            groupBox6 = new GroupBox();
            rdo_SanPham = new RadioButton();
            btn_LamMoiChucNang = new Button();
            lbl_ChieuKhuVuc = new Label();
            lbl_ChieuChiNhanh = new Label();
            lbl_ChieuDuLieu = new Label();
            lbl_ChieuKhachHang = new Label();
            lbl_ChieuSanPham = new Label();
            lbl_ChieuThoiGian = new Label();
            lbl_TuNam = new Label();
            lbl_DenNam = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DuLieuDaPhanTich).BeginInit();
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
            // dataGridView_DuLieuDaPhanTich
            // 
            dataGridView_DuLieuDaPhanTich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_DuLieuDaPhanTich.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_DuLieuDaPhanTich.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_DuLieuDaPhanTich.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_DuLieuDaPhanTich.Location = new Point(3, 336);
            dataGridView_DuLieuDaPhanTich.Name = "dataGridView_DuLieuDaPhanTich";
            dataGridView_DuLieuDaPhanTich.Size = new Size(1226, 361);
            dataGridView_DuLieuDaPhanTich.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdo_ChiPhiVanChuyen);
            groupBox1.Controls.Add(rdo_SoLuongBan);
            groupBox1.Controls.Add(rdo_LoiNhuan);
            groupBox1.Controls.Add(rdo_DoanhThu);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(353, 104);
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
            groupBox2.Location = new Point(353, 226);
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
            btn_PhanTich.Location = new Point(720, 167);
            btn_PhanTich.Name = "btn_PhanTich";
            btn_PhanTich.Size = new Size(174, 53);
            btn_PhanTich.TabIndex = 4;
            btn_PhanTich.Text = "Phân tích";
            btn_PhanTich.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_PhanTich.UseVisualStyleBackColor = false;
            btn_PhanTich.Click += btn_PhanTich_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ckb_LocTheoKhuVuc);
            groupBox3.Controls.Add(cbo_ChiNhanh);
            groupBox3.Controls.Add(cbo_KhuVuc);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(148, 104);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(199, 116);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lựa chọn theo:";
            groupBox3.Visible = false;
            // 
            // ckb_LocTheoKhuVuc
            // 
            ckb_LocTheoKhuVuc.AutoSize = true;
            ckb_LocTheoKhuVuc.Font = new Font("Segoe UI", 9F);
            ckb_LocTheoKhuVuc.Location = new Point(9, 22);
            ckb_LocTheoKhuVuc.Name = "ckb_LocTheoKhuVuc";
            ckb_LocTheoKhuVuc.Size = new Size(188, 19);
            ckb_LocTheoKhuVuc.TabIndex = 20;
            ckb_LocTheoKhuVuc.Text = "Lọc theo khu vực và chi nhánh";
            ckb_LocTheoKhuVuc.UseVisualStyleBackColor = true;
            ckb_LocTheoKhuVuc.CheckedChanged += cbo_LocTheoKhuVuc_CheckedChanged;
            // 
            // cbo_ChiNhanh
            // 
            cbo_ChiNhanh.ForeColor = Color.Gray;
            cbo_ChiNhanh.FormattingEnabled = true;
            cbo_ChiNhanh.Location = new Point(9, 82);
            cbo_ChiNhanh.Name = "cbo_ChiNhanh";
            cbo_ChiNhanh.Size = new Size(184, 23);
            cbo_ChiNhanh.TabIndex = 1;
            cbo_ChiNhanh.Text = "Chi nhánh ...";
            cbo_ChiNhanh.SelectedIndexChanged += cbo_ChiNhanh_SelectedIndexChanged_1;
            cbo_ChiNhanh.MouseClick += cbo_ChiNhanh_MouseClick;
            // 
            // cbo_KhuVuc
            // 
            cbo_KhuVuc.ForeColor = Color.Gray;
            cbo_KhuVuc.FormattingEnabled = true;
            cbo_KhuVuc.Items.AddRange(new object[] { "1", "2", "3" });
            cbo_KhuVuc.Location = new Point(9, 53);
            cbo_KhuVuc.Name = "cbo_KhuVuc";
            cbo_KhuVuc.Size = new Size(184, 23);
            cbo_KhuVuc.TabIndex = 0;
            cbo_KhuVuc.Text = "Khu vực ...";
            cbo_KhuVuc.SelectedIndexChanged += cbo_KhuVuc_SelectedIndexChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(ckb_LocTheoNam);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(dateTimePicker_DenNam);
            groupBox4.Controls.Add(dateTimePicker_TuNam);
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(148, 226);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(199, 101);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thời gian";
            groupBox4.Visible = false;
            // 
            // ckb_LocTheoNam
            // 
            ckb_LocTheoNam.AutoSize = true;
            ckb_LocTheoNam.Font = new Font("Segoe UI", 9F);
            ckb_LocTheoNam.Location = new Point(9, 20);
            ckb_LocTheoNam.Name = "ckb_LocTheoNam";
            ckb_LocTheoNam.Size = new Size(99, 19);
            ckb_LocTheoNam.TabIndex = 20;
            ckb_LocTheoNam.Text = "Lọc theo năm";
            ckb_LocTheoNam.UseVisualStyleBackColor = true;
            ckb_LocTheoNam.CheckedChanged += cbo_LocTheoNam_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(6, 75);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 3;
            label3.Text = "Đến năm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(6, 46);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "Từ năm";
            // 
            // dateTimePicker_DenNam
            // 
            dateTimePicker_DenNam.CustomFormat = "yyyy";
            dateTimePicker_DenNam.Font = new Font("Segoe UI", 9F);
            dateTimePicker_DenNam.Format = DateTimePickerFormat.Custom;
            dateTimePicker_DenNam.Location = new Point(84, 69);
            dateTimePicker_DenNam.Name = "dateTimePicker_DenNam";
            dateTimePicker_DenNam.Size = new Size(106, 23);
            dateTimePicker_DenNam.TabIndex = 1;
            dateTimePicker_DenNam.ValueChanged += dateTimePicker_DenNgay_ValueChanged;
            // 
            // dateTimePicker_TuNam
            // 
            dateTimePicker_TuNam.CustomFormat = "yyyy";
            dateTimePicker_TuNam.Font = new Font("Segoe UI", 9F);
            dateTimePicker_TuNam.Format = DateTimePickerFormat.Custom;
            dateTimePicker_TuNam.Location = new Point(84, 42);
            dateTimePicker_TuNam.Name = "dateTimePicker_TuNam";
            dateTimePicker_TuNam.Size = new Size(106, 23);
            dateTimePicker_TuNam.TabIndex = 0;
            dateTimePicker_TuNam.ValueChanged += dateTimePicker_TuNgay_ValueChanged;
            // 
            // btn_XuatWord
            // 
            btn_XuatWord.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn_XuatWord.ImageAlign = ContentAlignment.MiddleLeft;
            btn_XuatWord.Location = new Point(398, 287);
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
            btn_XuatExcel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn_XuatExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btn_XuatExcel.Location = new Point(559, 287);
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
            groupBox5.Controls.Add(rdo_Tuoi);
            groupBox5.Controls.Add(rdo_LoaiKhachHang);
            groupBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.Location = new Point(353, 165);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(244, 55);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chiều khách hàng";
            // 
            // rdo_Tuoi
            // 
            rdo_Tuoi.AutoSize = true;
            rdo_Tuoi.Font = new Font("Segoe UI", 9F);
            rdo_Tuoi.Location = new Point(133, 20);
            rdo_Tuoi.Name = "rdo_Tuoi";
            rdo_Tuoi.Size = new Size(48, 19);
            rdo_Tuoi.TabIndex = 2;
            rdo_Tuoi.TabStop = true;
            rdo_Tuoi.Text = "Tuổi";
            rdo_Tuoi.UseVisualStyleBackColor = true;
            rdo_Tuoi.CheckedChanged += rdo_GioiTinh_CheckedChanged;
            // 
            // rdo_LoaiKhachHang
            // 
            rdo_LoaiKhachHang.AutoSize = true;
            rdo_LoaiKhachHang.Font = new Font("Segoe UI", 9F);
            rdo_LoaiKhachHang.Location = new Point(6, 22);
            rdo_LoaiKhachHang.Name = "rdo_LoaiKhachHang";
            rdo_LoaiKhachHang.Size = new Size(112, 19);
            rdo_LoaiKhachHang.TabIndex = 0;
            rdo_LoaiKhachHang.TabStop = true;
            rdo_LoaiKhachHang.Text = "Loại khách hàng";
            rdo_LoaiKhachHang.UseVisualStyleBackColor = true;
            rdo_LoaiKhachHang.CheckedChanged += rdo_LoaiKhachHang_CheckedChanged;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(rdo_SanPham);
            groupBox6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox6.Location = new Point(603, 165);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(111, 55);
            groupBox6.TabIndex = 10;
            groupBox6.TabStop = false;
            groupBox6.Text = "Chiều sản phẩm";
            // 
            // rdo_SanPham
            // 
            rdo_SanPham.AutoSize = true;
            rdo_SanPham.Font = new Font("Segoe UI", 9F);
            rdo_SanPham.Location = new Point(6, 22);
            rdo_SanPham.Name = "rdo_SanPham";
            rdo_SanPham.Size = new Size(78, 19);
            rdo_SanPham.TabIndex = 0;
            rdo_SanPham.TabStop = true;
            rdo_SanPham.Text = "Sản phẩm";
            rdo_SanPham.UseVisualStyleBackColor = true;
            rdo_SanPham.CheckedChanged += rdo_SanPham_CheckedChanged;
            // 
            // btn_LamMoiChucNang
            // 
            btn_LamMoiChucNang.BackColor = Color.Silver;
            btn_LamMoiChucNang.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_LamMoiChucNang.ForeColor = Color.White;
            btn_LamMoiChucNang.Location = new Point(720, 229);
            btn_LamMoiChucNang.Name = "btn_LamMoiChucNang";
            btn_LamMoiChucNang.Size = new Size(174, 52);
            btn_LamMoiChucNang.TabIndex = 11;
            btn_LamMoiChucNang.Text = "Làm mới chức năng";
            btn_LamMoiChucNang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_LamMoiChucNang.UseVisualStyleBackColor = false;
            btn_LamMoiChucNang.Click += btn_LamMoiChucNang_Click;
            // 
            // lbl_ChieuKhuVuc
            // 
            lbl_ChieuKhuVuc.AutoSize = true;
            lbl_ChieuKhuVuc.Location = new Point(1102, 115);
            lbl_ChieuKhuVuc.Name = "lbl_ChieuKhuVuc";
            lbl_ChieuKhuVuc.Size = new Size(27, 15);
            lbl_ChieuKhuVuc.TabIndex = 12;
            lbl_ChieuKhuVuc.Text = "null";
            lbl_ChieuKhuVuc.Visible = false;
            // 
            // lbl_ChieuChiNhanh
            // 
            lbl_ChieuChiNhanh.AutoSize = true;
            lbl_ChieuChiNhanh.Location = new Point(1102, 150);
            lbl_ChieuChiNhanh.Name = "lbl_ChieuChiNhanh";
            lbl_ChieuChiNhanh.Size = new Size(27, 15);
            lbl_ChieuChiNhanh.TabIndex = 13;
            lbl_ChieuChiNhanh.Text = "null";
            lbl_ChieuChiNhanh.Visible = false;
            // 
            // lbl_ChieuDuLieu
            // 
            lbl_ChieuDuLieu.AutoSize = true;
            lbl_ChieuDuLieu.Location = new Point(1102, 185);
            lbl_ChieuDuLieu.Name = "lbl_ChieuDuLieu";
            lbl_ChieuDuLieu.Size = new Size(27, 15);
            lbl_ChieuDuLieu.TabIndex = 14;
            lbl_ChieuDuLieu.Text = "null";
            lbl_ChieuDuLieu.Visible = false;
            // 
            // lbl_ChieuKhachHang
            // 
            lbl_ChieuKhachHang.AutoSize = true;
            lbl_ChieuKhachHang.Location = new Point(1102, 220);
            lbl_ChieuKhachHang.Name = "lbl_ChieuKhachHang";
            lbl_ChieuKhachHang.Size = new Size(27, 15);
            lbl_ChieuKhachHang.TabIndex = 15;
            lbl_ChieuKhachHang.Text = "null";
            lbl_ChieuKhachHang.Visible = false;
            // 
            // lbl_ChieuSanPham
            // 
            lbl_ChieuSanPham.AutoSize = true;
            lbl_ChieuSanPham.Location = new Point(1102, 255);
            lbl_ChieuSanPham.Name = "lbl_ChieuSanPham";
            lbl_ChieuSanPham.Size = new Size(27, 15);
            lbl_ChieuSanPham.TabIndex = 16;
            lbl_ChieuSanPham.Text = "null";
            lbl_ChieuSanPham.Visible = false;
            // 
            // lbl_ChieuThoiGian
            // 
            lbl_ChieuThoiGian.AutoSize = true;
            lbl_ChieuThoiGian.Location = new Point(1102, 290);
            lbl_ChieuThoiGian.Name = "lbl_ChieuThoiGian";
            lbl_ChieuThoiGian.Size = new Size(27, 15);
            lbl_ChieuThoiGian.TabIndex = 17;
            lbl_ChieuThoiGian.Text = "null";
            lbl_ChieuThoiGian.Visible = false;
            // 
            // lbl_TuNam
            // 
            lbl_TuNam.AutoSize = true;
            lbl_TuNam.Location = new Point(1183, 266);
            lbl_TuNam.Name = "lbl_TuNam";
            lbl_TuNam.Size = new Size(27, 15);
            lbl_TuNam.TabIndex = 18;
            lbl_TuNam.Text = "null";
            lbl_TuNam.Visible = false;
            // 
            // lbl_DenNam
            // 
            lbl_DenNam.AutoSize = true;
            lbl_DenNam.Location = new Point(1183, 288);
            lbl_DenNam.Name = "lbl_DenNam";
            lbl_DenNam.Size = new Size(27, 15);
            lbl_DenNam.TabIndex = 19;
            lbl_DenNam.Text = "null";
            lbl_DenNam.Visible = false;
            // 
            // US_PhanTich
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl_DenNam);
            Controls.Add(lbl_TuNam);
            Controls.Add(lbl_ChieuThoiGian);
            Controls.Add(lbl_ChieuSanPham);
            Controls.Add(lbl_ChieuKhachHang);
            Controls.Add(lbl_ChieuDuLieu);
            Controls.Add(lbl_ChieuChiNhanh);
            Controls.Add(lbl_ChieuKhuVuc);
            Controls.Add(btn_LamMoiChucNang);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(btn_XuatExcel);
            Controls.Add(dataGridView_DuLieuDaPhanTich);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView_DuLieuDaPhanTich).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private DataGridView dataGridView_DuLieuDaPhanTich;
        private GroupBox groupBox3;
        private ComboBox cbo_KhuVuc;
        private ComboBox cbo_ChiNhanh;
        private GroupBox groupBox4;
        private DateTimePicker dateTimePicker_DenNam;
        private DateTimePicker dateTimePicker_TuNam;
        private Button btn_XuatWord;
        private Button btn_XuatExcel;
        private Label label3;
        private Label label2;
        private GroupBox groupBox5;
        private RadioButton rdo_Tuoi;
        private RadioButton rdo_LoaiKhachHang;
        private GroupBox groupBox6;
        private RadioButton rdo_SanPham;
        private Button btn_LamMoiChucNang;
        private Label lbl_ChieuKhuVuc;
        private Label lbl_ChieuChiNhanh;
        private Label lbl_ChieuDuLieu;
        private Label lbl_ChieuKhachHang;
        private Label lbl_ChieuSanPham;
        private Label lbl_ChieuThoiGian;
        private Label lbl_TuNam;
        private Label lbl_DenNam;
        private CheckBox ckb_LocTheoKhuVuc;
        private CheckBox ckb_LocTheoNam;
    }
}
