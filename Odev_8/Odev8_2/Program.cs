using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev8_2
{
    // Identifiable arayüzü: Pet sınıfı tarafından uygulanır
    public interface Identifiable
    {
        Guid Id { get; }
    }

    // Experienced arayüzü: Owner sınıfı tarafından uygulanır
    public interface Experienced
    {
        void ShowExperience();
    }

    // Pet sınıfı
    public class Pet : Identifiable
    {
        public Guid Id { get; } = Guid.NewGuid(); // UUID
        public string Name { get; set; } // Evcil hayvanın adı
        public int Age { get; set; } // Yaşı
        public Owner Owner { get; set; } // Sahibi
        public Animal Type { get; set; } // Hayvan türü
        public PetInformation PetInfo { get; set; } // Evcil hayvan bilgileri

        // Evcil hayvanı besleme metodu
        public void Feed()
        {
            Console.WriteLine($"{Name} besleniyor...");
        }

        // Hayvanın otobur olup olmadığını kontrol eden metot
        public bool IsHerbivore()
        {
            return !Type.Carnivore; // Otobur, eğer etçil değilse
        }
    }

    // Owner (Sahip) sınıfı
    public class Owner : Experienced
    {
        public string Name { get; set; } // Sahip adı

        // Deneyimi gösteren metot
        public void ShowExperience()
        {
            Console.WriteLine($"{Name}, evcil hayvan sahipliği konusunda deneyimlidir.");
        }
    }

    // Animal (Hayvan) sınıfı
    public class Animal
    {
        public string Type { get; set; } // Tür (ör: Köpek, Kedi)
        public string Breed { get; set; } // Irk
        public bool Carnivore { get; set; } // Etçil mi?
    }

    // PetInformation (Evcil Hayvan Bilgileri) sınıfı
    public class PetInformation
    {
        public List<string> Traits { get; set; } = new List<string>(); // Özellikler
        public List<Vaccine> Vaccines { get; set; } = new List<Vaccine>(); // Aşılar
    }

    // Vaccine (Aşı) sınıfı
    public class Vaccine
    {
        public string Name { get; set; } // Aşının adı
        public string Type { get; set; } // Aşının türü
    }

    // Ana program
    class Program
    {
        static void Main(string[] args)
        {
            // Yeni bir hayvan türü oluşturma
            Animal dog = new Animal
            {
                Type = "Dog",
                Breed = "Golden Retriever",
                Carnivore = true
            };

            // Yeni bir sahip oluşturma
            Owner owner = new Owner
            {
                Name = "Ahmet"
            };

            // Yeni aşılar oluşturma
            Vaccine rabies = new Vaccine { Name = "Rabies", Type = "Viral" };
            Vaccine distemper = new Vaccine { Name = "Distemper", Type = "Viral" };

            // Evcil hayvan bilgileri oluşturma
            PetInformation petInfo = new PetInformation();
            petInfo.Traits.Add("Friendly");
            petInfo.Traits.Add("Energetic");
            petInfo.Vaccines.Add(rabies);
            petInfo.Vaccines.Add(distemper);

            // Yeni bir evcil hayvan oluşturma
            Pet pet = new Pet
            {
                Name = "Max",
                Age = 3,
                Owner = owner,
                Type = dog,
                PetInfo = petInfo
            };

            // Evcil hayvanı besleme
            pet.Feed();

            // Otobur olup olmadığını kontrol etme
            Console.WriteLine($"{pet.Name} otobur mu? {pet.IsHerbivore()}");

            // Sahip bilgilerini gösterme
            owner.ShowExperience();

            // Evcil hayvanın özelliklerini ve aşılarını gösterme
            Console.WriteLine("Evcil hayvanın özellikleri:");
            foreach (var trait in petInfo.Traits)
            {
                Console.WriteLine($"- {trait}");
            }

            Console.WriteLine("Evcil hayvanın aşıları:");
            foreach (var vaccine in petInfo.Vaccines)
            {
                Console.WriteLine($"- {vaccine.Name} ({vaccine.Type})");
            }
            Console.Read();
        }
    }
}
