using quanlibanxe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibanxe.DAL
{
    class DALNV : connectsql
    {
        protected DataTable getnv()
        {
            string query = "SELECT MANV,tennv,namsinh,gioitinh,sdt,email,diachi,luong,trangthai,tencv FROM dbo.nhanvien,dbo.chucvu WHERE nhanvien.macv=chucvu.MACV";
            return gettable(query);
        }
        protected bool add(DTONV a)
        {
            string day = a.Ngaysinh.ToString("yyyyMMdd");
            string query = string.Format("INSERT dbo.nhanvien (tennv,namsinh,gioitinh, sdt, diachi,macv, luong,trangthai,email) VALUES (  N'{0}','{1}', {2}, {3}, N'{4}', {8},{5}, {6} ,' {7}' )",a.Tennv,day,a.Gioitinh,a.Sdt,a.Diachi,a.Luong,a.Trangthai,a.Email,a.Macv);
            return executenonquery(query);
        }
        protected bool update(DTONV a)
        {
            string day = a.Ngaysinh.ToString("yyyyMMdd");
            string query = string.Format("UPDATE dbo.nhanvien SET tennv='{1}',namsinh = '{2}', gioitinh= {3},sdt = {4},diachi='{5} ',macv= {9},luong ={6} , trangthai = {7}, email = '{8}' WHERE MANV = '{0}'", a.Manv, a.Tennv, day, a.Gioitinh, a.Sdt, a.Diachi, a.Luong, a.Trangthai, a.Email,a.Macv);
            return executenonquery(query);
        }
        protected DataTable search(string a)
        {
            string query = string.Format("SELECT MANV,tennv,namsinh,gioitinh,sdt,email,diachi,luong,trangthai,tencv FROM dbo.nhanvien,dbo.chucvu WHERE nhanvien.macv=chucvu.MACV AND tennv LIKE N'%{0}%'", a);
            return gettable(query);
        }
        protected DataTable getcv()
        {
            string query = "SELECT * FROM dbo.chucvu";
            return gettable(query);
        }
    }
}
