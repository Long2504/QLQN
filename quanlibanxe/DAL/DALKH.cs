using quanlibanxe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibanxe.DAL
{
    class DALKH : connectsql
    {
        protected DataTable getkh()
        {
            string query = " SELECT * FROM KHACHHANG";
            return gettable(query);
        }
        protected bool update(DTOKH a)
        {
            string query = string.Format("UPDATE dbo.KHACHHANG SET tenkh='{0} ',diachi='{1} ',sdt={2},email='{3}' WHERE MAKH='{4}'", a.Tenkh, a.Diachi, a.Sdt, a.Email, a.Makh);
                return executenonquery(query);
        }
        protected bool delete(string a)
        {
            string query = string.Format("DELETE dbo.KHACHHANG WHERE MAKH = '{0}'",a);
            return executenonquery(query);
        }
        protected DataTable search(string a)
        {
            string query = string.Format("SELECT * FROM dbo.KHACHHANG WHERE tenkh LIKE'%{0}%'", a);
            return gettable(query);
        }
        protected bool add(DTOKH a)
        {
            string query = string.Format("INSERT dbo.KHACHHANG (tenkh,diachi,sdt,email) VALUES ( N'{0},', N'{1}',{2},'{3}')",a.Tenkh,a.Diachi,a.Sdt,a.Email);
            return executenonquery(query);
        }
        protected object getmax()
        {
            string query = "SELECT MAX(MAKH) FROM dbo.KHACHHANG";
            return getvalue(query);
        }
    }
}
