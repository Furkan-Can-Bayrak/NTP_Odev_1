using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek2_5
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Ebeveyn
    {
        public string ad { get; set; }
        public int yas { get; set; }
        List<Cocuk> cocuklar;

        public Ebeveyn(string ad, int yas)
        {
            this.ad = ad;
            this.yas = yas;
            cocuklar = new List<Cocuk>();
        }

        public void cocukEkle(Cocuk c)
        {
            cocuklar.Add(c);
        }
    }
    class Cocuk
    {
        public string ad { get; set; }
        public int yas { get; set; }
        Ebeveyn ebeveyn;

        public Cocuk(string ad, int yas, Ebeveyn ebeveyn)
        {
            this.ad = ad;
            this.yas = yas;
            this.ebeveyn = ebeveyn;
            ebeveyn.cocukEkle(this);
        }
        public void ebeveynAtama(Ebeveyn e)
        {
            ebeveyn = e;
        }
    }
}
