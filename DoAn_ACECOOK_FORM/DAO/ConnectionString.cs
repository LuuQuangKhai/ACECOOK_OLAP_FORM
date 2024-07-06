using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ConnectionString
    {
        public string myConnectionString = "Data Source=LUUQUANGKHAI\\KHAISERVER;Initial Catalog=DB_ACECOOK_FORM;User ID=sa;Password=123;Integrated Security=False;TrustServerCertificate=True;";

        public string myConnectionString_web = "Data Source=LUUQUANGKHAI\\KHAISERVER;Initial Catalog=DB_ACECOOK_WEB;User ID=sa;Password=123;Integrated Security=False;TrustServerCertificate=True;";

        public string myConnectionString_NDS = "Data Source=LUUQUANGKHAI\\KHAISERVER;Initial Catalog=DB_ACECOOK_NDS;User ID=sa;Password=123;Integrated Security=False;TrustServerCertificate=True;";

        public string myConnectionString_DDS = "Data Source=LUUQUANGKHAI\\KHAISERVER;Initial Catalog=DB_ACECOOK_DDS;User ID=sa;Password=123;Integrated Security=False;TrustServerCertificate=True;";

        public string mySSASconnectionString = @"Provider=MSOLAP;Data Source=LUUQUANGKHAI\KHAISERVER;Initial Catalog=cube;Integrated Security=SSPI";

    }
}
