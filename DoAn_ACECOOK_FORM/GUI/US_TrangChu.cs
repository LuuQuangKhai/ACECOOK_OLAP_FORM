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
    public partial class US_TrangChu : UserControl
    {
        private BUS_QuyenDuocCap bus_quyenduoccap = new BUS_QuyenDuocCap();

        private string manhanvien_public;

        public US_TrangChu()
        {
            InitializeComponent();
        }

        public US_TrangChu(string manhanvien)
        {
            InitializeComponent();
            manhanvien_public = manhanvien;
        }

        private void btn_PhanTich_Click(object sender, EventArgs e)
        {
            panel_TrangChu.Controls.Clear();
            US_PhanTich gui = new US_PhanTich();
            panel_TrangChu.Controls.Add(gui);
        }

        private void kiemtraquyen()
        {
            List<DTO_QuyenDuocCap> list_quyenduoccap = bus_quyenduoccap.GetAllByID(manhanvien_public);

            foreach (DTO_QuyenDuocCap dto in list_quyenduoccap)
            {
                if (dto.MaQuyen == 2)
                {
                    btn_NapDuLieu.Enabled = true;
                }
                if(dto.MaQuyen == 3)
                {
                    btn_PhanTich.Enabled = true;
                }
                if (dto.MaQuyen == 4)
                {
                    btn_ThongKe.Enabled = true;
                }
                if (dto.MaQuyen == 5)
                {
                    btn_KhaiPha.Enabled = true;
                }
                if(dto.MaQuyen == 6)
                {
                    btn_SaoLuu.Enabled = true;
                }
            }
        }

        private void US_TrangChu_Load(object sender, EventArgs e)
        {
            Image myImage = Properties.Resources.napdulieu;
            Bitmap resizedImage = new Bitmap(myImage, new Size(30, 30));
            btn_NapDuLieu.Image = resizedImage;

            Image myImage2 = Properties.Resources.phantich;
            Bitmap resizedImage2 = new Bitmap(myImage2, new Size(30, 30));
            btn_PhanTich.Image = resizedImage2;

            Image myImage3 = Properties.Resources.thongke;
            Bitmap resizedImage3 = new Bitmap(myImage3, new Size(30, 30));
            btn_ThongKe.Image = resizedImage3;

            Image myImage4 = Properties.Resources.khaipha;
            Bitmap resizedImage4 = new Bitmap(myImage4, new Size(30, 30));
            btn_KhaiPha.Image = resizedImage4;

            Image myImage5 = Properties.Resources.saoluu;
            Bitmap resizedImage5 = new Bitmap(myImage5, new Size(30, 30));
            btn_SaoLuu.Image = resizedImage5;

            lbl_MaNhanVien.Text = manhanvien_public;

            btn_NapDuLieu.Enabled = false;
            btn_PhanTich.Enabled = false;
            btn_ThongKe.Enabled = false;
            btn_KhaiPha.Enabled = false;
            btn_SaoLuu.Enabled = false;

            kiemtraquyen();
        }

    }
}
