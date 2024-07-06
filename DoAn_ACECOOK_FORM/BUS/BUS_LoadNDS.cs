using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class BUS_LoadNDS
    {
        private DAO_LoadNDS dao = new DAO_LoadNDS();
        
        public BUS_LoadNDS () { }

        public List<DTO_NDS_ChiNhanh> GetAllChiNhanh()
        {
            return dao.GetAllChiNhanh();
        }

        public List<DTO_NDS_ChiPhiVanChuyen> GetAllChiPhiVanChuyen()
        {
            return dao.GetAllChiPhiVanChuyen();
        }

        public List<DTO_NDS_ChiTietDonHang> GetAllChiTietDonHang()
        {
            return dao.GetAllChiTietDonHang();
        }

        public List<DTO_NDS_ChiTietNhapHang> GetAllChiTietNhapHang()
        {
            return dao.GetAllChiTietNhapHang();
        }
        public List<DTO_NDS_DonHang> GetAllDonHang()
        {
            return dao.GetAllDonHang();
        }

        public List<DTO_NDS_GiamGia> GetAllGiamGia()
        {
            return dao.GetAllGiamGia();
        }
        public List<DTO_NDS_KhachHang> GetAllKhachHang()
        {
            return dao.GetAllKhachHang();
        }

        public List<DTO_NDS_KhuVuc> GetAllKhuVuc()
        {
            return dao.GetAllKhuVuc();
        }

        public List<DTO_NDS_LoaiKhachHang> GetAllLoaiKhachHang()
        {
            return dao.GetAllLoaiKhachHang();
        }

        public List<DTO_NDS_LoaiSanPham> GetAllLoaiSanPham()
        {
            return dao.GetAllLoaiSanPham();
        }

        public List<DTO_NDS_NhanVien> GetAllNhanVien()
        {
            return dao.GetAllNhanVien();
        }

        public List<DTO_NDS_NhapHang> GetAllNhapHang()
        {
            return dao.GetAllNhapHang();
        }

        public List<DTO_NDS_NhaPhanPhoi> GetAllNhaPhanPhoi()
        {
            return dao.GetAllNhaPhanPhoi();
        }

        public List<DTO_NDS_SanPham> GetAllSanPham()
        {
            return dao.GetAllSanPham();
        }
    }
}
