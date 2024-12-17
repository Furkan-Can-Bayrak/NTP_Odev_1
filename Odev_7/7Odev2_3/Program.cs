using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Odev2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Yayıncı oluşturuluyor
            Yayinci yayinci = new Yayinci();

            // Aboneler oluşturuluyor
            Abone abone1 = new Abone("Furkan");
            Abone abone2 = new Abone("Ahmet");
            Abone abone3 = new Abone("Zeynep");

            // Aboneleri yayıncıya ekliyoruz
            yayinci.aboneEkle(abone1);
            yayinci.aboneEkle(abone2);
            yayinci.aboneEkle(abone3);

            // Yayıncı bir güncelleme bildiriyor
            yayinci.yeniGuncelleme("Yeni bir makale yayınlandı!");

            // Bir aboneliği kaldırıyoruz
            yayinci.aboneCikar(abone2);

            // Güncelleme tekrar bildiriliyor
            yayinci.yeniGuncelleme("Yeni video yüklendi!");

            Console.ReadLine();
        }
    }

    // 1. Yayıncı Arayüzü
    interface IYayinci
    {
        void aboneEkle(IAbone abone);  // Abone ekleme metodu
        void aboneCikar(IAbone abone); // Abone çıkarma metodu
        void aboneListele();           // Abone listeleme metodu
        void yeniGuncelleme(string mesaj); // Abonelere yeni bir güncelleme bildir
    }

    // 2. Abone Arayüzü
    interface IAbone
    {
        void bilgiAl(string mesaj); // Abonenin bilgi alması için metod
    } // 3. Yayıncı Sınıfı (Concrete Subject)
    class Yayinci : IYayinci
    {
        private List<IAbone> aboneler = new List<IAbone>(); // Abonelerin listesi

        // Abone ekleme metodu
        public void aboneEkle(IAbone abone)
        {
            aboneler.Add(abone);
            Console.WriteLine("Yeni abone eklendi.");
        }

        // Abone çıkarma metodu
        public void aboneCikar(IAbone abone)
        {
            aboneler.Remove(abone);
            Console.WriteLine("Bir abone çıkarıldı.");
        }

        // Tüm aboneleri listeleme metodu
        public void aboneListele()
        {
            Console.WriteLine("Abone Listesi:");
            foreach (var abone in aboneler)
            {
                Console.WriteLine(abone);
            }
        }

        // Yeni güncelleme gönderme metodu
        public void yeniGuncelleme(string mesaj)
        {
            Console.WriteLine($"\n[Yayıncı]: {mesaj}");
            foreach (IAbone abone in aboneler)
            {
                abone.bilgiAl(mesaj); // Her aboneye mesaj gönderiliyor
            }
        }
    }

    // 4. Abone Sınıfı (Concrete Observer)
    class Abone : IAbone
    {
        private string _isim; // Abonenin ismi

        // Yapıcı metod
        public Abone(string isim)
        {
            _isim = isim;
        }

        // Abone güncelleme aldığı zaman çalışacak metod
        public void bilgiAl(string mesaj)
        {
            Console.WriteLine($"{_isim} güncelleme aldı: {mesaj}");
        }
    }
}