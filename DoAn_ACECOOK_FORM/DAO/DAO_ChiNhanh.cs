using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_ChiNhanh : ConnectionString
    {
        public DAO_ChiNhanh() { }

        public List<DTO_ChiNhanh> GetAllByID(string makhuvuc)
        {
            List<DTO_ChiNhanh> list = new List<DTO_ChiNhanh>();
            using (var connection = new SqlConnection(myConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM ChiNhanh WHERE MaKhuVuc = @MaKV";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaKV", makhuvuc);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dto = new DTO_ChiNhanh
                            {
                                MaChiNhanh = reader["MaChiNhanh"].ToString(),
                                TenChiNhanh = reader["TenChiNhanh"].ToString(),
                                SDTChiNhanh = reader["SDTChiNhanh"].ToString(),
                                DiaChi = reader["DiaChi"].ToString(),
                                MaKhuVuc = reader["MaKhuVuc"].ToString(),
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
