using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek4_2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Bilgisayar{
        public string model { get; set; }
        Islemci islemci;

        public Bilgisayar(string model)
        {
            this.model = model;
            islemci =new Islemci(22,32);
        }
    }
    class Islemci
    {
        public int cekirdekler { get; set; }
        public int frekans { get; set; }

        public Islemci(int cekirdekler, int frekans)
        {
            this.cekirdekler = cekirdekler;
            this.frekans = frekans;
        }

        public void islemciBilgisi()
        {
            Console.WriteLine("frenkans: "+frekans);
        }
    }
}
