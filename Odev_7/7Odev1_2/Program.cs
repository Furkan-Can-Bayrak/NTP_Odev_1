using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Odev1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hayvan c;
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 0)
            {
                c = new Memeli();
                c.sesCikar();
            }
            else if (secim == 1)
            {
                c = new Kus();
                c.sesCikar();
            }
            Console.Read();
        }
    }




    class Hayvan
    {
        string ad;
        string tur;
        int yas;


        public virtual void sesCikar() {


        }
    }

    class Memeli : Hayvan
    {
        string tuyRengi;

        public override void sesCikar()
        {
            Console.WriteLine("memeli sesi");
        }
    }

    class Kus : Hayvan
    {
        int kanatGenisligi;

        public override void sesCikar()
        {
            Console.WriteLine("cik cik");
        }
    }
}
