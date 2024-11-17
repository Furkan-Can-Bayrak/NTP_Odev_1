using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek2_2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Doktor
    {
        public string ad { get; set; }
        public string brans { get; set; }
        List<Hasta> hastalar;

        public Doktor(string ad, string brans)
        {
            this.ad = ad;
            this.brans = brans;
            hastalar = new List<Hasta>();
        }

        public void hastaEkle(Hasta h)
        {
            hastalar.Add(h);
            h.doktorAtama(this);
        }
    }

    class Hasta
    {
        public string ad { get; set; }
        public string tc { get; set; }
        public Doktor doktor { get; set; }


        public void doktorAtama(Doktor d)
        {
            doktor = d;
        }
    }
}
