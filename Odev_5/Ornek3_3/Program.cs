using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek3_3
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
        List<Calisan> calisanlar;
        public Sirket(string ad)
        {
            this.ad = ad;
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
        public string pozisyon { get; set; }

        public Calisan(string ad, string pozisyon)
        {
            this.ad = ad;
            this.pozisyon = pozisyon;
        }
        public void calisanBilgisi()
        {
            Console.WriteLine("Ad: "+ad);
        }
    }
}
