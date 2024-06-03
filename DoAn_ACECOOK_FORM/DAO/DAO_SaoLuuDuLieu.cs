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

                    return "Backup " + tenFile + " thành công!";
                }
            }
            catch (Exception ex)
            {
                return "Lỗi trong quá trình backup: " + ex.Message;
            }
        }
    }
}
