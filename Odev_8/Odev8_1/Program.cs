using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev8_1
{
    public class Person
    {
        public string Name { get; set; } // Kişinin adı
        public string PhoneNumber { get; set; } // Telefon numarası
        public string EmailAddress { get; set; } // E-posta adresi

        // Otopark geçiş kartı satın alma metodu
        public void PurchaseParkingPass()
        {
            Console.WriteLine($"{Name} otopark geçiş kartı satın aldı.");
        }
    }

    // Adresi temsil eden sınıf
    public class Address
    {
        public string Street { get; set; } // Sokak adı
        public string City { get; set; } // Şehir adı
        public string State { get; set; } // Eyalet veya bölge adı
        public int PostalCode { get; set; } // Posta kodu
        public string Country { get; set; } // Ülke adı

        // Adresin geçerli olup olmadığını kontrol eden metot
        public bool Validate()
        {
            // Örnek bir doğrulama mantığı
            return !string.IsNullOrEmpty(Street) && !string.IsNullOrEmpty(City);
        }

        // Adresi etiket formatında döndüren metot
        public string OutputAsLabel()
        {
            return $"{Street}, {City}, {State}, {PostalCode}, {Country}";
        }
    }

    // Öğrenciyi temsil eden türetilmiş sınıf
    public class Student : Person
    {
        public int StudentNumber { get; set; } // Öğrenci numarası
        public int AverageMark { get; set; } // Öğrencinin not ortalaması

        // Öğrencinin bir derse kayıt için uygun olup olmadığını kontrol eden metot
        public bool IsEligibleToEnroll(string course)
        {
            // Örnek bir uygunluk mantığı
            return AverageMark >= 50; // 50'nin üzerindeki notlar kayıt için uygun
        }

        // Alınan seminer sayısını döndüren metot
        public int GetSeminarsTaken()
        {
            // Örnek veri
            return 5;
        }
    }

    // Profesörü temsil eden türetilmiş sınıf
    public class Professor : Person
    {
        public int Salary { get; private set; } // Maaş (sadece okunabilir)
        public int StaffNumber { get; protected set; } // Personel numarası (korumalı)
        public int YearsOfService { get; set; } // Hizmet yılı
        public int NumberOfClasses { get; set; } // Verilen ders sayısı

        // Profesör sınıfı için bir kurucu metot
        public Professor(int salary, int staffNumber)
        {
            Salary = salary;
            StaffNumber = staffNumber;
        }
    }

    // Ana program
    class Program
    {
        static void Main(string[] args)
        {
            // Yeni bir adres oluşturma
            Address address = new Address
            {
                Street = "123 Ana Cadde",
                City = "Springfield",
                State = "IL",
                PostalCode = 62704,
                Country = "ABD"
            };

            // Yeni bir öğrenci oluşturma
            Student student = new Student
            {
                Name = "Ahmet Yılmaz",
                PhoneNumber = "123-456-7890",
                EmailAddress = "ahmet.yilmaz@example.com",
                StudentNumber = 12345,
                AverageMark = 85
            };

            // Yeni bir profesör oluşturma
            Professor professor = new Professor(75000, 1001)
            {
                Name = "Dr. Mehmet",
                PhoneNumber = "987-654-3210",
                EmailAddress = "dr.mehmet@example.com",
                YearsOfService = 10,
                NumberOfClasses = 3
            };

            // Detayları ekrana yazdırma
            Console.WriteLine(student.Name); // Öğrenci adı
            Console.WriteLine(professor.Name); // Profesör adı
            Console.WriteLine(address.OutputAsLabel()); // Adresi etiket formatında yazdırma
            Console.Read();
        }
    }
}
