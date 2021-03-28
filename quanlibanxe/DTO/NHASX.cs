using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibanxe.DTO
{
    class NHASX 
    {
        private string ma;
        private string ten;
        private string email;
        private int sdt;

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Email { get => email; set => email = value; }
        public int Sdt { get => sdt; set => sdt = value; }
        public NHASX() { }
        public NHASX(string manhasx,string tennhasx,string emailnhasx, int sdtnhasx)
        {
            this.ma = manhasx;
            this.ten = tennhasx;
            this.email = emailnhasx;
            this.sdt = sdtnhasx;
        }
        public NHASX(DataRow row)
        {
            this.ma = (string)row["MANHASX"];
            this.ten = (string)row["tennhasx"];
            this.email = (string)row["email"];
            this.sdt = (int)row["sdt"];
        }
    }
}
