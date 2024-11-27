using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_2_1
{
    class Kitaplik
    {
        private string[] kitaplar; // Kitap koleksiyonunu depolayan dizi

        // Yapıcı metot (constructor): Kitap koleksiyonunun boyutunu belirler
        public Kitaplik(int kapasite)
        {
            kitaplar = new string[kapasite]; // Belirtilen kapasitede dizi oluşturur
        }

        // İndeksleyici: Kitaplara indeksle erişim sağlar
        public string this[int indeks]
        {
            get
            {
                if (indeks < 0 || indeks >= kitaplar.Length) // Geçersiz indeks kontrolü
                {
                    return "Hata: Geçersiz indeks!"; // Hata mesajı döndürür
                }
                return kitaplar[indeks] ?? "Bu indeks boş."; // Kitabı döndürür veya boşsa mesaj verir
            }
            set
            {
                if (indeks < 0 || indeks >= kitaplar.Length) // Geçersiz indeks kontrolü
                {
                    Console.WriteLine("Hata: Geçersiz indeks!"); // Hata mesajı yazdırır
                }
                else
                {
                    kitaplar[indeks] = value; // Belirtilen indeksteki kitabı değiştirir
                }
            }
        }

        // Tüm kitapları listeleme metodu
        public void Listele()
        {
            Console.WriteLine("Kitap Listesi:");
            for (int i = 0; i < kitaplar.Length; i++)
            {
                Console.WriteLine($"İndeks {i}: {kitaplar[i] ?? "Boş"}");
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
