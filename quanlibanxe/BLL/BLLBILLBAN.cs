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
    class BLLBILLBAN : DALBILLBAN
    {
        public DataTable Getbillban()
        {
            return getbillban();
        }
        public bool Add(DTOBILLBAN a)
        {
            return add(a);
        }
        public object Getmax()
        {
            return getmax();
        }
        public bool Delete(string a)
        {
            return delete(a);
        }
    }
}
