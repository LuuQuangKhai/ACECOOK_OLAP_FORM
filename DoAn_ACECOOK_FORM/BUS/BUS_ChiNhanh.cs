using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class BUS_ChiNhanh
    {
        private DAO_ChiNhanh dao;

        public BUS_ChiNhanh()
        {
            dao = new DAO_ChiNhanh();
        }

        public List<DTO_ChiNhanh> GetAllByID(string makhuvuc)
        {
            return dao.GetAllByID(makhuvuc);
        }
    }
}
