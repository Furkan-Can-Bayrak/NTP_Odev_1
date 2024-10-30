using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrtVeMedyan_Odev2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> sayilar = new List<int>();        //Dinamik bir şekilde tutacğımız için array yerine list oluşturduk


            Console.Write("Bir pozitif sayı girin(0 girilince biter): ");    //Pozitif sayı girmesini istiyoruz
            
            int n = Convert.ToInt32(Console.ReadLine());    //Girilen değeri aldık
            if (n<0) {                                      //Değer 0dan küçük ise tekrar değer girmesini istedik
                Console.Write("Negatif sayı girdiniz. Pozitif sayı girin: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n!=0) {          //Değer eğer 0 ise döngüye girmiyor.

                sayilar.Add(n);     //sayiyi listeye ekledik

                Console.Write("Bir pozitif sayı daha girin(0 girilince biter): ");   //Sayı girmesini tekrar istiyoruz
                n = Convert.ToInt32(Console.ReadLine());        //Sayıyı aldık
                if (n < 0) {                                    //Değer 0dan küçük ise tekrar değer istiyoruz
                    Console.Write("Negatif sayı girdiniz. Pozitif sayı girin: ");
                    n = Convert.ToInt32(Console.ReadLine());
                }
            }

            double toplam = sayilar.Sum();          //Tüm değerleri topladık
            int uzunluk = sayilar.Count;            //Kaç tane sayı var diye liste uzunluğunu aldık
            double ort = toplam / uzunluk;          //ortalama için toplam değer sayı adetine böldük


            sayilar.Sort();     //Sayıları sıralayan hazır fonksiyon
            double medyan = 0;      //medyana default değer 0 verdik
            if (uzunluk % 2 == 0)       // Eğer liste çift sayılı ise 
            {
                int mid = uzunluk / 2;              //Uzunluğunun ortasını bulduk
                double val1 = sayilar[mid];         //ortasını ve bir arkasındakini alıyoruz
                double val2 = sayilar[mid-1];
                medyan = (val1 + val2) / 2;         //Bu iki değeri toplayıp ikiye bölüyoruz.
            }else {
                int mid = uzunluk / 2;              //Uzunluğunun ortasını bulduk
                medyan = sayilar[mid];              //direkt ortayı veriyor
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Ortalama: "+ort);        //Ortalamayı yazdırır
            Console.WriteLine("Medyan: "+medyan);       //Medyanı yazdırır


            Console.Read();

        }
    }
}
