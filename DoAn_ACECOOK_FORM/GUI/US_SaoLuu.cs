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
                    thongBao += bus.SaoLuuDuLieu(duongDan, "DB_ACECOOK_FORM", tenFile + "_FORM");
                    thongBao += "\n";
                    thongBao += bus.SaoLuuDuLieu(duongDan, "DB_ACECOOK_WEB", tenFile + "_WEB");
                    thongBao += "\n";
                    thongBao += bus.SaoLuuDuLieu(duongDan, "DB_ACECOOK_NDS", tenFile + "_NDS");
                    thongBao += "\n";
                    thongBao += bus.SaoLuuDuLieu(duongDan, "DB_ACECOOK_DDS", tenFile + "_DDS");
                    break;
                case "FORM":
                    thongBao += bus.SaoLuuDuLieu(duongDan, "DB_ACECOOK_FORM", tenFile + "_FORM");
                    break;
                case "WEB":
                    thongBao += bus.SaoLuuDuLieu(duongDan, "DB_ACECOOK_WEB", tenFile + "_WEB");
                    break;
                case "NDS":
                    thongBao += bus.SaoLuuDuLieu(duongDan, "DB_ACECOOK_NDS", tenFile + "_NDS");
                    break;
                case "DDS":
                    thongBao += bus.SaoLuuDuLieu(duongDan, "DB_ACECOOK_DDS", tenFile + "_DDS");
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

        private void btn_SaoLuu_Click(object sender, EventArgs e)
        {
            if (txt_DuongDan.Text.Trim().Equals("") || txt_TenFile.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Chọn đường dẫn và nhập tên file", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(this, XuLySaoLuu(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txt_DuongDan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
