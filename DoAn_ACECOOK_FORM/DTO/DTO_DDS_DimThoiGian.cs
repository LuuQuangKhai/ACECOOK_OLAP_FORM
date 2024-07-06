using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DDS_DimThoiGian
    {
        public int MaThoiGian { get; set; }
        public int Quy { get; set; }
        public int Ngay { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public DateTime NgayDatHang { get; set; }
    }
}
