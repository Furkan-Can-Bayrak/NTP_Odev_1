using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_2_4
{


    class Otopark
    {
        private string[,] parkYerleri; // Katmanları ve park yerlerini temsil eden iki boyutlu dizi

        // Yapıcı metot: Otopark katmanlarının ve her katın park yeri sayısını başlatır
        public Otopark(int katSayisi, int parkYeriSayisi)
        {
            parkYerleri = new string[katSayisi, parkYeriSayisi]; // Belirtilen boyutta bir dizi oluşturur
        }

        // İndeksleyici: Belirli bir kat ve park yerine erişim sağlar
        public string this[int kat, int parkYeri]
        {
            get
            {
                if (GecerliMi(kat, parkYeri)) // Geçerli kat ve park yeri kontrolü
                {
                    return parkYerleri[kat, parkYeri] ?? "Empty"; // Park yeri doluysa plaka, boşsa "Empty"
                }
                else
                {
                    throw new IndexOutOfRangeException("Hata: Geçersiz kat veya park yeri!"); // Hata mesajı
                }
            }
            set
            {
                if (GecerliMi(kat, parkYeri)) // Geçerli kat ve park yeri kontrolü
                {
                    parkYerleri[kat, parkYeri] = value; // Park yerine plaka yerleştirir
                }
                else
                {
                    Console.WriteLine("Hata: Geçersiz kat veya park yeri!"); // Hata mesajı
                }
            }
        }

        // Geçerli kat ve park yeri kontrolü
        private bool GecerliMi(int kat, int parkYeri)
        {
            return kat >= 0 && kat < parkYerleri.GetLength(0) &&
                   parkYeri >= 0 && parkYeri < parkYerleri.GetLength(1);
        }

        // Tüm otopark durumunu listeleme metodu
        public void OtoparkDurumu()
        {
            for (int kat = 0; kat < parkYerleri.GetLength(0); kat++)
            {
                Console.Write($"Kat {kat + 1}: ");
                for (int parkYeri = 0; parkYeri < parkYerleri.GetLength(1); parkYeri++)
                {
                    Console.Write($"{(parkYerleri[kat, parkYeri] ?? "Empty"),-10} ");
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
