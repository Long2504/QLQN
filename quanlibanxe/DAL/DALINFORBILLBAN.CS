using quanlibanxe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibanxe.DAL
{
    class DALINFORBILLBAN : connectsql
    {
        protected DataTable getinforbillban(string id)
        {
            string query = string.Format("SELECT * FROM dbo.billxuatinfor WHERE MAXUAT = '{0}' ", id);
            return gettable(query);
        }
        protected bool add(DTOINFORBILLBAN a,int t)
        {
            string query = string.Format("INSERT dbo.billxuatinfor (MAXUAT,manhasx,soluong,tongtien,maxe) VALUES ( '{4}', '{0}', {1}, {2}, '{3}')", a.Manhasx, a.Soluong, t, a.Maxe,a.Ma);
            return executenonquery(query);
        }
    }
}
