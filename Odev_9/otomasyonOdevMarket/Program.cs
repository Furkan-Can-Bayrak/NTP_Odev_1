using System;
using System.Collections.Generic;

namespace otomasyonOdevMarket
{
    // Ürün sınıfı
    public abstract class Urun
    {
        public string UrunAdi { get; set; } // Ürünün adı
        public decimal Fiyat { get; set; } // Ürünün fiyatı

        public Urun(string urunAdi, decimal fiyat)
        {
            UrunAdi = urunAdi;
            Fiyat = fiyat;
        }

        // Fiyat bilgisini gösteren soyut metot
        public abstract void FiyatGoster();
    }

    // Gıda ürünü sınıfı
    public class Gida : Urun
    {
        public DateTime SonKullanmaTarihi { get; set; } // Son kullanma tarihi

        public Gida(string urunAdi, decimal fiyat, DateTime sonKullanmaTarihi)
            : base(urunAdi, fiyat)
        {
            SonKullanmaTarihi = sonKullanmaTarihi;
        }

        public override void FiyatGoster()
        {
            Console.WriteLine($"Gıda Ürünü: {UrunAdi}, Fiyat: {Fiyat:C}, Son Kullanma Tarihi: {SonKullanmaTarihi.ToShortDateString()}");
        }
    }

    // Elektronik ürünü sınıfı
    public class Elektronik : Urun
    {
        public int GarantiSuresi { get; set; } // Garanti süresi (ay olarak)

        public Elektronik(string urunAdi, decimal fiyat, int garantiSuresi)
            : base(urunAdi, fiyat)
        {
            GarantiSuresi = garantiSuresi;
        }

        public override void FiyatGoster()
        {
            Console.WriteLine($"Elektronik Ürün: {UrunAdi}, Fiyat: {Fiyat:C}, Garanti Süresi: {GarantiSuresi} ay");
        }
    }

    // Müşteri sınıfı
    public abstract class Musteri
    {
        public string AdSoyad { get; set; } // Müşteri adı soyadı
        public string Telefon { get; set; } // Telefon numarası

        public Musteri(string adSoyad, string telefon)
        {
            AdSoyad = adSoyad;
            Telefon = telefon;
        }

        public abstract void MusteriBilgisiGoster();
    }

    // Bireysel müşteri sınıfı
    public class BireyselMusteri : Musteri
    {
        public string TCNo { get; set; } // TC kimlik numarası

        public BireyselMusteri(string adSoyad, string telefon, string tcNo)
            : base(adSoyad, telefon)
        {
            TCNo = tcNo;
        }

        public override void MusteriBilgisiGoster()
        {
            Console.WriteLine($"Bireysel Müşteri: {AdSoyad}, Telefon: {Telefon}, TC No: {TCNo}");
        }
    }

    // Kurumsal müşteri sınıfı
    public class KurumsalMusteri : Musteri
    {
        public string VergiNo { get; set; } // Vergi numarası

        public KurumsalMusteri(string adSoyad, string telefon, string vergiNo)
            : base(adSoyad, telefon)
        {
            VergiNo = vergiNo;
        }

        public override void MusteriBilgisiGoster()
        {
            Console.WriteLine($"Kurumsal Müşteri: {AdSoyad}, Telefon: {Telefon}, Vergi No: {VergiNo}");
        }
    }

    // Program sınıfı
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Örnek ürünler
                Gida elma = new Gida("Elma", 10.5m, DateTime.Now.AddDays(10));
                Elektronik telefon = new Elektronik("Telefon", 5000m, 24);

                // Ürünleri listeye ekleme
                List<Urun> urunler = new List<Urun> { elma, telefon };

                // Ürün bilgilerini gösterme
                foreach (var urun in urunler)
                {
                    urun.FiyatGoster();
                }

                // Örnek müşteriler
                BireyselMusteri bireysel = new BireyselMusteri("Ali Yılmaz", "05001234567", "12345678901");
                KurumsalMusteri kurumsal = new KurumsalMusteri("XYZ Ltd. Şti.", "02121234567", "9876543210");

                // Müşteri bilgilerini gösterme
                List<Musteri> musteriler = new List<Musteri> { bireysel, kurumsal };
                foreach (var musteri in musteriler)
                {
                    musteri.MusteriBilgisiGoster();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata oluştu: {ex.Message}");
            }
        }
    }
}
