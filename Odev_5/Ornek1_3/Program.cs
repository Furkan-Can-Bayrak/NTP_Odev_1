using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Calisan
    {
       public string ad { get; set; }
        public string pozisyon { get; set; }
        public Departman dep { get; set; }

        public Calisan(string ad, string pozisyon, Departman dep)
        {
            this.ad = ad;
            this.pozisyon = pozisyon;
            this.dep = dep;
        }

        public void depAtama(Departman dep) {
            this.dep = dep;
        }
    }

    class Departman
    {
        public string ad { get; set; }
        public string lokasyon { get; set; }

        public Departman(string ad, string lokasyon)
        {
            this.ad = ad;
            this.lokasyon = lokasyon;
        }
    }
}
