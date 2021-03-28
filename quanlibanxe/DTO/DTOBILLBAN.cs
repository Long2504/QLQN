using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibanxe.DTO
{
    class DTOBILLBAN : DTOBILL
    {
        private string makh;
        private string tenkh;
        public string Makh { get => makh; set => makh = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }

        public DTOBILLBAN(DateTime b,int c,string d,string a)
        {
            this.ngay = b;
            this.tongtien = c;
            this.makh = d;
            this.manv = a;
        }
    }
}
