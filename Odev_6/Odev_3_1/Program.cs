using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_3_1
{

    struct Time
    {
        // Saat ve dakika özellikleri
        private int hour;
        private int minute;

        // Saat özelliği: Geçersizse 0 yapılır
        public int Hour
        {
            get => hour;
            set => hour = (value >= 0 && value < 24) ? value : 0; // 0-23 arası olmalı
        }

        // Dakika özelliği: Geçersizse 0 yapılır
        public int Minute
        {
            get => minute;
            set => minute = (value >= 0 && value < 60) ? value : 0; // 0-59 arası olmalı
        }

        // Yapıcı metot: Saat ve dakika atanır
        public Time(int hour, int minute)
        {
            this.hour = (hour >= 0 && hour < 24) ? hour : 0;
            this.minute = (minute >= 0 && minute < 60) ? minute : 0;
        }

        // Toplam dakikayı döndüren metot
        public int GetTotalMinutes()
        {
            return hour * 60 + minute; // Saatleri dakikaya çevirip toplamını döndür
        }

        // İki zaman nesnesi arasındaki farkı (dakika olarak) hesaplayan metot
        public int GetDifferenceInMinutes(Time other)
        {
            int thisTotalMinutes = this.GetTotalMinutes();
            int otherTotalMinutes = other.GetTotalMinutes();
            return Math.Abs(thisTotalMinutes - otherTotalMinutes); // Mutlak fark
        }

        // Zamanı biçimlendirilmiş şekilde döndüren metot
        public override string ToString()
        {
            return $"{Hour:D2}:{Minute:D2}"; // Örneğin "08:05" formatı
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
