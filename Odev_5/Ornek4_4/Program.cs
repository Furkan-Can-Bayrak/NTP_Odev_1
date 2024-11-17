using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek4_4
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Okul
    {
        public string ad { get; set; }
        List<Ogrenci> ogrenciler;

        public Okul(string ad)
        {
            this.ad = ad;
            ogrenciler = new List<Ogrenci>();
        }
        public void ogrenciOlustur(string ad,int yas)
        {
            ogrenciler.Add(new Ogrenci(ad,yas));
        }
    }

    class Ogrenci
    {
        public string ad { get; set; }
        public int yas { get; set; }

        public Ogrenci(string ad, int yas)
        {
            this.ad = ad;
            this.yas = yas;
        }

        public void ogrenciBilgisi()
        {
            Console.WriteLine("ad:"+ad);
        }
    }
}
