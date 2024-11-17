using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_4
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Urun
    {
        public string ad { get; set; }
        public int fiyat { get; set; }

        public Urun(string ad, int fiyat)
        {
            this.ad = ad;
            this.fiyat = fiyat;
        }

        public void urunBilgisi()
        {
            Console.WriteLine("ad: " + ad+"\nFiyat: "+fiyat);
        }
    }

    class Siparis
    {
        public DateTime tarih;
        public decimal toplam;
        List<Urun> urunler = new List<Urun>();

        public Siparis(DateTime tarih, decimal toplam)
        {
            this.tarih = tarih;
            this.toplam = toplam;
        }
    }
}
