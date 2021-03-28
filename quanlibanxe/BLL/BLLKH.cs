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
    class BLLKH : DALKH
    {
        public DataTable Getkh()
        {
            return getkh();
        }
        public bool Update(DTOKH a)
        {
            return update(a);
        }
        public bool Delete(string a)
        {
            return delete(a);
        }
        public DataTable Search(string a)
        {
            return search(a);
        }
        public bool Add(DTOKH a)
        {
            return add(a);
        }
        public object Getmax()
        {
            return getmax();
        }
    }
}
