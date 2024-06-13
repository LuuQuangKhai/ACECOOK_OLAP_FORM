using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_KhuVuc
    {
        private DAO_KhuVuc dao;

        public BUS_KhuVuc() 
        {
            dao = new DAO_KhuVuc();
        }

        public List<DTO_KhuVuc> GetAll()
        {
            return dao.GetAll();
        }
    }
}
