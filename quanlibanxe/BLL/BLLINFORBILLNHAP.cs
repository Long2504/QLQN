using quanlibanxe.DAL;
using quanlibanxe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibanxe.BLL
{
    class BLLINFORBILLNHAP : DALINFORBILLNHAP
    {
        public DataTable Getinforbillnhap(string a)
        {
            return getinforbillnhap(a);
        }
        public bool Add(DTOINFORBILLNHAP a,int t)
        {
            return add(a,t);
        }
    }
}
