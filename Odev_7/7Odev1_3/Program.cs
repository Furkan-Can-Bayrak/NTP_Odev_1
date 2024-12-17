using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Odev1_3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    class Hesap
    {
        string hesapNumarasi;
        decimal bakiye;
        string sahip;

        public virtual void paraYatir()
        {

        }
        public virtual void paraCek()
        {

        }
        public virtual void bilgiYazdir()
        {

        }
    }

    class VadesizHesap : Hesap
    {
        int ekHesapLimiti;

        public override void paraYatir()
        {
            Console.WriteLine("vadesiz para yatırma");
        }
        public override void paraCek()
        {
            Console.WriteLine("Vadesiz para çekme");
        }

        class VadeliHesap : Hesap
    {
        int vadeSuresi;
        double faizOrani;

            public override void paraYatir()
            {
                Console.WriteLine("Vadeli para yatırma");
            }
            public override void paraCek()
            {
                Console.WriteLine("Vadeli para çekme");
            }
        }

    }
}
