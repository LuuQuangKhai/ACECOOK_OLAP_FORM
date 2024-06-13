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
using BUS;
using DTO;

namespace GUI
{
    public partial class FORM_KhungTrang : Form
    {
        private BUS_QuyenDuocCap bus_quyenduoccap = new BUS_QuyenDuocCap();

        private string manhanvien_public;

        public FORM_KhungTrang()
        {
            InitializeComponent();
        }

        public FORM_KhungTrang(string manhanvien)
        {
            InitializeComponent();
            manhanvien_public = manhanvien;
        }

        private void kiemtraquyen()
        {
            List<DTO_QuyenDuocCap> list_quyenduoccap = bus_quyenduoccap.GetAllByID(manhanvien_public);

            foreach(DTO_QuyenDuocCap dto in list_quyenduoccap)
            {
                if(dto.MaQuyen == 1)
                {
                    menuItem_QuanTri.Enabled = true;
                }
            }
        }

        private void FORM_KhungTrang_Load(object sender, EventArgs e)
        {
            panel_KhungTrang.Controls.Clear();
            US_TrangChu gui = new US_TrangChu(manhanvien_public);
            panel_KhungTrang.Controls.Add(gui);

            menuItem_QuanTri.Enabled = false;

            kiemtraquyen();
        }

        private void menuItem_TrangChu_Click(object sender, EventArgs e)
        {
            panel_KhungTrang.Controls.Clear();
            US_TrangChu gui = new US_TrangChu(manhanvien_public);
            panel_KhungTrang.Controls.Add(gui);
        }

        private void menuItem_QuanTri_Click(object sender, EventArgs e)
        {
            panel_KhungTrang.Controls.Clear();
            US_QuanTri gui = new US_QuanTri(manhanvien_public);
            panel_KhungTrang.Controls.Add(gui);
        }

    }
}
