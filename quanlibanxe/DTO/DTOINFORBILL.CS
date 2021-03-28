using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibanxe.DTO
{
    abstract class DTOINFORBILL
    {
        protected string ma;
        protected string maxe;
        protected DateTime ngay;
        protected int soluong;
        protected int tongtien;

        public string Ma { get => ma; set => ma = value; }
        public string Maxe { get => maxe; set => maxe = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
    }
}
