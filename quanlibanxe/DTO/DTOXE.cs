using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibanxe.DTO
{
    class DTOXE
    {
        private string maxe;
        private string tenxe;
        private string manhasx;
        private int soluong;
        private string mota;
        private string tnbh;
        private int giaban;

        public string Maxe { get => maxe; set => maxe = value; }
        public string Tenxe { get => tenxe; set => tenxe = value; }
        public string Manhasx { get => manhasx; set => manhasx = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public string Mota { get => mota; set => mota = value; }
        public string Tnbh { get => tnbh; set => tnbh = value; }
        public int Giaban { get => giaban; set => giaban = value; }

        public DTOXE() { }
        public DTOXE(string ma,string ten,string nhasx,string mt,string ttbh,int giabn)
        {
            this.maxe = ma;
            this.tenxe = ten;
            this.manhasx = nhasx;
            this.mota = mt;
            this.tnbh = ttbh;
            this.giaban = giabn;
        }
        public DTOXE(DataRow row)
        {
            this.maxe = (string)row["MAXE"];
            this.tenxe = (string)row["tenxe"];
            this.manhasx = (string)row["manhasx"];
            this.mota = (string)row["mota"];
            this.tnbh = (string)row["thongtinbaohanh"];
            this.giaban = (int)row["giaban"];
            this.soluong = (int)row["soluong"];
        }
    }
}
