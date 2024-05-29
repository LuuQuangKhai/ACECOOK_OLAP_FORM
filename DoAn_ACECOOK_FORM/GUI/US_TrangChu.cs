using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class US_TrangChu : UserControl
    {
        public US_TrangChu()
        {
            InitializeComponent();
        }

        private void btn_PhanTich_Click(object sender, EventArgs e)
        {
            panel_TrangChu.Controls.Clear();
            US_PhanTich gui = new US_PhanTich();
            panel_TrangChu.Controls.Add(gui);
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

        }

    }
}
