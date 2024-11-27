using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_1_1
{
    class Program
    {

        class MatematikselIslemler
        {
            // İlk sürüm: İki tam sayı toplar
            public int Topla(int a, int b)
            {
                return a + b; // İki sayının toplamını döndürür
            }

            // İkinci sürüm: Üç tam sayı toplar
            public int Topla(int a, int b, int c)
            {
                return a + b + c; // Üç sayının toplamını döndürür
            }

            // Üçüncü sürüm: Bir dizi tam sayı toplar
            public int Topla(int[] sayilar)
            {
                int toplam = 0; // Başlangıç değeri
                foreach (int sayi in sayilar) // Her bir sayıyı döngüyle toplar
                {
                    toplam += sayi; // Toplama işlemi
                }
                return toplam; // Dizideki tüm sayıların toplamını döndürür
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
