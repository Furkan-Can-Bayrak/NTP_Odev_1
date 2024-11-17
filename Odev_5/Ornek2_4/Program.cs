using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek2_4
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    class Sirket
    {
        public string ad { get; set; }
        public string konum { get; set; }
        List<Calisan> calisanlar;

        public Sirket(string ad, string konum)
        {
            this.ad = ad;
            this.konum = konum;
            calisanlar = new List<Calisan>();
        }
        public void calisanEkle(Calisan c)
        {
            calisanlar.Add(c);
        }
    }

    class Calisan
    {
        public string ad { get; set; }
        public Sirket sirket { get; set; }

        public Calisan(string ad, Sirket sirket)
        {
            this.ad = ad;
            this.sirket = sirket;
            sirket.calisanEkle(this);
        }

        public void sirketAtama(Sirket s)
        {
            sirket = s;
        }
    }
}
