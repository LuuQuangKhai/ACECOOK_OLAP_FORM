using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_LoadDDS
    {
        private DAO_LoadDDS dao = new DAO_LoadDDS();

        public BUS_LoadDDS() { }

        public List<DTO_DDS_DimChiNhanh> GetAllDimChiNhanh()
        {
            return dao.GetAllDimChiNhanh();
        }
        public List<DTO_DDS_DimKhachHang> GetAllDimKhachHang()
        {
            return dao.GetAllDimKhachHang();
        }
        public List<DTO_DDS_DimKhuVuc> GetAllDimKhuVuc()
        {
            return dao.GetAllDimKhuVuc();
        }
        public List<DTO_DDS_DimLoaiKhachHang> GetAllDimLoaiKhachHang()
        {
            return dao.GetAllDimLoaiKhachHang();
        }
        public List<DTO_DDS_DimNhanVien> GetAllDimNhanVien()
        {
            return dao.GetAllDimNhanVien();
        }
        public List<DTO_DDS_DimNhaCungCap> GetAllDimNhaCungCap()
        {
            return dao.GetAllDimNhaCungCap();
        }

        public List<DTO_DDS_DimLoaiSanPham> GetAllDimLoaiSanPham()
        {
            return dao.GetAllDimLoaiSanPham();
        }

        public List<DTO_DDS_DimSanPham> GetAllDimSanPham()
        {
            return dao.GetAllDimSanPham();
        }

        public List<DTO_DDS_DimThoiGian> GetAllDimThoiGian()
        {
            return dao.GetAllDimThoiGian();
        }

        public List<DTO_DDS_FactDonHangAcecook> GetAllFactDonHangAcecook()
        {
            return dao.GetAllFactDonHangAcecook();
        }
    }
}
