using quanlibanxe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibanxe.DAL
{
    class DALBILLBAN : connectsql
    {
        protected DataTable getbillban()
        {
            string query = "SELECT * FROM dbo.billxuat";
            return gettable(query);
        }
        protected bool add(DTOBILLBAN a)
        {
            string day = a.Ngay.ToString("yyyyMMdd");
            string query = string.Format("INSERT dbo.billxuat (ngay,  makh, manvxuat, tongtienxuat ) VALUES ( '{0}', '{1}','{2}', {3} )",day,a.Makh,a.Manv,a.Tongtien);
            return executenonquery(query);
        }
        protected object getmax()
        {
            string query = "SELECT MAX(MAXUAT) FROM dbo.billxuat";
            return getvalue(query);
        }
        protected bool delete(string a)
        {
            string query = string.Format("DELETE dbo.billxuat WHERE MAXUAT = '{0}'", a);
            return executenonquery(query);
        }
    }
}
