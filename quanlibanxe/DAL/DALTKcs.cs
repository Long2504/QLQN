using quanlibanxe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibanxe.DAL
{
    class DALTKcs : connectsql
    {
        protected DataTable gettk()
        {
            string query = "SELECT * FROM dbo.account";
            return gettable(query);
        }
        protected bool add(ACC a)
        {
            string query = string.Format("INSERT dbo.account ( manv,tk, mk,tentk) VALUES ('{0}','{1}', '{2}', N'{3}')",a.Manv,a.Tentk,a.Mk,a.Tenht);
            return executenonquery(query);
        }
        protected bool update(ACC a)
        {
            string query = string.Format("UPDATE dbo.account SET tk='{1}',mk='{2}',tentk='{3}' WHERE manv='{0}'", a.Manv, a.Tentk, a.Mk, a.Tenht);
            return executenonquery(query);
        }
        protected bool delete(string a)
        {
            string query = string.Format("DELETE dbo.account WHERE manv = '{0}'",a);
            return executenonquery(query);
        }
        protected DataTable search(string a)
        {
            string query = string.Format("SELECT * FROM dbo.account WHERE tentk LIKE '%{0}%'",a);
            return gettable(query);
        }
    }
}
