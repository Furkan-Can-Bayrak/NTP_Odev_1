using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev4_Adres
{

    class Kisi {

        private string name;
        private string surname;
        private string number;



        public Kisi(string name, string surname, string number) {
            this.name = name;
            this.surname = surname;
            this.number = number;
        }

        public void kisiBilgisi() {
            Console.WriteLine("İsim\t:" + name+" "+surname+ "\nTel no\t:" + number);
        }

    }




    class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi = new Kisi("Hikmet","Meyve","3423");
            kisi.kisiBilgisi();
            Console.ReadLine();
        }
    }
}
