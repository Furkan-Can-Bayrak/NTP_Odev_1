using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev8_3
{
    public class Transaction
    {
        public int Id { get; set; } // İşlem ID'si
        public string Name { get; set; } // İşlem adı
        public DateTime Date { get; set; } // İşlem tarihi
        public string Address { get; set; } // İşlem adresi

        // İşlemi güncelleme metodu
        public void Update()
        {
            Console.WriteLine($"Transaction {Id} güncellendi.");
        }
    }

    // Reservation (Rezervasyon) sınıfı
    public class Reservation
    {
        public int Id { get; set; } // Rezervasyon ID'si
        public string Details { get; set; } // Rezervasyon detayları
        public List<string> List { get; set; } = new List<string>(); // Rezervasyon listesi

        // Rezervasyon onaylama metodu
        public void Confirmation()
        {
            Console.WriteLine($"Rezervasyon {Id} onaylandı.");
        }
    }

    // Customer (Müşteri) sınıfı
    public class Customer
    {
        public int Id { get; set; } // Müşteri ID'si
        public string Name { get; set; } // Müşteri adı
        public string Contact { get; set; } // İletişim bilgisi
        public string Address { get; set; } // Adres
        public int Payment { get; set; } // Ödeme miktarı

        // Müşteri bilgilerini güncelleme metodu
        public void Update()
        {
            Console.WriteLine($"Müşteri {Name} bilgileri güncellendi.");
        }
    }

    // RentingOwner (Araç Kiralama Sahibi) sınıfı
    public class RentingOwner
    {
        public int Id { get; set; } // Sahip ID'si
        public string Name { get; set; } // Adı
        public int Age { get; set; } // Yaşı
        public string ContactNum { get; set; } // İletişim numarası
        public string Username { get; set; } // Kullanıcı adı
        public string Password { get; set; } // Şifre

        // Hesap doğrulama metodu
        public void VerifyAccount()
        {
            Console.WriteLine($"Sahip {Name} hesabı doğrulandı.");
        }
    }

    // Car (Araç) sınıfı
    public class Car
    {
        public int Id { get; set; } // Araç ID'si
        public string Details { get; set; } // Araç detayları
        public string OrderType { get; set; } // Sipariş türü (ör: Kiralama)

        // Ödeme işleme metodu
        public void ProcessDebit()
        {
            Console.WriteLine($"Araç {Details} için ödeme işlendi.");
        }
    }

    // Payment (Ödeme) sınıfı
    public class Payment
    {
        public int Id { get; set; } // Ödeme ID'si
        public int CardNumber { get; set; } // Kart numarası
        public string Amount { get; set; } // Ödeme miktarı

        // Yeni ödeme ekleme metodu
        public void Add()
        {
            Console.WriteLine($"Yeni ödeme {Amount} eklendi.");
        }

        // Ödemeyi güncelleme metodu
        public void Update()
        {
            Console.WriteLine($"Ödeme {Id} güncellendi.");
        }
    }

    // Rentals (Kiralama) sınıfı
    public class Rentals
    {
        public int Id { get; set; } // Kiralama ID'si
        public string Names { get; set; } // Kiralanan araçların isimleri
        public string Price { get; set; } // Fiyat

        // Yeni kiralama ekleme metodu
        public void Add()
        {
            Console.WriteLine($"Yeni kiralama {Names} eklendi.");
        }

        // Kiralamayı güncelleme metodu
        public void Update()
        {
            Console.WriteLine($"Kiralama {Id} güncellendi.");
        }
    }

    // Ana program
    class Program
    {
        static void Main(string[] args)
        {
            // Örnek bir müşteri oluşturma
            Customer customer = new Customer
            {
                Id = 1,
                Name = "Ahmet Yılmaz",
                Contact = "0555 123 4567",
                Address = "İstanbul",
                Payment = 500
            };
            customer.Update();

            // Araç oluşturma
            Car car = new Car
            {
                Id = 101,
                Details = "Toyota Corolla",
                OrderType = "Kiralama"
            };
            car.ProcessDebit();

            // Rezervasyon oluşturma
            Reservation reservation = new Reservation
            {
                Id = 1,
                Details = "1 günlük kiralama"
            };
            reservation.List.Add("Toyota Corolla");
            reservation.Confirmation();

            // Ödeme işlemi
            Payment payment = new Payment
            {
                Id = 201,
                CardNumber = 123126,
                Amount = "500 TL"
            };
            payment.Add();

            // Kiralama işlemi
            Rentals rental = new Rentals
            {
                Id = 301,
                Names = "Toyota Corolla",
                Price = "500 TL"
            };
            rental.Add();

            // RentingOwner oluşturma
            RentingOwner owner = new RentingOwner
            {
                Id = 401,
                Name = "Fatma Kaya",
                Age = 45,
                ContactNum = "0543 987 6543",
                Username = "fkaya",
                Password = "1234"
            };
            owner.VerifyAccount();
            Console.Read();
        }
    }
}
