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
    class BLLINFORBILLBAN : DALINFORBILLBAN
    {
        public DataTable Getinforbillban(string id)
        {
            return getinforbillban(id);
        }
        public bool Add(DTOINFORBILLBAN a,int t)
        {
            return add(a,t);
        }
    }
}
