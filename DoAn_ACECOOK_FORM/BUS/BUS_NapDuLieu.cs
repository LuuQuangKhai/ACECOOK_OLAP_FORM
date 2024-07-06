using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BUS_NapDuLieu
    {
        private DAO_NapDuLieu dao;

        public BUS_NapDuLieu() 
        {
            dao = new DAO_NapDuLieu();
        }

        public string ExecuteSSIS(string tenjobs)
        {
            return dao.ExecuteSSIS(tenjobs);
        }
    }
}
