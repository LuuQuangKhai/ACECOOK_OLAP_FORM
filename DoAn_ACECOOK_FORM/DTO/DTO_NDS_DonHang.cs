using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NDS_DonHang
    {
        public string MaDonHang { get; set; }
        public DateTime NgayDatHang { get; set; }
        public DateTime NgayGiaoHang { get; set; }
        public float TongTien { get; set; }
        public string PhuongThucThanhToan { get; set; }
        public string MaKhachHang { get; set; }
        public string MaNhanVien { get; set; }
        public string MaChiNhanh { get; set; }
        public string MaGiamGia { get; set; }
    }
}
