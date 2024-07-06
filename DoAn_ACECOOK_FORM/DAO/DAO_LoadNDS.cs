using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class DAO_LoadNDS : ConnectionString
    {
        public DAO_LoadNDS() { }

        public List<DTO_NDS_ChiNhanh> GetAllChiNhanh()
        {
            List<DTO_NDS_ChiNhanh> list = new List<DTO_NDS_ChiNhanh>();
            using (
                var connection = new SqlConnection(myConnectionString_NDS))
            {
                connection.Open();
                string query = "SELECT * FROM ChiNhanh";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dto = new DTO_NDS_ChiNhanh
                            {
                                MaChiNhanh = reader["MaChiNhanh"].ToString(),
                                TenChiNhanh = reader["TenChiNhanh"].ToString(),
                                MaKhuVuc = reader["MaKhuVuc"].ToString(),
                            };
                            list.Add(dto);
                        }
                    }
                }
            }
            return list;
        }

        public List<DTO_NDS_ChiPhiVanChuyen> GetAllChiPhiVanChuyen()
        {
            List<DTO_NDS_ChiPhiVanChuyen> list = new List<DTO_NDS_ChiPhiVanChuyen>();
            using (
                var connection = new SqlConnection(myConnectionString_NDS))
            {
                connection.Open();
                string query = "SELECT * FROM ChiPhiVanChuyen";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dto = new DTO_NDS_ChiPhiVanChuyen
                            {
                                MaVanChuyen = reader["MaVanChuyen"].ToString(),
                                LoaiVanChuyen = reader["LoaiVanChuyen"].ToString(),
                                TienVanChuyen = float.Parse(reader["TienVanChuyen"].ToString()),
                                MaDonHang = reader["MaDonhang"].ToString(),
                            };
                            list.Add(dto);
                        }
                    }
                }
            }
            return list;
        }

        public List<DTO_NDS_ChiTietDonHang> GetAllChiTietDonHang()
        {
            List<DTO_NDS_ChiTietDonHang> list = new List<DTO_NDS_ChiTietDonHang>();
            using (
                var connection = new SqlConnection(myConnectionString_NDS))
            {
                connection.Open();
                string query = "SELECT * FROM ChiTietDonHang";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dto = new DTO_NDS_ChiTietDonHang
                            {
                                MaDonHang = reader["MaDonHang"].ToString(),
                                MaSanPham = reader["MaSanPham"].ToString(),
                                GiaBan = float.Parse(reader["GiaBan"].ToString()),
                                SoLuong = int.Parse(reader["SoLuong"].ToString()),
                            };
                            list.Add(dto);
                        }
                    }
                }
            }
            return list;
        }
        public List<DTO_NDS_ChiTietNhapHang> GetAllChiTietNhapHang()
        {
            List<DTO_NDS_ChiTietNhapHang> list = new List<DTO_NDS_ChiTietNhapHang>();
            using (
                var connection = new SqlConnection(myConnectionString_NDS))
            {
                connection.Open();
                string query = "SELECT * FROM ChiTietNhapHang";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dto = new DTO_NDS_ChiTietNhapHang
                            {
                                MaNhapHang = reader["MaNhapHang"].ToString(),
                                MaSanPham = reader["MaSanPham"].ToString(),
                                GiaBan = float.Parse(reader["GiaBan"].ToString()),
                                SoLuong = int.Parse(reader["SoLuong"].ToString()),
                            };
                            list.Add(dto);
                        }
                    }
                }
            }
            return list;
        }

        public List<DTO_NDS_DonHang> GetAllDonHang()
        {
            List<DTO_NDS_DonHang> list = new List<DTO_NDS_DonHang>();
            using (
                var connection = new SqlConnection(myConnectionString_NDS))
            {
                connection.Open();
                string query = "SELECT * FROM DonHang";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dto = new DTO_NDS_DonHang
                            {
                                MaDonHang = reader["MaDonHang"].ToString(),
                                NgayDatHang = (DateTime)reader["NgayDatHang"],
                                NgayGiaoHang = (DateTime)reader["NgayGiaoHang"],
                                TongTien = float.Parse(reader["TongTien"].ToString()),
                                PhuongThucThanhToan = reader["PhuongThucThanhToan"].ToString(),
                                MaKhachHang = reader["MaKhachHang"].ToString(),
                                MaNhanVien = reader["MaNhanVien"].ToString(),
                                MaChiNhanh = reader["MaChiNhanh"].ToString(),
                                MaGiamGia = reader["MaGiamGia"].ToString(),
                            };
                            list.Add(dto);
                        }
                    }
                }
            }
            return list;
        }

        public List<DTO_NDS_GiamGia> GetAllGiamGia()
        {
            List<DTO_NDS_GiamGia> list = new List<DTO_NDS_GiamGia>();
            using (
                var connection = new SqlConnection(myConnectionString_NDS))
            {
                connection.Open();
                string query = "SELECT * FROM GiamGia";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dto = new DTO_NDS_GiamGia
                            {
                                MaGiamGia = reader["MaGiamGia"].ToString(),
                                SoTienApDung = float.Parse(reader["SoTienApDung"].ToString()),
                                SoTienGiamGia = float.Parse(reader["SoTienGiamGia"].ToString()),
                                HanSuDung = (DateTime)reader["HanSuDung"],
                            };
                            list.Add(dto);
                        }
                    }
                }
            }
            return list;
        }

        public List<DTO_NDS_KhachHang> GetAllKhachHang()
        {
            List<DTO_NDS_KhachHang> list = new List<DTO_NDS_KhachHang>();
            using (
                var connection = new SqlConnection(myConnectionString_NDS))
            {
                connection.Open();
                string query = "SELECT * FROM KhachHang";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dto = new DTO_NDS_KhachHang
                            {
                                MaKhachHang = reader["MaKhachHang"].ToString(),
                                TenKhachHang = reader["TenKhachHang"].ToString(),
                                MaLoaiKhachHang = reader["MaLoaiKhachHang"].ToString(),
                                Tuoi = int.Parse(reader["Tuoi"].ToString()),
                            };
                            list.Add(dto);
                        }
                    }
                }
            }
            return list;
        }

        public List<DTO_NDS_KhuVuc> GetAllKhuVuc()
        {
            List<DTO_NDS_KhuVuc> list = new List<DTO_NDS_KhuVuc>();
            using (
                var connection = new SqlConnection(myConnectionString_NDS))
            {
                connection.Open();
                string query = "SELECT * FROM KhuVuc";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dto = new DTO_NDS_KhuVuc
                            {
                                MaKhuVuc = reader["MaKhuVuc"].ToString(),
                                TenKhuVuc = reader["TenKhuVuc"].ToString(),
                            };
                            list.Add(dto);
                        }
                    }
                }
            }
            return list;
        }

        public List<DTO_NDS_LoaiKhachHang> GetAllLoaiKhachHang()
        {
            List<DTO_NDS_LoaiKhachHang> list = new List<DTO_NDS_LoaiKhachHang>();
            using (
                var connection = new SqlConnection(myConnectionString_NDS))
            {
                connection.Open();
                string query = "SELECT * FROM LoaiKhachHang";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dto = new DTO_NDS_LoaiKhachHang
                            {
                                MaLoaiKhachHang = reader["MaLoaiKhachHang"].ToString(),
                                TenLoaiKhachHang = reader["TenLoaiKhachHang"].ToString(),
                            };
                            list.Add(dto);
                        }
                    }
                }
            }
            return list;
        }

        public List<DTO_NDS_LoaiSanPham> GetAllLoaiSanPham()
        {
            List<DTO_NDS_LoaiSanPham> list = new List<DTO_NDS_LoaiSanPham>();
            using (
                var connection = new SqlConnection(myConnectionString_NDS))
            {
                connection.Open();
                string query = "SELECT * FROM LoaiSanPham";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dto = new DTO_NDS_LoaiSanPham
                            {
                                MaLoaiSanPham = reader["MaLoaiSanPham"].ToString(),
                                TenLoaiSanPham = reader["TenLoaiSanPham"].ToString(),
                            };
                            list.Add(dto);
                        }
                    }
                }
            }
            return list;
        }

        public List<DTO_NDS_NhanVien> GetAllNhanVien()
        {
            List<DTO_NDS_NhanVien> list = new List<DTO_NDS_NhanVien>();
            using (
                var connection = new SqlConnection(myConnectionString_NDS))
            {
                connection.Open();
                string query = "SELECT * FROM NhanVien";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dto = new DTO_NDS_NhanVien
                            {
                                MaNhanVien = reader["MaNhanVien"].ToString(),
                                TenNhanVien = reader["TenNhanVien"].ToString(),
                            };
                            list.Add(dto);
                        }
                    }
                }
            }
            return list;
        }

        public List<DTO_NDS_NhapHang> GetAllNhapHang()
        {
            List<DTO_NDS_NhapHang> list = new List<DTO_NDS_NhapHang>();
            using (
                var connection = new SqlConnection(myConnectionString_NDS))
            {
                connection.Open();
                string query = "SELECT * FROM NhapHang";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dto = new DTO_NDS_NhapHang
                            {
                                MaNhapHang = reader["MaNhapHang"].ToString(),
                                NgayNhapHang = (DateTime)reader["NgayNhapHang"],
                                MaNhaPhanPhoi = reader["MaNhaPhanPhoi"].ToString(),
                                MaChiNhanh = reader["MaChiNhanh"].ToString(),
                            };
                            list.Add(dto);
                        }
                    }
                }
            }
            return list;
        }

        public List<DTO_NDS_NhaPhanPhoi> GetAllNhaPhanPhoi()
        {
            List<DTO_NDS_NhaPhanPhoi> list = new List<DTO_NDS_NhaPhanPhoi>();
            using (
                var connection = new SqlConnection(myConnectionString_NDS))
            {
                connection.Open();
                string query = "SELECT * FROM NhaPhanPhoi";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dto = new DTO_NDS_NhaPhanPhoi
                            {
                                MaNhaPhanPhoi = reader["MaNhaPhanPhoi"].ToString(),
                                TenNhaPhanPhoi = reader["TenNhaPhanPhoi"].ToString(),
                            };
                            list.Add(dto);
                        }
                    }
                }
            }
            return list;
        }

        public List<DTO_NDS_SanPham> GetAllSanPham()
        {
            List<DTO_NDS_SanPham> list = new List<DTO_NDS_SanPham>();
            using (
                var connection = new SqlConnection(myConnectionString_NDS))
            {
                connection.Open();
                string query = "SELECT * FROM SanPham";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dto = new DTO_NDS_SanPham
                            {
                                MaSanPham = reader["MaSanPham"].ToString(),
                                TenSanPham = reader["TenSanPham"].ToString(),
                                MaLoaiSanPham = reader["MaLoaiSanPham"].ToString(),
                            };
                            list.Add(dto);
                        }
                    }
                }
            }
            return list;
        }
    }
}
