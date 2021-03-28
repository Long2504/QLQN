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
    class BLLNHASX : DALNHASX
    {
        public DataTable Getnhasx()
        {
            return getnhasx();
        }
        public bool ADD(NHASX a)
        {
            return add(a);
        }
        public bool Update(NHASX a)
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
        public List<NHASX> listnhasx()
        {
            List<NHASX> nhasx = new List<NHASX>();
            DataTable data = getnhasx();
            foreach(DataRow item in data.Rows)
            {
                NHASX a = new NHASX(item);
                nhasx.Add(a);
            }
            return nhasx;
        }
    }
}
