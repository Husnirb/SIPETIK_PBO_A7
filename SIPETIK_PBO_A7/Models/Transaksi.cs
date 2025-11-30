using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPETIK_PBO_A7.Models
{
    public class Transaksi
    {
        public int TransaksiId { get; set; }
        public string StatusTransaksi { get; set; }
        public int Kuantitas { get; set; }
        public int TotalHarga { get; set; }
        public DateTime TanggalTransaksi { get; set; }
        public int TiketId { get; set; }
        public int UserId { get; set; }
    }
}
