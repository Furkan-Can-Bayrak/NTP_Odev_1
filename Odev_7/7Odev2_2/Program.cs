using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Odev2_2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    abstract class Urun
    {
        string ad;
         public decimal fiyat;

        public abstract void hesaplaOdeme();
        public abstract void bilgiYazdir();
    }

    class Kitap : Urun
    {
        int sayfaSayisi;

        public override void hesaplaOdeme()
        {
            Console.WriteLine(fiyat + (fiyat /10));
        }
        public override void bilgiYazdir()
        {
            Console.WriteLine("Gerekli bilgiler yazdırıldı kitap");
        }
    }

    class Elektronik : Urun
    {
        public override void hesaplaOdeme()
        {
            Console.WriteLine(fiyat + (fiyat / 4));
        }
        public override void bilgiYazdir()
        {
            Console.WriteLine("Gerekli bilgiler yazdırıldı elektornik");
        }
    }
}
