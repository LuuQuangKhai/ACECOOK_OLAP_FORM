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
using System.Data.SqlClient;
using System.Data;

namespace GUI
{
    public partial class US_QuanTri : UserControl
    {
        private BUS_NhanVien bus = new BUS_NhanVien();

        public US_QuanTri()
        {
            InitializeComponent();
        }

        private void US_QuanTri_Load(object sender, EventArgs e)
        {
            dataGridView_DanhSachNhanVien.DataSource = bus.GetAll();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }


    }
}
