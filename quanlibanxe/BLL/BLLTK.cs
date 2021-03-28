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
    class BLLTK : DALTKcs
    {
        public DataTable Gettk()
        {
            return gettk();
        }
        public bool Add(ACC a)
        {
            return add(a);
        }
        public bool Update(ACC a)
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
    }
}
