using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_2_3
{


    class SatrancTahtasi
    {
        private string[,] tahtadakiTaslar; // 8x8 satranç tahtası matrisi

        // Yapıcı metot: Satranç tahtasını başlatır
        public SatrancTahtasi()
        {
            tahtadakiTaslar = new string[8, 8]; // 8x8'lik satranç tahtası oluşturur
        }

        // İndeksleyici: Satranç tahtasındaki karelere erişim sağlar
        public string this[int satir, int sutun]
        {
            get
            {
                if (GecerliKareMi(satir, sutun)) // Geçerli kare kontrolü
                {
                    return tahtadakiTaslar[satir, sutun] ?? "Boş"; // Taşı döndür, yoksa "Boş" mesajı
                }
                else
                {
                    throw new IndexOutOfRangeException("Hata: Geçersiz kare!"); // Geçersiz kare hatası
                }
            }
            set
            {
                if (GecerliKareMi(satir, sutun)) // Geçerli kare kontrolü
                {
                    tahtadakiTaslar[satir, sutun] = value; // Taşı belirtilen kareye yerleştirir
                }
                else
                {
                    Console.WriteLine("Hata: Geçersiz kare!"); // Hata mesajı yazdırır
                }
            }
        }

        // Geçerli kare kontrolü
        private bool GecerliKareMi(int satir, int sutun)
        {
            return satir >= 0 && satir < 8 && sutun >= 0 && sutun < 8;
        }

        // Tahtadaki taşları listeleme metodu
        public void TahtaDurumu()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write($"{(tahtadakiTaslar[i, j] ?? "Boş"),-10} ");
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
