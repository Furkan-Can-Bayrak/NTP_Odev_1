using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek2_3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Yazar
    {
        public string ad { get; set; }
        public string ulke { get; set; }
        List<Kitap> kitaplar;

        public Yazar(string ad, string ulke)
        {
            this.ad = ad;
            this.ulke = ulke;
            kitaplar = new List<Kitap>();
        }

        public void kitapEkle(Kitap k)
        {
            kitaplar.Add(k);
        }
    }

    class Kitap
    {
        public string baslik { get; set; }
        public DateTime yayınTarihi{ get; set; }
        public Yazar yazar{ get; set; }

        public Kitap(string baslik, DateTime yayınTarihi, Yazar yazar)
        {
            this.baslik = baslik;
            this.yayınTarihi = yayınTarihi;
            this.yazar = yazar;
            yazar.kitapEkle(this);
        }

        public void yazarAtama(Yazar y)
        {
            yazar = y;
        }
    }
}
