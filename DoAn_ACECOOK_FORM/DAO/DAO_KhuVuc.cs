using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_KhuVuc : ConnectionString
    {
        public DAO_KhuVuc() { }

        public List<DTO_KhuVuc> GetAll()
        {
            List<DTO_KhuVuc> list = new List<DTO_KhuVuc>();
            using (
                var connection = new SqlConnection(myConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM KhuVuc";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var khuvuc = new DTO_KhuVuc
                            {
                                MaKhuVuc = reader["MaKhuVuc"].ToString(),
                                TenKhuVuc = reader["TenKhuVuc"].ToString(),
                            };
                            list.Add(khuvuc);
                        }
                    }
                }
            }
            return list;
        }
    }
}
