using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Odev1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan c;
            int secim =Convert.ToInt32(Console.ReadLine());
            if (secim ==0)
            {
                c = new Yazilimci();
                c.bilgiYazdir();
            }
            else if (secim == 1)
            {
                c = new Muhasebeci();
                c.bilgiYazdir();
            }
            Console.Read();
        }
    }


    class Calisan
    {
        string ad;
        string soyad;
        decimal maas;
        string pozisyon;

        public virtual void bilgiYazdir()
        {
            Console.WriteLine("Çalışan");
        }
    }

    class Yazilimci : Calisan
    {
        string yazilimDili;

        public override void bilgiYazdir()
        {
            Console.WriteLine("yazılım");
        }
    }


    class Muhasebeci : Calisan
    {
        string muhasebeYazilimi;


        public override void bilgiYazdir()
        {
            Console.WriteLine("muhasebe");
        }
    }


}
