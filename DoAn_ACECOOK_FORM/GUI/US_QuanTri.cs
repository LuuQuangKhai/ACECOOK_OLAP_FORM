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
    public partial class US_QuanTri : UserControl
    {
        private BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
        private BUS_QuyenDuocCap bus_quyenduoccap = new BUS_QuyenDuocCap();
        private string manhanvien_public;

        public US_QuanTri()
        {
            InitializeComponent();
        }

        public US_QuanTri(string manhanvien)
        {
            InitializeComponent();
            manhanvien_public = manhanvien;
        }

        private void kiemtraquyen(string manhanvien)
        {
            if (bus_quyenduoccap.GetByID(manhanvien,1) != null)
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

        private void loadDanhSach()
        {
            var dsnhanvien = bus_nhanvien.GetAll();
            var locdanhsach = dsnhanvien.Where(nv => nv.MaNhanVien != "admin").ToList();

            dataGridView_DanhSachNhanVien.DataSource = null;
            dataGridView_DanhSachNhanVien.DataSource = locdanhsach;
        }


        private void US_QuanTri_Load(object sender, EventArgs e)
        {
            loadDanhSach();
        }



        private void btn_Them_Click(object sender, EventArgs e)
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
                    DTO_NhanVien dto = new DTO_NhanVien();

                    dto.MaNhanVien = txt_MaNhanVien.Text.Trim();
                    dto.TenNhanVien = txt_TenNhanVien.Text.Trim();
                    dto.Email = txt_Email.Text.Trim();
                    dto.SDT = txt_SDT.Text.Trim();
                    dto.CCCD = txt_CCCD.Text.Trim();
                    dto.MatKhau = txt_MatKhau.Text.Trim();
                    dto.DiaChi = txt_DiaChi.Text.Trim();

                    bus_nhanvien.Add(dto);

                    MessageBox.Show(this, "Thêm nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loadDanhSach();
                }
                else
                {
                    MessageBox.Show(this, "Trùng Mã nhân viên !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_MaNhanVien.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Chưa nhập Mã nhân viên !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (bus_nhanvien.GetByID(txt_MaNhanVien.Text.Trim()) == null)
                {
                    MessageBox.Show(this, "Mã nhân viên không tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bus_nhanvien.Delete(txt_MaNhanVien.Text.Trim());

                    MessageBox.Show(this, "Xóa nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loadDanhSach();
                }
            }
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

                    loadDanhSach();
                }
            }
        }

        private void dataGridView_DanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_DanhSachNhanVien.Rows[e.RowIndex];
                txt_MaNhanVien.Text = row.Cells["MaNhanVien"].Value.ToString();
                txt_TenNhanVien.Text = row.Cells["TenNhanVien"].Value.ToString();
                txt_Email.Text = row.Cells["Email"].Value.ToString();
                txt_SDT.Text = row.Cells["SDT"].Value.ToString();
                txt_MatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                txt_CCCD.Text = row.Cells["CCCD"].Value.ToString();
                txt_DiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (bus_nhanvien.GetByID(txt_MaNhanVien.Text.Trim()) != null)
            {
                DTO_QuyenDuocCap dto = new DTO_QuyenDuocCap();
                dto.MaNhanVien = txt_MaNhanVien.Text.Trim();
                dto.MaQuyen = 1;

                if (checkBox1.Checked == true)
                {

                    if (bus_quyenduoccap.GetByID(dto.MaNhanVien, dto.MaQuyen) == null)
                    {
                        bus_quyenduoccap.Add(dto);
                    }
                }
                else
                {
                    if (bus_quyenduoccap.GetByID(dto.MaNhanVien, dto.MaQuyen) != null)
                    {
                        bus_quyenduoccap.Delete(dto);
                    }
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (bus_nhanvien.GetByID(txt_MaNhanVien.Text.Trim()) != null)
            {
                DTO_QuyenDuocCap dto = new DTO_QuyenDuocCap();
                dto.MaNhanVien = txt_MaNhanVien.Text.Trim();
                dto.MaQuyen = 2;

                if (checkBox2.Checked == true)
                {

                    if (bus_quyenduoccap.GetByID(dto.MaNhanVien, dto.MaQuyen) == null)
                    {
                        bus_quyenduoccap.Add(dto);
                    }
                }
                else
                {
                    if (bus_quyenduoccap.GetByID(dto.MaNhanVien, dto.MaQuyen) != null)
                    {
                        bus_quyenduoccap.Delete(dto);
                    }
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (bus_nhanvien.GetByID(txt_MaNhanVien.Text.Trim()) != null)
            {
                DTO_QuyenDuocCap dto = new DTO_QuyenDuocCap();
                dto.MaNhanVien = txt_MaNhanVien.Text.Trim();
                dto.MaQuyen = 3;

                if (checkBox3.Checked == true)
                {

                    if (bus_quyenduoccap.GetByID(dto.MaNhanVien, dto.MaQuyen) == null)
                    {
                        bus_quyenduoccap.Add(dto);
                    }
                }
                else
                {
                    if (bus_quyenduoccap.GetByID(dto.MaNhanVien, dto.MaQuyen) != null)
                    {
                        bus_quyenduoccap.Delete(dto);
                    }
                }
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (bus_nhanvien.GetByID(txt_MaNhanVien.Text.Trim()) != null)
            {
                DTO_QuyenDuocCap dto = new DTO_QuyenDuocCap();
                dto.MaNhanVien = txt_MaNhanVien.Text.Trim();
                dto.MaQuyen = 4;

                if (checkBox4.Checked == true)
                {

                    if (bus_quyenduoccap.GetByID(dto.MaNhanVien, dto.MaQuyen) == null)
                    {
                        bus_quyenduoccap.Add(dto);
                    }
                }
                else
                {
                    if (bus_quyenduoccap.GetByID(dto.MaNhanVien, dto.MaQuyen) != null)
                    {
                        bus_quyenduoccap.Delete(dto);
                    }
                }
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (bus_nhanvien.GetByID(txt_MaNhanVien.Text.Trim()) != null)
            {
                DTO_QuyenDuocCap dto = new DTO_QuyenDuocCap();
                dto.MaNhanVien = txt_MaNhanVien.Text.Trim();
                dto.MaQuyen = 5;

                if (checkBox5.Checked == true)
                {
                    if (bus_quyenduoccap.GetByID(dto.MaNhanVien, dto.MaQuyen) == null)
                    {
                        bus_quyenduoccap.Add(dto);
                    }
                }
                else
                {
                    if (bus_quyenduoccap.GetByID(dto.MaNhanVien, dto.MaQuyen) != null)
                    {
                        bus_quyenduoccap.Delete(dto);
                    }
                }
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (bus_nhanvien.GetByID(txt_MaNhanVien.Text.Trim()) != null)
            {
                DTO_QuyenDuocCap dto = new DTO_QuyenDuocCap();
                dto.MaNhanVien = txt_MaNhanVien.Text.Trim();
                dto.MaQuyen = 6;

                if (checkBox6.Checked == true)
                {

                    if (bus_quyenduoccap.GetByID(dto.MaNhanVien, dto.MaQuyen) == null)
                    {
                        bus_quyenduoccap.Add(dto);
                    }
                }
                else
                {
                    if (bus_quyenduoccap.GetByID(dto.MaNhanVien, dto.MaQuyen) != null)
                    {
                        bus_quyenduoccap.Delete(dto);
                    }
                }
            }
        }

        private void txt_MaNhanVien_TextChanged(object sender, EventArgs e)
        {
            kiemtraquyen(txt_MaNhanVien.Text.Trim());
        }
    }
}
