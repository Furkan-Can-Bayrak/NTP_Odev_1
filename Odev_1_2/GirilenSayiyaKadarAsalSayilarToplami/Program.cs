using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirilenSayiyaKadarAsalSayilarToplami
{
    class Program
    {
        static void Main(string[] args)
        {


            int sayi = Convert.ToInt32(Console.ReadLine());

            int toplam = 2;     //2 özel asal olduğu için direkt toplanarak yazıldı
            for (int i=3;i<sayi;i++)   //1 asal değil 2'yi de direkt topladığımız için 3ten başlayıp sayıya kadar götürdük
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)    //bölebilecek değerleri 2 den başlattık eğer kalansız bölerse sayı asal değildir
                {
                    if (i%j==0)
                    {
                        isPrime = false;
                        break;
                    }
                    
                }
                if (isPrime)
                {
                    toplam +=i;
                }
            }
            Console.Write(toplam);
            Console.ReadLine();


        }
    }
}
