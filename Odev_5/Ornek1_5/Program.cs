using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_5
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Siparis
    {
        public DateTime tarih;
        public string durum;
        

        public Siparis(DateTime tarih, string durum)
        {
            this.tarih = tarih;
            this.durum = durum;
        }
    }

    class Musteri
    {
        public string ad { get; set; }
        public string telefon { get; set; }
        List<Siparis> siparisler = new List<Siparis>();

        public void siparisVer(Siparis s)
        {
            siparisler.Add(s);
        }
    }
}
