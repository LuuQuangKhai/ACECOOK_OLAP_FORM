using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class BUS_QuyenDuocCap
    {
        private DAO_QuyenDuocCap dao = new DAO_QuyenDuocCap();
        public BUS_QuyenDuocCap() { }

        public List<DTO_QuyenDuocCap> GetAllByID(string id)
        {
            return dao.GetAllByID(id);
        }

        public DTO_QuyenDuocCap GetByID(string manhanvien,int maquyen)
        {
            return dao.GetByID(manhanvien, maquyen);
        }

        public void Add(DTO_QuyenDuocCap dto)
        {
            dao.Add(dto);
        }

        public void Delete(DTO_QuyenDuocCap dto)
        {
            dao.Delete(dto);
        }
    }
}
