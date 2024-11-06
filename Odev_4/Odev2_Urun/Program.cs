using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2_Urun
{

    class Product {
        private string name;
        private decimal price;
        private decimal discount;


        public Product(string name, decimal price, decimal discount) {
            this.name = name;
            this.price = price;
            Discount = discount;
        }

        public decimal Discount {
            get { return discount; }
            set {
                if (value > 0 && value <= 50){
                    discount = value;
                }else {
                    throw new Exception();
                }
            }
        }

        public void indirimliFiyat() {
            decimal fiyat = price - (price / 100 * discount);
            Console.WriteLine("İndirimli fiyat: "+ fiyat);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Product pr1 = new Product("Kalem",100,10);
            pr1.indirimliFiyat();
            Console.ReadLine();
        }
    }
}
