using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_1_3
{

    class ZamanFarkiHesaplayici
    {
        // İlk sürüm: Gün cinsinden farkı döndürür
        public int Fark(DateTime tarih1, DateTime tarih2)
        {
            TimeSpan fark = tarih2 - tarih1; // İki tarih arasındaki farkı hesaplar
            return Math.Abs(fark.Days); // Gün cinsinden farkı döndürür (mutlak değer)
        }

        // İkinci sürüm: Saat cinsinden farkı döndürür
        public double Fark(DateTime tarih1, DateTime tarih2, bool saatCinsinden)
        {
            TimeSpan fark = tarih2 - tarih1; // İki tarih arasındaki farkı hesaplar
            return Math.Abs(fark.TotalHours); // Saat cinsinden farkı döndürür
        }

        // Üçüncü sürüm: Yıl, ay ve gün cinsinden farkı ayrı ayrı döndürür
        public (int Yil, int Ay, int Gun) Fark(DateTime tarih1, DateTime tarih2, bool detayli, bool _)
        {
            // İki tarihi sıralar ve tarih1 daima daha küçük olur
            if (tarih1 > tarih2) (tarih1, tarih2) = (tarih2, tarih1);

            int yilFarki = tarih2.Year - tarih1.Year;
            int ayFarki = tarih2.Month - tarih1.Month;
            int gunFarki = tarih2.Day - tarih1.Day;

            // Ay farkını düzeltme
            if (ayFarki < 0)
            {
                ayFarki += 12;
                yilFarki--;
            }

            // Gün farkını düzeltme
            if (gunFarki < 0)
            {
                ayFarki--;
                gunFarki += DateTime.DaysInMonth(tarih1.Year, tarih1.Month);
            }

            return (yilFarki, ayFarki, gunFarki);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
