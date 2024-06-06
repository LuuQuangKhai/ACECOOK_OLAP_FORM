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

namespace GUI
{
    public partial class US_PhanTich : UserControl
    {
        BUS_OLAP_MDX bus;
        public US_PhanTich()
        {
            InitializeComponent();
            bus = new BUS_OLAP_MDX();
        }

        private void LoadData()
        {
            string mdxQuery = @"select [Measures].[Doanh Thu] on columns,
                                non empty [Dim Chi Nhanh].[Ten Khu Vuc].members on rows
                                from [DB ACECOOK DDS]";

            dataGridView1.DataSource = bus.GetMDXData(mdxQuery);
        }

        private void US_PhanTich_Load(object sender, EventArgs e)
        {
            Image myImage = Properties.Resources.word;
            Bitmap resizedImage = new Bitmap(myImage, new Size(30, 30));
            btn_XuatWord.Image = resizedImage;

            Image myImage2 = Properties.Resources.excel;
            Bitmap resizedImage2 = new Bitmap(myImage2, new Size(30, 30));
            btn_XuatExcel.Image = resizedImage2;

            Image myImage3 = Properties.Resources.action;
            Bitmap resizedImage3 = new Bitmap(myImage3, new Size(30, 30));
            btn_PhanTich.Image = resizedImage3;


            LoadData();
        }

        private void cbo_KhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_KhuVuc.ForeColor = Color.Black;
        }

        private void cbo_ChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_ChiNhanh.ForeColor = Color.Black;
        }

        private void btn_XuatExcel_Click(object sender, EventArgs e)
        {

        }
    }
}
