using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class FORM_ChinhSuaThongTin : Form
    {
        private BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
        private BUS_QuyenDuocCap bus_quyenduoccap = new BUS_QuyenDuocCap();

        public FORM_ChinhSuaThongTin()
        {
            InitializeComponent();
        }

        private void kiemtraquyen(string manhanvien)
        {
            if (bus_quyenduoccap.GetByID(manhanvien, 1) != null)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }

            if (bus_quyenduoccap.GetByID(manhanvien, 2) != null)
            {
                checkBox2.Checked = true;
            }
            else
            {
                checkBox2.Checked = false;
            }

            if (bus_quyenduoccap.GetByID(manhanvien, 3) != null)
            {
                checkBox3.Checked = true;
            }
            else
            {
                checkBox3.Checked = false;
            }

            if (bus_quyenduoccap.GetByID(manhanvien, 4) != null)
            {
                checkBox4.Checked = true;
            }
            else
            {
                checkBox4.Checked = false;
            }

            if (bus_quyenduoccap.GetByID(manhanvien, 5) != null)
            {
                checkBox5.Checked = true;
            }
            else
            {
                checkBox5.Checked = false;
            }

            if (bus_quyenduoccap.GetByID(manhanvien, 6) != null)
            {
                checkBox6.Checked = true;
            }
            else
            {
                checkBox6.Checked = false;
            }

        }

        public FORM_ChinhSuaThongTin(string manhanvien)
        {
            InitializeComponent();

            txt_MaNhanVien.Enabled = false;
            txt_MaNhanVien.Text = manhanvien;

            DTO_NhanVien dto = bus_nhanvien.GetByID(manhanvien);
            txt_CCCD.Text = dto.CCCD;
            txt_DiaChi.Text = dto.DiaChi;
            txt_Email.Text = dto.Email;
            txt_MatKhau.Text = dto.MatKhau;
            txt_TenNhanVien.Text = dto.TenNhanVien;
            txt_SDT.Text = dto.SDT;

            kiemtraquyen(manhanvien);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_MaNhanVien.Text.Trim().Equals("")
                || txt_TenNhanVien.Text.Trim().Equals("")
                || txt_Email.Text.Trim().Equals("")
                || txt_SDT.Text.Trim().Equals("")
                || txt_CCCD.Text.Trim().Equals("")
                || txt_MatKhau.Text.Trim().Equals("")
                || txt_DiaChi.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Vui lòng nhập đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (bus_nhanvien.GetByID(txt_MaNhanVien.Text.Trim()) == null)
                {
                    MessageBox.Show(this, "Mã nhân viên không tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                {
                    DTO_NhanVien dto = new DTO_NhanVien();

                    dto.MaNhanVien = txt_MaNhanVien.Text.Trim();
                    dto.TenNhanVien = txt_TenNhanVien.Text.Trim();
                    dto.Email = txt_Email.Text.Trim();
                    dto.SDT = txt_SDT.Text.Trim();
                    dto.CCCD = txt_CCCD.Text.Trim();
                    dto.MatKhau = txt_MatKhau.Text.Trim();
                    dto.DiaChi = txt_DiaChi.Text.Trim();

                    bus_nhanvien.Update(dto);

                    MessageBox.Show(this, "Sửa nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
