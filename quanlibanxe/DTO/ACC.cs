using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibanxe.DTO
{
    class ACC
    {
        private string manv;
        private string tentk;
        private string mk;
        private string tenht;

        public string Manv { get => manv; set => manv = value; }
        public string Tentk { get => tentk; set => tentk = value; }
        public string Mk { get => mk; set => mk = value; }
        public string Tenht { get => tenht; set => tenht = value; }

        public ACC() { }
        public ACC(string a,string b,string c,string d)
        {
            this.manv = a;
            this.tentk = b;
            this.mk = c;
            this.tenht = d;
        }
    }
}
