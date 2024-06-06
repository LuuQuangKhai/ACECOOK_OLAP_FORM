namespace GUI
{
    partial class US_SaoLuu
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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            cbo_ChonDuLieu = new ComboBox();
            txt_DuongDan = new TextBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            txt_TenFile = new TextBox();
            btn_SaoLuu = new Button();
            pictureBox_ChonDuongDan = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_ChonDuongDan).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1225, 88);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(341, 18);
            label1.Name = "label1";
            label1.Size = new Size(558, 47);
            label1.TabIndex = 0;
            label1.Text = "SAO LƯU DỮ LIỆU KINH DOANH";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.saoluu;
            pictureBox1.Location = new Point(508, 172);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(382, 384);
            label2.Name = "label2";
            label2.Size = new Size(167, 32);
            label2.TabIndex = 3;
            label2.Text = "Chọn dữ liệu:";
            // 
            // cbo_ChonDuLieu
            // 
            cbo_ChonDuLieu.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbo_ChonDuLieu.FormattingEnabled = true;
            cbo_ChonDuLieu.Items.AddRange(new object[] { "Tất cả dữ liệu hệ thống", "FORM", "WEB", "NDS", "DDS" });
            cbo_ChonDuLieu.Location = new Point(555, 383);
            cbo_ChonDuLieu.Name = "cbo_ChonDuLieu";
            cbo_ChonDuLieu.Size = new Size(246, 33);
            cbo_ChonDuLieu.TabIndex = 4;
            // 
            // txt_DuongDan
            // 
            txt_DuongDan.Enabled = false;
            txt_DuongDan.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_DuongDan.Location = new Point(26, 35);
            txt_DuongDan.Name = "txt_DuongDan";
            txt_DuongDan.Size = new Size(471, 33);
            txt_DuongDan.TabIndex = 5;
            txt_DuongDan.TextChanged += txt_DuongDan_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_TenFile);
            groupBox1.Controls.Add(btn_SaoLuu);
            groupBox1.Controls.Add(pictureBox_ChonDuongDan);
            groupBox1.Controls.Add(txt_DuongDan);
            groupBox1.Location = new Point(318, 436);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(584, 150);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn đường dẫn sao lưu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 94);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 9;
            label3.Text = "Tên file:";
            // 
            // txt_TenFile
            // 
            txt_TenFile.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_TenFile.Location = new Point(128, 91);
            txt_TenFile.Name = "txt_TenFile";
            txt_TenFile.Size = new Size(274, 33);
            txt_TenFile.TabIndex = 8;
            // 
            // btn_SaoLuu
            // 
            btn_SaoLuu.BackColor = Color.LightCoral;
            btn_SaoLuu.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_SaoLuu.ForeColor = Color.White;
            btn_SaoLuu.Location = new Point(437, 84);
            btn_SaoLuu.Name = "btn_SaoLuu";
            btn_SaoLuu.Size = new Size(120, 45);
            btn_SaoLuu.TabIndex = 7;
            btn_SaoLuu.Text = "Sao lưu";
            btn_SaoLuu.UseVisualStyleBackColor = false;
            btn_SaoLuu.Click += btn_SaoLuu_Click;
            // 
            // pictureBox_ChonDuongDan
            // 
            pictureBox_ChonDuongDan.Image = Properties.Resources.folder;
            pictureBox_ChonDuongDan.Location = new Point(524, 35);
            pictureBox_ChonDuongDan.Name = "pictureBox_ChonDuongDan";
            pictureBox_ChonDuongDan.Size = new Size(33, 33);
            pictureBox_ChonDuongDan.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_ChonDuongDan.TabIndex = 6;
            pictureBox_ChonDuongDan.TabStop = false;
            pictureBox_ChonDuongDan.Click += pictureBox_ChonDuongDan_Click;
            // 
            // US_SaoLuu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(cbo_ChonDuLieu);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "US_SaoLuu";
            Size = new Size(1231, 700);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_ChonDuongDan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private ComboBox cbo_ChonDuLieu;
        private TextBox txt_DuongDan;
        private GroupBox groupBox1;
        private PictureBox pictureBox_ChonDuongDan;
        private Button btn_SaoLuu;
        private Label label3;
        private TextBox txt_TenFile;
    }
}
