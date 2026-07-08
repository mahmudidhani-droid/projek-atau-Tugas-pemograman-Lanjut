using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemInventarisKavling.Domain
{
    public class Kavling
    {
        public string Id { get; set; }

        public string Nama { get; set; }

        public string Bentuk { get; set; }

        public double Panjang { get; set; }

        public double Lebar { get; set; }

        public double Luas { get; set; }

        public decimal Harga { get; set; }

        public string Status { get; set; }
    }
}
