using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_1_2
{
    class AlanHesaplayici
    {
        // İlk sürüm: Karenin alanını hesaplar (bir kenar uzunluğu verilerek)
        public double Alan(int kenar)
        {
            return kenar * kenar; // Kenarın karesi karenin alanıdır
        }

        // İkinci sürüm: Dikdörtgenin alanını hesaplar (iki kenar uzunluğu verilerek)
        public double Alan(double uzunKenar, double kisaKenar)
        {
            return uzunKenar * kisaKenar; // Uzun kenar * Kısa kenar dikdörtgenin alanıdır
        }

        // Üçüncü sürüm: Dairenin alanını hesaplar (yarıçap verilerek)
        public double Alan(double yaricap)
        {
            return Math.PI * yaricap * yaricap; // π * r^2 formülü ile dairenin alanı
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
