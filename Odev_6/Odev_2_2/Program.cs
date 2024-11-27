using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_2_2
{

    class OgrenciNotSistemi
    {
        private Dictionary<string, double> dersNotlari; // Ders adları ve notlarını depolayan sözlük

        // Yapıcı metot: Sözlüğü başlatır
        public OgrenciNotSistemi()
        {
            dersNotlari = new Dictionary<string, double>(); // Boş bir sözlük oluşturur
        }

        // İndeksleyici: Ders adına göre notlara erişim sağlar
        public double this[string dersAdi]
        {
            get
            {
                if (dersNotlari.ContainsKey(dersAdi)) // Ders sözlükte varsa
                {
                    return dersNotlari[dersAdi]; // İlgili notu döndür
                }
                else
                {
                    throw new KeyNotFoundException($"Hata: '{dersAdi}' adlı ders bulunamadı!"); // Hata mesajı
                }
            }
            set
            {
                if (!string.IsNullOrEmpty(dersAdi)) // Geçerli bir ders adı kontrolü
                {
                    dersNotlari[dersAdi] = value; // Notu güncelle veya ekle
                }
                else
                {
                    Console.WriteLine("Hata: Ders adı boş olamaz!"); // Hata mesajı
                }
            }
        }

        // Tüm ders ve notlarını listeleme metodu
        public void Listele()
        {
            Console.WriteLine("Dersler ve Notlar:");
            foreach (var ders in dersNotlari)
            {
                Console.WriteLine($"{ders.Key}: {ders.Value}");
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
