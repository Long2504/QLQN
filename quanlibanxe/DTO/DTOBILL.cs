using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibanxe.DTO
{
    abstract class DTOBILL
    {
        protected string ma;
        protected DateTime ngay;
        protected int tongtien;
        protected string manv;
        public string Ma { get => ma; set => ma = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
        public string Manv { get => manv; set => manv = value; }
    }
}
