using quanlibanxe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibanxe.DAL
{
    class DALINFORBILLNHAP : connectsql
    {
        protected DataTable getinforbillnhap(string a)
        {
            string query = "SELECT * FROM dbo.billnhapinfor WHERE NHANHAP = '"+a+" '";
            return gettable(query);
        }
        protected bool add(DTOINFORBILLNHAP a,int t)
        {
            string query = string.Format("INSERT dbo.billnhapinfor (MANHAP,soluong,tongtien,maxe) VALUES ( '{3}',  {0}, {1}, '{2}')",  a.Soluong, t, a.Maxe, a.Ma);
            return executenonquery(query);
        }
    }
}
