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

namespace GUI
{
    public partial class FORM_KhungTrang : Form
    {
        public FORM_KhungTrang()
        {
            InitializeComponent();
        }

        private void FORM_KhungTrang_Load(object sender, EventArgs e)
        {
            panel_KhungTrang.Controls.Clear();
            US_TrangChu gui = new US_TrangChu();
            panel_KhungTrang.Controls.Add(gui);
        }

        private void menuItem_TrangChu_Click(object sender, EventArgs e)
        {
            panel_KhungTrang.Controls.Clear();
            US_TrangChu gui = new US_TrangChu();
            panel_KhungTrang.Controls.Add(gui);
        }

        private void menuItem_QuanTri_Click(object sender, EventArgs e)
        {
            panel_KhungTrang.Controls.Clear();
            US_QuanTri gui = new US_QuanTri();
            panel_KhungTrang.Controls.Add(gui);
        }

    }
}
