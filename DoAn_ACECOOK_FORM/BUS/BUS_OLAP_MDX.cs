using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BUS_OLAP_MDX
    {
        private DAO_OLAP_MDX dao = new DAO_OLAP_MDX();

        public BUS_OLAP_MDX() { }

        public DataTable GetMDXData(string mdxQuery)
        {
            return dao.ExecuteMDXQuery(mdxQuery);
        }
    }
}
