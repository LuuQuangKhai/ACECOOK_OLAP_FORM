using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DAO
{
    public class DAO_LoadDDS : ConnectionString
    {
        public DAO_LoadDDS() { }

        public List<DTO_DDS_DimChiNhanh> GetAllDimChiNhanh()
        {
            List<DTO_DDS_DimChiNhanh> list = new List<DTO_DDS_DimChiNhanh>();
            using (
                var connection = new SqlConnection(myConnectionString_DDS))
            {
                connection.Open();
                string query = "SELECT * FROM Dim_ChiNhanh";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dto = new DTO_DDS_DimChiNhanh
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

        public List<DTO_DDS_DimKhuVuc> GetAllDimKhuVuc()
        {
            List<DTO_DDS_DimKhuVuc> list = new List<DTO_DDS_DimKhuVuc>();
            using (
                var connection = new SqlConnection(myConnectionString_DDS))
            {
                connection.Open();
                string query = "SELECT * FROM Dim_KhuVuc";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dto = new DTO_DDS_DimKhuVuc
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

        public List<DTO_DDS_DimNhaCungCap> GetAllDimNhaCungCap()
        {
            List<DTO_DDS_DimNhaCungCap> list = new List<DTO_DDS_DimNhaCungCap>();
            using (
                var connection = new SqlConnection(myConnectionString_DDS))
            {
                connection.Open();
                string query = "SELECT * FROM Dim_NhaCungCap";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dto = new DTO_DDS_DimNhaCungCap
                            {
                                MaNhaCungCap = reader["MaNhaCungCap"].ToString(),
                                TenNhaCungCap = reader["TenNhaCungCap"].ToString(),
                            };
                            list.Add(dto);
                        }
                    }
                }
            }
            return list;
        }

        public List<DTO_DDS_DimNhanVien> GetAllDimNhanVien()
        {
            List<DTO_DDS_DimNhanVien> list = new List<DTO_DDS_DimNhanVien>();
            using (
                var connection = new SqlConnection(myConnectionString_DDS))
            {
                connection.Open();
                string query = "SELECT * FROM Dim_NhanVien";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dto = new DTO_DDS_DimNhanVien
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

        public List<DTO_DDS_DimSanPham> GetAllDimSanPham()
        {
            List<DTO_DDS_DimSanPham> list = new List<DTO_DDS_DimSanPham>();
            using (
                var connection = new SqlConnection(myConnectionString_DDS))
            {
                connection.Open();
                string query = "SELECT * FROM Dim_SanPham";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dto = new DTO_DDS_DimSanPham
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

        public List<DTO_DDS_DimLoaiSanPham> GetAllDimLoaiSanPham()
        {
            List<DTO_DDS_DimLoaiSanPham> list = new List<DTO_DDS_DimLoaiSanPham>();
            using (
                var connection = new SqlConnection(myConnectionString_DDS))
            {
                connection.Open();
                string query = "SELECT * FROM Dim_LoaiSanPham";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dto = new DTO_DDS_DimLoaiSanPham
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

        public List<DTO_DDS_DimLoaiKhachHang> GetAllDimLoaiKhachHang()
        {
            List<DTO_DDS_DimLoaiKhachHang> list = new List<DTO_DDS_DimLoaiKhachHang>();
            using (
                var connection = new SqlConnection(myConnectionString_DDS))
            {
                connection.Open();
                string query = "SELECT * FROM Dim_LoaiKhachHang";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dto = new DTO_DDS_DimLoaiKhachHang
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

        public List<DTO_DDS_DimKhachHang> GetAllDimKhachHang()
        {
            List<DTO_DDS_DimKhachHang> list = new List<DTO_DDS_DimKhachHang>();
            using (
                var connection = new SqlConnection(myConnectionString_DDS))
            {
                connection.Open();
                string query = "SELECT * FROM Dim_KhachHang";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dto = new DTO_DDS_DimKhachHang
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

        public List<DTO_DDS_DimThoiGian> GetAllDimThoiGian()
        {
            List<DTO_DDS_DimThoiGian> list = new List<DTO_DDS_DimThoiGian>();
            using (
                var connection = new SqlConnection(myConnectionString_DDS))
            {
                connection.Open();
                string query = "SELECT * FROM Dim_ThoiGian";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dto = new DTO_DDS_DimThoiGian
                            {
                                MaThoiGian = int.Parse(reader["MaThoiGian"].ToString()),
                                Quy = int.Parse(reader["Quy"].ToString()),
                                Ngay = int.Parse(reader["Ngay"].ToString()),
                                Thang = int.Parse(reader["Thang"].ToString()),
                                Nam = int.Parse(reader["Nam"].ToString()),
                                NgayDatHang = (DateTime)reader["NgayDatHang"],
                            };
                            list.Add(dto);
                        }
                    }
                }
            }
            return list;
        }

        public List<DTO_DDS_FactDonHangAcecook> GetAllFactDonHangAcecook()
        {
            List<DTO_DDS_FactDonHangAcecook> list = new List<DTO_DDS_FactDonHangAcecook>();

            using (var connection = new SqlConnection(myConnectionString_DDS))
            {
                connection.Open();
                string query = "SELECT * FROM Fact_DonHang_ACECOOK";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dto = new DTO_DDS_FactDonHangAcecook
                            {
                                MaDonHang = reader["MaDonHang"].ToString(),
                                MaThoiGian = int.Parse(reader["MaThoiGian"].ToString()),
                                MaSanPham = reader["MaSanPham"].ToString(),
                                MaChiNhanh = reader["MaChiNhanh"].ToString(),
                                MaKhachHang = reader["MaKhachHang"].ToString(),
                                MaNhanVien = reader["MaNhanVien"].ToString(),
                                MaNhaCungCap = reader["MaNhaCungCap"].ToString(),
                                SoLuongBan = int.Parse(reader["SoLuongBan"].ToString()),
                                SoLuongNhap = int.Parse(reader["SoLuongNhap"].ToString()),
                                SoLuongTon = int.Parse(reader["SoLuongTon"].ToString()),
                                TongTienBan = float.Parse(reader["TongTienBan"].ToString()),
                                TongTienNhap = float.Parse(reader["TongTienNhap"].ToString()),
                                SoTienKhuyenMai = float.Parse(reader["SoTienKhuyenMai"].ToString()),
                                ChiPhiVanChuyen = float.Parse(reader["ChiPhiVanChuyen"].ToString()),
                                DoanhThu = float.Parse(reader["DoanhThu"].ToString()),
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
