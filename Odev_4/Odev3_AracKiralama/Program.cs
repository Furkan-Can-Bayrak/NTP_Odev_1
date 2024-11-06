using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3_AracKiralama
{

    class KiralikArac{

        private string plaka { get; set; }
        private decimal gunlukUcret { get; set; }
        private bool musaitMi { get; set; }

        public KiralikArac(string plaka, decimal gunlukUcret) {
            this.plaka = plaka;
            this.gunlukUcret = gunlukUcret;
            musaitMi = true;
        }

        public void araciKirala() {
            if (musaitMi)
            {
                musaitMi = false;
            }
            else {
                Console.WriteLine("Araç müsait değil");
            }
        }
        public void AraciTeslimEt()
        {
            if (!musaitMi) {
                musaitMi = true;
            }
            else
            {
                Console.WriteLine("Araç bizde teslim edilemez");
            }
        }

    }








    class Program
    {
        static void Main(string[] args)
        {

            KiralikArac kr = new KiralikArac("16AA432",300);
            kr.AraciTeslimEt();
            kr.araciKirala();
            kr.araciKirala();
            kr.AraciTeslimEt();
            kr.AraciTeslimEt();
            Console.ReadLine();
        }
    }
}
