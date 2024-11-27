using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_4_2
{

    // Hava durumu tiplerini temsil eden enum
    enum Weather
    {
        Sunny,
        Rainy,
        Cloudy,
        Stormy
    }

    // Hava durumu tavsiyeleri veren sınıf
    class WeatherAdvisor
    {
        // Hava durumu tipine göre tavsiye veren metot
        public string GetRecommendation(Weather weather)
        {
            switch (weather)
            {
                case Weather.Sunny:
                    return "Güneşli bir gün! Güneş kremi sürmeyi unutma.";
                case Weather.Rainy:
                    return "Yağmurlu hava! Şemsiye almayı unutma.";
                case Weather.Cloudy:
                    return "Bulutlu bir gün! Hava soğuyabilir, yanına bir ceket al.";
                case Weather.Stormy:
                    return "Fırtınalı hava! Dışarı çıkmamaya çalış.";
                default:
                    return "Bilinmeyen hava durumu!";
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
