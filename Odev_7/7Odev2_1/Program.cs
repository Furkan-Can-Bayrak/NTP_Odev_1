using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Odev2_1
{
    // IBankaHesabi arayüzü tanımlanıyor
    interface IBankaHesabi
    {
        DateTime HesapAcilisTarihi { get; } // Hesap açılış tarihini temsil eder
        void HesapOzeti(); // Hesap özetini ekrana yazdıran metod
    }

    // Soyut Hesap sınıfı tanımlanıyor
    abstract class Hesap : IBankaHesabi
    {
        public int HesapNo { get; protected set; } // Hesap numarası
        public decimal Bakiye { get; protected set; } // Hesap bakiyesi
        public DateTime HesapAcilisTarihi { get; private set; } // Hesap açılış tarihi

        public Hesap(int hesapNo, decimal baslangicBakiyesi)
        {
            HesapNo = hesapNo;
            Bakiye = baslangicBakiyesi;
            HesapAcilisTarihi = DateTime.Now;
        }

        public abstract void ParaYatir(decimal miktar); // Para yatırma işlemi için soyut metod
        public abstract void ParaCek(decimal miktar); // Para çekme işlemi için soyut metod

        public void HesapOzeti()
        {
            Console.WriteLine($"Hesap No: {HesapNo}\nBakiye: {Bakiye:C}\nAçılış Tarihi: {HesapAcilisTarihi}\n");
        }
    }

    // BirikimHesabi sınıfı tanımlanıyor
    class BirikimHesabi : Hesap
    {
        public decimal FaizOrani { get; private set; } // Birikim hesabı faiz oranı

        public BirikimHesabi(int hesapNo, decimal baslangicBakiyesi, decimal faizOrani)
            : base(hesapNo, baslangicBakiyesi)
        {
            FaizOrani = faizOrani;
        }

        public override void ParaYatir(decimal miktar)
        {
            decimal faiz = miktar * FaizOrani / 100; // Faiz hesaplanıyor
            Bakiye += miktar + faiz; // Faiz eklenerek bakiye güncelleniyor
            Console.WriteLine($"Birikim Hesabınıza {miktar:C} yatırıldı. Faiz: {faiz:C}\n");
        }

        public override void ParaCek(decimal miktar)
        {
            if (miktar <= Bakiye)
            {
                Bakiye -= miktar; // Bakiyeden miktar düşülüyor
                Console.WriteLine($"Birikim Hesabınızdan {miktar:C} çekildi.\n");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye!\n");
            }
        }
    }

    // VadesizHesap sınıfı tanımlanıyor
    class VadesizHesap : Hesap
    {
        private const decimal IslemUcreti = 2.50m; // Her işlem için sabit bir ücret

        public VadesizHesap(int hesapNo, decimal baslangicBakiyesi)
            : base(hesapNo, baslangicBakiyesi) { }

        public override void ParaYatir(decimal miktar)
        {
            Bakiye += miktar; // Bakiye güncelleniyor
            Console.WriteLine($"Vadesiz Hesabınıza {miktar:C} yatırıldı.\n");
        }

        public override void ParaCek(decimal miktar)
        {
            decimal toplamMiktar = miktar + IslemUcreti; // İşlem ücreti ekleniyor
            if (toplamMiktar <= Bakiye)
            {
                Bakiye -= toplamMiktar; // Bakiyeden toplam miktar düşülüyor
                Console.WriteLine($"Vadesiz Hesabınızdan {miktar:C} çekildi. İşlem ücreti: {IslemUcreti:C}\n");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye!\n");
            }
        }
    }

    // Program sınıfı (Test işlemleri burada yapılıyor)
    class Program
    {
        static void Main(string[] args)
        {
            // Birikim Hesabı oluşturuluyor
            BirikimHesabi birikimHesabi = new BirikimHesabi(1001, 1000, 5);
            birikimHesabi.ParaYatir(500);
            birikimHesabi.ParaCek(300);
            birikimHesabi.HesapOzeti();

            // Vadesiz Hesap oluşturuluyor
            VadesizHesap vadesizHesap = new VadesizHesap(2001, 2000);
            vadesizHesap.ParaYatir(1000);
            vadesizHesap.ParaCek(250);
            vadesizHesap.HesapOzeti();

            Console.ReadLine(); // Çıkmadan önce ekrandaki sonuçları görmeyi sağlar
        }
    }
}
