using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_4_1
{

    // Trafik ışıkları için enum
    enum TrafficLight
    {
        Red,
        Yellow,
        Green
    }

    // Trafik ışıklarını kontrol eden sınıf
    class TrafficController
    {
        // Trafik ışığının durumuna göre yapılacak işlemi döndüren metot
        public string GetAction(TrafficLight light)
        {
            switch (light)
            {
                case TrafficLight.Red:
                    return "Dur! Işık kırmızı.";
                case TrafficLight.Yellow:
                    return "Dikkat! Işık sarı.";
                case TrafficLight.Green:
                    return "Geç! Işık yeşil.";
                default:
                    return "Bilinmeyen ışık durumu!";
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
