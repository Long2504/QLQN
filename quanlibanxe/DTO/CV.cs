using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibanxe.DTO
{
    class CV
    {
        protected int macv;
        protected string tencv;

        public int Macv { get => macv; set => macv = value; }
        public string Tencv { get => tencv; set => tencv = value; }
        public CV(DataRow row)
        {
            this.macv = (int)row["MACV"];
            this.tencv = (string)row["tencv"];
        }
    }
}
