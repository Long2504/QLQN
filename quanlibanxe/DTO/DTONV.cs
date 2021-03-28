using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibanxe.DTO
{
    class DTONV 
    {
        private int macv;
        private string tencv;
        private string manv;
        private string tennv;
        private DateTime ngaysinh;
        private int gioitinh;
        private int sdt;
        private string diachi;
        private int luong;
        private int trangthai;
        private string email;
        public int Macv { get => macv; set => macv = value; }
        public string Tencv { get => tencv; set => tencv = value; }

        public string Manv { get => manv; set => manv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public int Gioitinh { get => gioitinh; set => gioitinh = value; }
        public int Sdt { get => sdt; set => sdt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public int Luong { get => luong; set => luong = value; }
        public int Trangthai { get => trangthai; set => trangthai = value; }
        public string Email { get => email; set => email = value; }

        public DTONV() { }
        public DTONV(string a,string b,DateTime c,int d,int e,string f,int h,int k,string g,int m)
        {
            this.manv = a;
            this.tennv = b;
            this.ngaysinh = c;
            this.gioitinh = d;
            this.sdt = e;
            this.diachi = f;
            this.luong = h;
            this.trangthai = k;
            this.Email = g;
            this.macv = m;
        }
    }
}
