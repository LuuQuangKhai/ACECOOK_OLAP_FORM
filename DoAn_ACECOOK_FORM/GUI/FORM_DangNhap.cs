using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using BUS;
using DTO;

namespace GUI
{
    public partial class FORM_DangNhap : Form
    {
        private BUS_NhanVien bus_nhanvien = new BUS_NhanVien();

        public FORM_DangNhap()
        {
            InitializeComponent();
        }

        private void FORM_DangNhap_Load(object sender, EventArgs e)
        {
            txt_MatKhau.UseSystemPasswordChar = true;
        }

        private void pictureBox_AnHienMatKhau_Click(object sender, EventArgs e)
        {
            if (txt_MatKhau.UseSystemPasswordChar)
            {
                pictureBox_AnHienMatKhau.Image = Properties.Resources.hien;
                txt_MatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                pictureBox_AnHienMatKhau.Image = Properties.Resources.an;
                txt_MatKhau.UseSystemPasswordChar = true;
            }
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if(txt_MatKhau.Text.Trim().Equals("") || txt_TenDangNhap.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Tên đăng nhập hoặc mật khẩu không được để trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DTO_NhanVien dto = bus_nhanvien.GetByID(txt_TenDangNhap.Text.Trim());
                if (dto != null)
                {
                    if(txt_MatKhau.Text.Trim().Equals(dto.MatKhau))
                    {
                        FORM_KhungTrang gui = new FORM_KhungTrang(txt_TenDangNhap.Text.Trim());
                        this.Hide();
                        gui.Show();
                        gui.FormClosing += Gui_FormClosing;
                    }
                    else
                    {
                        MessageBox.Show(this, "Sai mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Tên tài khoản không tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Gui_FormClosing(object? sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btn_QuenMatKhau_Click(object sender, EventArgs e)
        {
            
        }
    }
}
