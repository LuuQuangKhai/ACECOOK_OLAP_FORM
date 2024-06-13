using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_SaoLuuDuLieu : ConnectionString
    {
        public DAO_SaoLuuDuLieu() { }

        public string SaoLuuDuLieu(string duongDan, string tenCSDL,string tenFile)
        {
            string backupPath = $"{duongDan}\\{tenFile}.bak";

            try
            {
                using (SqlConnection connection = new SqlConnection(myConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand($"BACKUP DATABASE {tenCSDL} TO DISK = '{backupPath}';", connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    return "Sao lưu dữ liệu thành công!";
                }
            }
            catch (Exception ex)
            {
                return "Lỗi trong quá trình sao lưu: " + ex.Message;
            }
        }

        public string PhucHoiDuLieu(string duongDanPhucHoi, string tenCSDL)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(myConnectionString))
                {
                    connection.Open();
                    
                    using (SqlCommand command = new SqlCommand($"ALTER DATABASE {tenCSDL} SET SINGLE_USER WITH ROLLBACK IMMEDIATE;", connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    using (SqlCommand command = new SqlCommand($"USE MASTER RESTORE DATABASE {tenCSDL} FROM DISK = '{duongDanPhucHoi}' WITH REPLACE;", connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    using (SqlCommand command = new SqlCommand($"ALTER DATABASE {tenCSDL} SET MULTI_USER;", connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    return "Phục hồi dữ liệu thành công!";
                }
            }
            catch (Exception ex)
            {
                return "Lỗi trong quá trình phục hồi: " + ex.Message;
            }
        }
    }
}
