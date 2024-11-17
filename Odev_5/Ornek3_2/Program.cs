using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek3_2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Ev
    {
        public string ad { get; set; }
        List<Oda> odalar;

        public Ev(string ad, List<Oda> odalar)
        {
            this.ad = ad;
            odalar = new List<Oda>();
        }

        public void odaEkle(Oda oda)
        {
            odalar.Add(oda);
        }
    }
    class Oda
    {
        public string oda { get; set; }
        public string tip { get; set; }

        public Oda(string oda, string tip)
        {
            this.oda = oda;
            this.tip = tip;
        }
    }
}
