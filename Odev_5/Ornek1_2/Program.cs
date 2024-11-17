using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_2

{
    class Program
    {
        static void Main(string[] args)
        {
            Kitap k1 = new Kitap("Al yazmalım");
            Kitap k2 = new Kitap("Beyaz yazmalım");
            Yazar y = new Yazar();
            y.kitapEkle(k1);

            Console.Read();
        }
    }


    class Yazar{
        public string ad { get; set; }
        public string ulke { get; set; }
        List<Kitap> kitaplar = new List<Kitap>();

        public void kitapEkle(Kitap kitap) {
            kitaplar.Add(kitap);
            Console.WriteLine(kitap.baslik +" isimli kitap listeye eklendi");
        }

    }

    class Kitap
    {
        public string baslik { get; set; }
        public string isbn { get; set; }

        public Kitap(string baslik){
            this.baslik = baslik;
           
           
        }
    }
}
