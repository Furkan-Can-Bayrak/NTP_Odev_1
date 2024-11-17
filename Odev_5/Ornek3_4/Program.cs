using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek3_4
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Kutuphane
    {
        public string ad { get; set; }
        List<Kitap> kitaplar = new List<Kitap>();

        public Kutuphane(string ad)
        {
            this.ad = ad;
        }

        public void kitapEkle(Kitap k)
        {
            kitaplar.Add(k);
        }
    }

    class Kitap
    {
        public string baslik { get; set; }
        public string yazar { get; set; }

        public Kitap(string baslik, string yazar)
        {
            this.baslik = baslik;
            this.yazar = yazar;
        }
    }
}
