using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_QuyenDuocCap : ConnectionString
    {
        public DAO_QuyenDuocCap() { }

        public List<DTO_QuyenDuocCap> GetAllByID(string manhanvien)
        {
            List<DTO_QuyenDuocCap> list = new List<DTO_QuyenDuocCap>();
            using (var connection = new SqlConnection(myConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM QuyenDuocCap WHERE MaNhanVien = @MaNV";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaNV", manhanvien);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dto = new DTO_QuyenDuocCap
                            {
                                MaNhanVien = reader["MaNhanVien"].ToString(),
                                MaQuyen = int.Parse(reader["MaQuyen"].ToString()),
                            };
                            list.Add(dto);
                        }
                    }
                }
            }
            return list;
        }

        public DTO_QuyenDuocCap GetByID(string manhanvien, int maquyen)
        {
            using (var connection = new SqlConnection(myConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM QuyenDuocCap WHERE MaNhanVien = @MaNV AND MaQuyen = @MaQuyen";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaNV", manhanvien);
                    command.Parameters.AddWithValue("@MaQuyen", maquyen);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var dto = new DTO_QuyenDuocCap
                            {
                                MaNhanVien = reader["MaNhanVien"].ToString(),
                                MaQuyen = int.Parse(reader["MaQuyen"].ToString()),
                            };
                            return dto;
                        }
                    }
                }
            }
            return null; 
        }


        public void Add(DTO_QuyenDuocCap dto)
        {
            using (var connection = new SqlConnection(myConnectionString))
            {
                connection.Open();
                string query = "INSERT INTO QuyenDuocCap (MaNhanVien, MaQuyen) VALUES (@MaNV, @MaQuyen)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaNV", dto.MaNhanVien);
                    command.Parameters.AddWithValue("@MaQuyen", dto.MaQuyen);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(DTO_QuyenDuocCap dto)
        {
            using (var connection = new SqlConnection(myConnectionString))
            {
                connection.Open();
                string query = "DELETE FROM QuyenDuocCap WHERE MaNhanVien = @MaNV AND MaQuyen = @MaQuyen";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaNV", dto.MaNhanVien);
                    command.Parameters.AddWithValue("@MaQuyen", dto.MaQuyen);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
