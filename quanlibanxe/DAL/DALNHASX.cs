using quanlibanxe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibanxe.DAL
{
    class DALNHASX : connectsql
    {
        protected DataTable getnhasx()
        {
            string query = "SELECT * FROM dbo.nhasx";
            return gettable(query);
        }
        protected bool add(NHASX a)
        {
            string query = string.Format("INSERT dbo.nhasx(MANHASX,tennhasx,email,sdt) VALUES( N'{0}', N'{1}', N'{2}', {3} )", a.Ma, a.Ten, a.Email, a.Sdt);
            return executenonquery(query);
        }
        protected bool update(NHASX a)
        {
            string query = string.Format("UPDATE dbo.nhasx SET tennhasx= '{1}',email = '{2}' , sdt='{3}' WHERE MANHASX ='{0}'", a.Ma, a.Ten, a.Email, a.Sdt);
            return executenonquery(query);
        }
        protected bool delete(string a)
        {
            string query = string.Format("DELETE dbo.nhasx WHERE MANHASX='{0}'", a);
            return executenonquery(query);
        }
        protected DataTable search(string a)
        {
            string query = string.Format("SELECT * FROM dbo.nhasx WHERE tennhasx LIKE '%{0}%'", a);
            return gettable(query);
        }
    }
}
