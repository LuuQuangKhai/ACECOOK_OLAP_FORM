using BUS;
using DevExpress.CodeParser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using Microsoft.SqlServer.Management.IntegrationServices;
using System.Data.SqlClient;
using BUS;
using DTO;


namespace GUI
{
    public partial class US_NapDuLieu : UserControl
    {
        private BUS_NapDuLieu bus_napdulieu;
        private BUS_LoadNDS bus_loadnds;
        private BUS_LoadDDS bus_loaddds;

        private int khodulieunao = 0;
        private int napForm = 0;
        private int napWeb = 0;
        private int napExcel = 0;

        public US_NapDuLieu()
        {
            InitializeComponent();
        }
        private void US_NapDuLieu_Load(object sender, EventArgs e)
        {
            bus_napdulieu = new BUS_NapDuLieu();
            bus_loadnds = new BUS_LoadNDS();
            bus_loaddds = new BUS_LoadDDS();
            listBox1.Items.Clear();
            btn_NapLai.Enabled = false;
        }

        private void ckb_HeThong_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_HeThong.Checked == true)
            {
                napForm = 1;
            }
            else
            {
                napForm = 0;
            }
        }
        private void ckb_Website_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_Website.Checked == true)
            {
                napWeb = 1;
            }
            else
            {
                napWeb = 0;
            }
        }

        private void ckb_Excel_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_Excel.Checked == true)
            {
                napExcel = 1;
            }
            else
            {
                napExcel = 0;
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                lbl_TenBang.Text = "";
                if (khodulieunao == 1)
                {
                    string selectedItem = listBox1.SelectedItem.ToString();

                    lbl_TenBang.Text = selectedItem;

                    if (listBox1.SelectedItem.ToString() == "Chi Nhánh")
                    {
                        List<DTO_NDS_ChiNhanh> danhsach = bus_loadnds.GetAllChiNhanh();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = danhsach;
                    }
                    if (listBox1.SelectedItem.ToString() == "Chi Phí Vận Chuyển")
                    {
                        List<DTO_NDS_ChiPhiVanChuyen> danhsach = bus_loadnds.GetAllChiPhiVanChuyen();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = danhsach;
                    }
                    if (listBox1.SelectedItem.ToString() == "Chi Tiết Đơn Hàng")
                    {
                        List<DTO_NDS_ChiTietDonHang> danhsach = bus_loadnds.GetAllChiTietDonHang();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = danhsach;
                    }
                    if (listBox1.SelectedItem.ToString() == "Đơn Hàng")
                    {
                        List<DTO_NDS_DonHang> danhsach = bus_loadnds.GetAllDonHang();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = danhsach;
                    }
                    if (listBox1.SelectedItem.ToString() == "Giảm Giá")
                    {
                        List<DTO_NDS_GiamGia> danhsach = bus_loadnds.GetAllGiamGia();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = danhsach;
                    }
                    if (listBox1.SelectedItem.ToString() == "Khách Hàng")
                    {
                        List<DTO_NDS_KhachHang> danhsach = bus_loadnds.GetAllKhachHang();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = danhsach;
                    }
                    if (listBox1.SelectedItem.ToString() == "Khu Vực")
                    {
                        List<DTO_NDS_KhuVuc> danhsach = bus_loadnds.GetAllKhuVuc();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = danhsach;
                    }
                    if (listBox1.SelectedItem.ToString() == "Loại Sản Phẩm")
                    {
                        List<DTO_NDS_LoaiSanPham> danhsach = bus_loadnds.GetAllLoaiSanPham();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = danhsach;
                    }

                    if (listBox1.SelectedItem.ToString() == "Nhân Viên")
                    {
                        List<DTO_NDS_NhanVien> danhsach = bus_loadnds.GetAllNhanVien();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = danhsach;
                    }
                    if (listBox1.SelectedItem.ToString() == "Nhập Hàng")
                    {
                        List<DTO_NDS_NhapHang> danhsach = bus_loadnds.GetAllNhapHang();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = danhsach;
                    }
                    if (listBox1.SelectedItem.ToString() == "Nhà Phân Phối")
                    {
                        List<DTO_NDS_NhaPhanPhoi> danhsach = bus_loadnds.GetAllNhaPhanPhoi();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = danhsach;
                    }
                    if (listBox1.SelectedItem.ToString() == "Sản Phẩm")
                    {
                        List<DTO_NDS_SanPham> danhsach = bus_loadnds.GetAllSanPham();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = danhsach;
                    }
                }
                if (khodulieunao == 2)
                {
                    string selectedItem = listBox1.SelectedItem.ToString();

                    lbl_TenBang.Text = selectedItem;

                    if (listBox1.SelectedItem.ToString() == "Fact Đơn Hàng")
                    {
                        List<DTO_DDS_FactDonHangAcecook> danhsach = bus_loaddds.GetAllFactDonHangAcecook();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = danhsach;
                    }

                    if (listBox1.SelectedItem.ToString() == "Dim Nhân Viên")
                    {
                        List<DTO_DDS_DimNhanVien> danhsach = bus_loaddds.GetAllDimNhanVien();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = danhsach;
                    }

                    if (listBox1.SelectedItem.ToString() == "Dim Sản Phẩm")
                    {
                        List<DTO_DDS_DimSanPham> danhsach = bus_loaddds.GetAllDimSanPham();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = danhsach;
                    }

                    if (listBox1.SelectedItem.ToString() == "Dim Loại Sản Phẩm")
                    {
                        List<DTO_DDS_DimLoaiSanPham> danhsach = bus_loaddds.GetAllDimLoaiSanPham();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = danhsach;
                    }
                    if (listBox1.SelectedItem.ToString() == "Dim Loại Khách Hàng")
                    {
                        List<DTO_DDS_DimLoaiKhachHang> danhsach = bus_loaddds.GetAllDimLoaiKhachHang();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = danhsach;
                    }

                    if (listBox1.SelectedItem.ToString() == "Dim Khách Hàng")
                    {
                        List<DTO_DDS_DimKhachHang> danhsach = bus_loaddds.GetAllDimKhachHang();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = danhsach;
                    }

                    if (listBox1.SelectedItem.ToString() == "Dim Thời Gian")
                    {
                        List<DTO_DDS_DimThoiGian> danhsach = bus_loaddds.GetAllDimThoiGian();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = danhsach;
                    }

                    if (listBox1.SelectedItem.ToString() == "Dim Nhà Cung Cấp")
                    {
                        List<DTO_DDS_DimNhaCungCap> danhsach = bus_loaddds.GetAllDimNhaCungCap();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = danhsach;
                    }

                    if (listBox1.SelectedItem.ToString() == "Dim Khu Vực")
                    {
                        List<DTO_DDS_DimKhuVuc> danhsach = bus_loaddds.GetAllDimKhuVuc();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = danhsach;
                    }

                    if (listBox1.SelectedItem.ToString() == "Dim Chi Nhánh")
                    {
                        List<DTO_DDS_DimChiNhanh> danhsach = bus_loaddds.GetAllDimChiNhanh();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = danhsach;
                    }
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                dataGridView1.DataSource = null;
                lbl_TenBang.Text = "";
                khodulieunao = 1;

                listBox1.Items.Clear();

                listBox1.Items.Add("Chi Nhánh");
                listBox1.Items.Add("Chi Phí Vận Chuyển");
                listBox1.Items.Add("Chi Tiết Đơn Hàng");
                listBox1.Items.Add("Đơn Hàng");
                listBox1.Items.Add("Giảm Giá");
                listBox1.Items.Add("Khách Hàng");
                listBox1.Items.Add("Khu Vực");
                listBox1.Items.Add("Loại Sản Phẩm");
                listBox1.Items.Add("Nhân Viên");
                listBox1.Items.Add("Nhập Hàng");
                listBox1.Items.Add("Nhà Phân Phối");
                listBox1.Items.Add("Sản Phẩm");
            }
            if (comboBox1.SelectedIndex == 1)
            {
                dataGridView1.DataSource = null;
                lbl_TenBang.Text = "";
                khodulieunao = 2;

                listBox1.Items.Clear();

                listBox1.Items.Add("Fact Đơn Hàng");
                listBox1.Items.Add("Dim Nhân Viên");
                listBox1.Items.Add("Dim Sản Phẩm");
                listBox1.Items.Add("Dim Loại Sản Phẩm");
                listBox1.Items.Add("Dim Loại Khách Hàng");
                listBox1.Items.Add("Dim Khách Hàng");
                listBox1.Items.Add("Dim Thời Gian");
                listBox1.Items.Add("Dim Nhà Cung Cấp");
                listBox1.Items.Add("Dim Khu Vực");
                listBox1.Items.Add("Dim Chi Nhánh");
            }
        }

        private void NapDuLieu()
        {
            if (napForm == 1)
            {
                MessageBox.Show(bus_napdulieu.ExecuteSSIS("debug SSIS FORM to NDS package"));
            }
            if (napWeb == 1)
            {
                MessageBox.Show(bus_napdulieu.ExecuteSSIS("debug SSIS WEB to NDS package"));
            }
            if (napExcel == 1)
            {
                MessageBox.Show("Nap excel thanh cong");
            }
            if (napForm == 0 && napWeb == 0 && napExcel == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 hệ thống để nạp");
            }
        }

        private void btn_LamSach_Click(object sender, EventArgs e)
        {
            bus_napdulieu.ExecuteSSIS("debug CLEAR NDS package");
            bus_napdulieu.ExecuteSSIS("debug CLEAR DDS package");
            bus_napdulieu.ExecuteSSIS("debug SSIS NDS package");
        }
        private void btn_Nap_Click(object sender, EventArgs e)
        {
            NapDuLieu();
            MessageBox.Show(bus_napdulieu.ExecuteSSIS("debug SSIS NDS package"));
            btn_NapLai.Enabled = true;
            btn_Nap.Enabled = false;
        }
        private void btn_NapLai_Click(object sender, EventArgs e)
        {
            btn_Nap.Enabled = true;
            btn_NapLai.Enabled = false;
        }
    }
}