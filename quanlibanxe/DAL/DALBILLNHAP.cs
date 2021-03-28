using quanlibanxe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibanxe.DAL
{
    class DALBILLNHAP : connectsql
    {
        protected DataTable getbillnhap()
        {
            string query = "SELECT * FROM dbo.billnhap ";
            return gettable(query);
        }
        protected bool add(DTOBILLNHAP a)
        {
            string day = a.Ngay.ToString("yyyyMMdd");
            string query = string.Format("INSERT dbo.billnhap (manvnhap, manhasx, ngay, tongtiennhap ) VALUES ( '{0}', '{1}','{2}', {3} )", a.Manv,a.Manhasx,day,a.Tongtien);
            return executenonquery(query);
        }
        protected object getnew()
        {
            string query = "SELECT MAX(MANHAP) FROM dbo.billnhap";
            return getvalue(query);
        }
        protected bool delete(string a)
        {
            string query = string.Format("DELETE dbo.billnhap WHERE MANHAP = '{0}'", a);
            return executenonquery(query);
        }
    }
}
