using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLysKhachSan
{
    class Room
    {
        private string maphong;
        private string tenphong;
        private string maloaiphong;
        private bool trangthai;

        public string Maphong { get => maphong; set => maphong = value; }
        public string Tenphong { get => tenphong; set => tenphong = value; }
        public string Maloaiphong { get => maloaiphong; set => maloaiphong = value; }
        public bool Trangthai { get => trangthai; set => trangthai = value; }

        public Room()
        {
            this.maphong = "";
            this.tenphong = "";
            this.maloaiphong = "";
            this.trangthai = false;
        }
    }
}
