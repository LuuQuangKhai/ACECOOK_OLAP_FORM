using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DAO_NhanVien : ConnectionString
    {
        public DAO_NhanVien() { }

        public List<DTO_NhanVien> GetAll()
        {
            List<DTO_NhanVien> danhSachNhanVien = new List<DTO_NhanVien>();
            using (
                var connection = new SqlConnection(myConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM NhanVien";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var nhanVien = new DTO_NhanVien
                            {
                                MaNhanVien = reader["MaNhanVien"].ToString(),
                                TenNhanVien = reader["TenNhanVien"].ToString(),
                                Email = reader["Email"].ToString(),
                                SDT = reader["SDT"].ToString(),
                                CCCD = reader["CCCD"].ToString(),
                                MatKhau = reader["MatKhau"].ToString(),
                                DiaChi = reader["DiaChi"].ToString()
                            };
                            danhSachNhanVien.Add(nhanVien);
                        }
                    }
                }
            }
            return danhSachNhanVien;
        }

        public DTO_NhanVien GetByID(string maNhanVien)
        {
            using (var connection = new SqlConnection(myConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM NhanVien WHERE MaNhanVien = @MaNV";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaNV", maNhanVien);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new DTO_NhanVien
                            {
                                MaNhanVien = reader["MaNhanVien"].ToString(),
                                TenNhanVien = reader["TenNhanVien"].ToString(),
                                Email = reader["Email"].ToString(),
                                SDT = reader["SDT"].ToString(),
                                CCCD = reader["CCCD"].ToString(),
                                MatKhau = reader["MatKhau"].ToString(),
                                DiaChi = reader["DiaChi"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }

        public void Delete(string maNhanVien)
        {
            using (var connection = new SqlConnection(myConnectionString))
            {
                connection.Open();
                string query = "DELETE FROM NhanVien WHERE MaNhanVien = @MaNV";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaNV", maNhanVien);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Update(DTO_NhanVien nhanVien)
        {
            using (var connection = new SqlConnection(myConnectionString))
            {
                connection.Open();
                string query = "UPDATE NhanVien SET TenNhanVien = @TenNV, Email = @Email, SDT = @SDT, CCCD = @CCCD, MatKhau = @MatKhau, DiaChi = @DiaChi WHERE MaNhanVien = @MaNV";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaNV", nhanVien.MaNhanVien);
                    command.Parameters.AddWithValue("@TenNV", nhanVien.TenNhanVien);
                    command.Parameters.AddWithValue("@Email", nhanVien.Email);
                    command.Parameters.AddWithValue("@SDT", nhanVien.SDT);
                    command.Parameters.AddWithValue("@CCCD", nhanVien.CCCD);
                    command.Parameters.AddWithValue("@MatKhau", nhanVien.MatKhau);
                    command.Parameters.AddWithValue("@DiaChi", nhanVien.DiaChi);
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
