using SIPETIK_PBO_A7.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPETIK_PBO_A7.Models
{
    public class Tiket
    {
        public int TiketId { get; set; }
        public string NamaTiket { get; set; }
        public int Harga { get; set; }
        public int Stok { get; set; }

        public Tiket() { }

        public Tiket(int id, string nama, int harga, int jumlah)
        {
            TiketId = id;
            NamaTiket = nama;
            Harga = harga;
            Stok = jumlah;
        }
    }
}
