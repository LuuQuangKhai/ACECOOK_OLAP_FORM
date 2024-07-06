using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class US_SaoLuu : UserControl
    {
        private BUS_SaoLuuDuLieu bus = new BUS_SaoLuuDuLieu();

        public US_SaoLuu()
        {
            InitializeComponent();
        }

        private string XuLySaoLuu()
        {
            string thongBao = "";
            string duongDan = txt_DuongDan.Text;
            string tenFile = txt_TenFile.Text.Trim();

            switch (cbo_ChonDuLieu.SelectedItem.ToString())
            {
                case "Tất cả dữ liệu hệ thống":
                    thongBao = bus.SaoLuuDuLieu(duongDan, "DB_ACECOOK_FORM", tenFile + "_FORM");
                    thongBao = bus.SaoLuuDuLieu(duongDan, "DB_ACECOOK_WEB", tenFile + "_WEB");
                    thongBao = bus.SaoLuuDuLieu(duongDan, "DB_ACECOOK_NDS", tenFile + "_NDS");
                    thongBao = bus.SaoLuuDuLieu(duongDan, "DB_ACECOOK_DDS", tenFile + "_DDS");
                    break;
                case "Cơ sở dữ liệu ứng dụng":
                    thongBao = bus.SaoLuuDuLieu(duongDan, "DB_ACECOOK_FORM", tenFile + "_FORM");
                    break;
                case "Cơ sở dữ liệu hệ thống web":
                    thongBao = bus.SaoLuuDuLieu(duongDan, "DB_ACECOOK_WEB", tenFile + "_WEB");
                    break;
                case "Kho dữ liệu chuẩn hóa":
                    thongBao = bus.SaoLuuDuLieu(duongDan, "DB_ACECOOK_NDS", tenFile + "_NDS");
                    break;
                case "Kho dữ liệu đa chiều":
                    thongBao = bus.SaoLuuDuLieu(duongDan, "DB_ACECOOK_DDS", tenFile + "_DDS");
                    break;
            }

            return thongBao;
        }

        private string XuLyPhucHoi()
        {
            string thongBao = "";
            string duongDan = txt_DuongDanFile.Text;

            switch (cbo_Restore.SelectedItem.ToString())
            {
                case "FORM":
                    thongBao += bus.PhucHoiDuLieu(duongDan, "DB_ACECOOK_FORM");
                    break;
                case "WEB":
                    thongBao += bus.PhucHoiDuLieu(duongDan, "DB_ACECOOK_WEB");
                    break;
                case "NDS":
                    thongBao += bus.PhucHoiDuLieu(duongDan, "DB_ACECOOK_NDS");
                    break;
                case "DDS":
                    thongBao += bus.PhucHoiDuLieu(duongDan, "DB_ACECOOK_DDS");
                    break;
            }

            return thongBao;
        }


        private void pictureBox_ChonDuongDan_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_DuongDan.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void pictureBox_ChonFile_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_DuongDanFile.Text = openFileDialog.FileName;
                }
            }
        }

        private void btn_SaoLuu_Click(object sender, EventArgs e)
        {
            if (txt_DuongDan.Text.Trim().Equals("") || txt_TenFile.Text.Trim().Equals("") || cbo_ChonDuLieu.SelectedIndex == -1)
            {
                MessageBox.Show(this, "Chọn dữ liệu, đường dẫn và nhập tên file", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(this, XuLySaoLuu(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            if (txt_DuongDanFile.Text.Trim().Equals("") || cbo_Restore.SelectedIndex == -1)
            {
                MessageBox.Show(this, "Chọn dữ liệu và đường dẫn file", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(this, XuLyPhucHoi(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void US_SaoLuu_Load(object sender, EventArgs e)
        {

        }
    }
}
