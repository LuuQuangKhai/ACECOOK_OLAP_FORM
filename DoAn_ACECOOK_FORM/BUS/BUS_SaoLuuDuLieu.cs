using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BUS_SaoLuuDuLieu
    {
        private DAO_SaoLuuDuLieu dao = new DAO_SaoLuuDuLieu();
        public BUS_SaoLuuDuLieu() { }

        public string SaoLuuDuLieu(string duongDan, string tenCSDL, string tenFile)
        {
            return dao.SaoLuuDuLieu(duongDan,tenCSDL,tenFile);
        }

        public string PhucHoiDuLieu(string duongDanPhucHoi, string tenCSDL)
        {
            return dao.PhucHoiDuLieu(duongDanPhucHoi, tenCSDL);
        }
    }
}
