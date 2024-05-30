using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data.SqlClient;
using System.Data;

namespace BUS
{
    public class BUS_NhanVien
    {
        private DAO_NhanVien dao = new DAO_NhanVien();
        public BUS_NhanVien() { }

        public List<DTO_NhanVien> GetAll()
        {
            return dao.GetAll();
        }

        public DTO_NhanVien GetByID(string id)
        {
            return dao.GetByID(id);
        }

        public void Add(DTO_NhanVien dto)
        {
            dao.Add(dto);
        }

        public void Delete(string id)
        {
            dao.Delete(id);
        }

        public void Update(DTO_NhanVien dto)
        {
            dao.Update(dto);
        }
    }
}
