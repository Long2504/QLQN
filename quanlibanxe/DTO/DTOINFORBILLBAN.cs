using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace quanlibanxe.DTO
{
    class DTOINFORBILLBAN: DTOINFORBILL
    {
        private string tenkh;
        private string manhasx;

        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Manhasx { get => manhasx; set => manhasx = value; }
        public DTOINFORBILLBAN(string b,int d,string h,string a)
        {
            this.maxe = b;
            this.soluong = d;
            this.manhasx = h;
            this.ma = a;
        }
        public DTOINFORBILLBAN() { }
    }
}
