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
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            radioButton7 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            groupBox2 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
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
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
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
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(3, 347);
            panel2.Name = "panel2";
            panel2.Size = new Size(1226, 350);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1220, 344);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton7);
            groupBox1.Controls.Add(radioButton6);
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(460, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(541, 55);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chiều dữ liệu";
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Font = new Font("Segoe UI", 9F);
            radioButton7.Location = new Point(398, 22);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(127, 19);
            radioButton7.TabIndex = 3;
            radioButton7.TabStop = true;
            radioButton7.Text = "Chi phí vận chuyển";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Font = new Font("Segoe UI", 9F);
            radioButton6.Location = new Point(256, 22);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(95, 19);
            radioButton6.TabIndex = 2;
            radioButton6.TabStop = true;
            radioButton6.Text = "Số lượng bán";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Segoe UI", 9F);
            radioButton5.Location = new Point(133, 22);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(78, 19);
            radioButton5.TabIndex = 1;
            radioButton5.TabStop = true;
            radioButton5.Text = "Lợi nhuận";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI", 9F);
            radioButton4.Location = new Point(6, 22);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(81, 19);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "Doanh thu";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(460, 186);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(392, 55);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thời gian";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 9F);
            radioButton3.Location = new Point(256, 22);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(47, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Quý";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 9F);
            radioButton2.Location = new Point(133, 22);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(51, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Năm";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 9F);
            radioButton1.Location = new Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(58, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Tháng";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btn_PhanTich
            // 
            btn_PhanTich.BackColor = Color.IndianRed;
            btn_PhanTich.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_PhanTich.ForeColor = Color.White;
            btn_PhanTich.Location = new Point(858, 186);
            btn_PhanTich.Name = "btn_PhanTich";
            btn_PhanTich.Size = new Size(143, 55);
            btn_PhanTich.TabIndex = 4;
            btn_PhanTich.Text = "Phân tích";
            btn_PhanTich.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_PhanTich.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbo_ChiNhanh);
            groupBox3.Controls.Add(cbo_KhuVuc);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(255, 125);
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
            cbo_ChiNhanh.Items.AddRange(new object[] { "1", "2", "3" });
            cbo_ChiNhanh.Location = new Point(6, 50);
            cbo_ChiNhanh.Name = "cbo_ChiNhanh";
            cbo_ChiNhanh.Size = new Size(184, 23);
            cbo_ChiNhanh.TabIndex = 1;
            cbo_ChiNhanh.Text = "Chi nhánh ...";
            cbo_ChiNhanh.SelectedIndexChanged += cbo_ChiNhanh_SelectedIndexChanged;
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
            groupBox4.Location = new Point(255, 213);
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
            btn_XuatWord.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn_XuatWord.ImageAlign = ContentAlignment.MiddleLeft;
            btn_XuatWord.Location = new Point(572, 247);
            btn_XuatWord.Name = "btn_XuatWord";
            btn_XuatWord.Size = new Size(155, 40);
            btn_XuatWord.TabIndex = 7;
            btn_XuatWord.Text = "Xuất file Word";
            btn_XuatWord.TextAlign = ContentAlignment.MiddleRight;
            btn_XuatWord.UseVisualStyleBackColor = true;
            // 
            // btn_XuatExcel
            // 
            btn_XuatExcel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn_XuatExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btn_XuatExcel.Location = new Point(752, 247);
            btn_XuatExcel.Name = "btn_XuatExcel";
            btn_XuatExcel.Size = new Size(155, 40);
            btn_XuatExcel.TabIndex = 8;
            btn_XuatExcel.Text = "Xuất file Excel";
            btn_XuatExcel.TextAlign = ContentAlignment.MiddleRight;
            btn_XuatExcel.UseVisualStyleBackColor = true;
            btn_XuatExcel.Click += btn_XuatExcel_Click;
            // 
            // US_PhanTich
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_XuatExcel);
            Controls.Add(btn_XuatWord);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(btn_PhanTich);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "US_PhanTich";
            Size = new Size(1232, 700);
            Load += US_PhanTich_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
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
    }
}
