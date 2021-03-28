using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibanxe.DTO
{
    class DTOKH
    {
        private string makh;
        private string tenkh;
        private string diachi;
        private int sdt;
        private string email;

        public string Makh { get => makh; set => makh = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public int Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public DTOKH() { }
        public DTOKH(string ten,string dc,int dt,string mail)
        {
            this.tenkh = ten;
            this.diachi = dc;
            this.sdt = dt;
            this.email = mail;
        }
    }
}
