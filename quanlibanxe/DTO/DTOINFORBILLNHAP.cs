using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibanxe.DTO
{
    class DTOINFORBILLNHAP : DTOINFORBILL
    {
        public DTOINFORBILLNHAP(string a,  int c,string m)
        {
            this.maxe = a;
            this.soluong = c;
            this.ma = m;
        }
    }
}
