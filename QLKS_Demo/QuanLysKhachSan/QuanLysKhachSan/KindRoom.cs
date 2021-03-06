using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLysKhachSan
{
    class KindRoom
    {
        private string maloaiphong;
        private string mota;
        private decimal dongia;

        public string Maloaiphong { get => maloaiphong; set => maloaiphong = value; }
        public string Mota { get => mota; set => mota = value; }
        public decimal Dongia { get => dongia; set => dongia = value; }
        public KindRoom ()
        {
            this.maloaiphong = "";
            this.dongia = 0;
            this.mota = "";
        }
    }
}
