using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek4_3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Otomobil
    {
        public string marka { get; set; }
        public Motor motor { get; set; }

        public Otomobil(string marka)
        {
            this.marka = marka;
            motor = new Motor(300,"tip");
        }
    }

    class Motor
    {
        public int guc { get; set; }
        public string tip { get; set; }

        public Motor(int guc, string tip)
        {
            this.guc = guc;
            this.tip = tip;
        }
        public void motorBilgisi()
        {
            Console.WriteLine("Güç: "+guc);
        }
    }
}
