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
    class BLLNV : DALNV
    {
        public DataTable Getnv()
        {
            return getnv();
        }
        public bool Add(DTONV a)
        {
            return add(a);
        }
        public bool Update(DTONV a)
        {
            return update(a);
        }
        public DataTable Search(string a)
        {
            return search(a);
        }
        public List<CV> listcv()
        {
            List<CV> cv = new List<CV>();
            DataTable data = getcv();
            foreach (DataRow item in data.Rows)
            {
                CV a = new CV(item);
                cv.Add(a);
            }
            return cv;
        }
    }
}
