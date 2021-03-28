using quanlibanxe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibanxe.DAL
{
    class DALXE :connectsql
    {
        protected DataTable getxe()
        {
            string query = " SELECT * FROM dbo.XE";
            return gettable(query);
        }
        protected bool add(DTOXE a)
        {
            string query = string.Format("INSERT dbo.XE( tenxe,manhasx,soluong,thongtinbaohanh,mota,giaban) VALUES(N'{0}',N'{1}', 0,N'{2}', N'{3}',{4})", a.Tenxe, a.Manhasx, a.Tnbh, a.Mota,a.Giaban);
            return executenonquery(query);
        }
        protected bool update(DTOXE a)
        {
            string query = string.Format("UPDATE dbo.XE SET tenxe= '{0} ', thongtinbaohanh='{1} ',mota= '{2} ', giaban= {3},manhasx='{5}' WHERE MAXE = '{4} '",  a.Tenxe,  a.Tnbh, a.Mota, a.Giaban,a.Maxe,a.Manhasx);
                return executenonquery(query);
        }
        protected bool delete(string a)
        {
            string query = string.Format("DELETE dbo.XE WHERE MAXE= '{0}'",a);
            return executenonquery(query);
        }
        protected DataTable search(string a)
        {
            string query = string.Format("SELECT * FROM dbo.XE WHERE tenxe LIKE N'%{0}%'",a);
            return gettable(query);
        }
        protected DataTable getxebynhasx(string a)
        {
            string query = string.Format("SELECT * FROM dbo.XE WHERE manhasx = '{0}'", a);
            return gettable(query);
        }
    }
}
