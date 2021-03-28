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
    class BLLXE : DALXE
    {
        public DataTable Getxe()
        {
            return getxe();
        }
        public bool Add(DTOXE a)
        {
            return add(a);
        }
        public bool Update(DTOXE a)
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
        public List<DTOXE> listxe(string b)
        {
            List<DTOXE> xe = new List<DTOXE>();
            DataTable data = getxebynhasx(b);
            foreach(DataRow item in data.Rows)
            {
                DTOXE a = new DTOXE(item);
                xe.Add(a);
            }
            return xe;
        }
    }
}
