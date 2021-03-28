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
    class BLLBILLNHAP : DALBILLNHAP
    {
        public DataTable Getbillnhap()
        {
            return getbillnhap();
        }
        public bool Add(DTOBILLNHAP a)
        {
            return add(a);
        }
        public object Getnew()
        {
            return getnew();
        }
        public bool Delete(string a)
        {
            return delete(a);
        }
    }
}
