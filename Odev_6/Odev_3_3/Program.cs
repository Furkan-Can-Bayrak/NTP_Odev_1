using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_3_3
{

    struct GPSLocation
    {
        // Enlem ve boylam özellikleri
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        // Yapıcı metot: Enlem ve boylam değerlerini başlatır
        public GPSLocation(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        // Haversine Formülü ile iki GPS konumu arasındaki mesafeyi hesaplar
        public double CalculateDistance(GPSLocation other)
        {
            // Yeryüzünün yarıçapı (kilometre cinsinden)
            const double R = 6371;

            // Enlem ve boylam farklarını radyan cinsinden hesapla
            double lat1 = ToRadians(Latitude);
            double lon1 = ToRadians(Longitude);
            double lat2 = ToRadians(other.Latitude);
            double lon2 = ToRadians(other.Longitude);

            // Haversine Formülü'nü uygula
            double dLat = lat2 - lat1;
            double dLon = lon2 - lon1;
            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(lat1) * Math.Cos(lat2) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            // Mesafeyi hesapla (kilometre cinsinden)
            double distance = R * c;

            return distance;
        }

        // Dereceyi radyana çeviren yardımcı metot
        private double ToRadians(double degrees)
        {
            return degrees * (Math.PI / 180);
        }

        // Konumu biçimlendirilmiş şekilde döndüren metot
        public override string ToString()
        {
            return $"Latitude: {Latitude}, Longitude: {Longitude}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
