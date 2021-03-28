using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibanxe.DTO
{
    class DTOBILLNHAP : DTOBILL
    {
        private string manhasx;

        public string Manhasx { get => manhasx; set => manhasx = value; }
        public DTOBILLNHAP(DateTime a,int b,string c,string d)
        {
            this.ngay = a;
            this.tongtien = b;
            this.manv = c;
            this.manhasx = d;
        }
    }
}
