using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Microsoft.SqlServer.Management.IntegrationServices;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.XEvent;
using System.Diagnostics;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo.Agent;

namespace DAO
{
    public class DAO_NapDuLieu : ConnectionString
    {
        public DAO_NapDuLieu()
        { }

        public string ExecuteSSIS(string tenjobs)
        {
            try
            {
                // Kết nối tới SQL Server
                ServerConnection conn = new ServerConnection(@"LUUQUANGKHAI\KHAISERVER");
                Server server = new Server(conn);

                // Lấy đối tượng job từ SQL Server
                Job job = server.JobServer.Jobs[tenjobs];

                // Chạy job
                job.Start();

                return "Chạy thành công.";
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ chung
                return "Chạy thất bại!";
            }
        }
    }
}
