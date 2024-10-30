using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdisikSayiGruplari_Odev3
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> sayilar = new List<int>();        //Dinamik bir şekilde tutacağımız için array yerine list oluşturduk


            Console.Write("Bir pozitif sayı girin(0 girilince biter): ");    //Pozitif sayı girmesini istiyoruz

            int n = Convert.ToInt32(Console.ReadLine());    //Girilen değeri aldık
            
            while (n != 0)      //0 girilince dizi için sayı alımı bitiyor
            {          

                sayilar.Add(n);     //sayiyi listeye ekledik

                Console.Write("Bir pozitif sayı daha girin(0 girilince biter): ");   //Sayı girmesini tekrar istiyoruz
                n = Convert.ToInt32(Console.ReadLine());        //Sayıyı aldık
            }

            sayilar.Sort();     //küçükten büyüğe sıraladık

            
            
            for (int i =0;i<sayilar.Count;i++) {                //Listeyi tek tek dönmesi için döngü başladı
                int start = i;      //başlangıç indisi i
                int end = 0;        //bitiş indisi 0 dedik bu değişirse ardışıklık vardır
                while (true) {      //ardışıklık var ise bu döngü içinde bitene kadar bulunsun
                    if (i != sayilar.Count - 1 && sayilar[i + 1] - sayilar[i] <= 1)     // listenin sınırlarını aşmamak için son indis mi diye kontrol ettik ve bir üstündeki indis ile aralarındaki farka baktık 1den küçük ise ardışıl demek
                    {
                        end = i+1;          //endin indisini belirledik
                        i++;                //i yi bir arttırdık daha ardışıllık var mı diye bakacağız
                    }
                    else {
                        break;          //ardışıllık yok ise döngü bozulsun ve asıl döngü devam etsin
                    }
                }
                if (end != 0)       //end 0dan farklı ise ardışıllık vardır konsola yazdıralım
                {
                    Console.WriteLine(sayilar[start] + "-" + sayilar[end]);
                }
            }

            Console.ReadLine();


        }
    }
}
