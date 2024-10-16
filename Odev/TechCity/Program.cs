using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechCity
{
    class Program
    {
        static void Main(string[] args)
        {
            // hArita: 1 = kurtarılabilir, 0 = bozuk
            int[,] grid = {
            { 1, 1, 0, 1 },
            { 0, 1, 0, 0 },
            { 1, 1, 1, 0 },
            { 0, 0, 1, 1 }
        };

            // Robotların başlangıç pozisyonları
            int[,] robotStarts = {
            { 0, 0 }, // Robot 1
            { 2, 2 }, // Robot 2
            { 3, 3 }  // Robot 3
        };

            // Toplam kurtarılan düğüm sayısını hesaplar ve ekrana yazdırır
            int toplamKurtarilan = RobotlariCalistir(grid, robotStarts);
            Console.WriteLine("Toplam kurtarılan düğüm sayısı: " + toplamKurtarilan);
            Console.Read();
        }

        static int RobotlariCalistir(int[,] grid, int[,] robotStarts)
        {
            int n = grid.GetLength(0); // Grid boyutu (N x N)
            bool[,] ziyaretEdildi = new bool[n, n]; // Ziyaret edilen düğümleri takip ederiz
            int toplamKurtarilan = 0;

            // Her robot için işlemleri başlat
            for (int i = 0; i < robotStarts.GetLength(0); i++)
            {
                int baslangicX = robotStarts[i, 0];
                int baslangicY = robotStarts[i, 1];

                toplamKurtarilan += DüğümleriKurtar(grid, ziyaretEdildi, baslangicX, baslangicY);
            }

            return toplamKurtarilan;
        }

        static int DüğümleriKurtar(int[,] grid, bool[,] ziyaretEdildi, int x, int y)
        {
            int n = grid.GetLength(0);

            // Geçersiz durumları kontrol et (Sınırların dışında mı? Bozuk veya ziyaret edilmiş mi?)
            if (x < 0 || y < 0 || x >= n || y >= n || grid[x, y] == 0 || ziyaretEdildi[x, y])
            {
                return 0; // Kurtarılacak bir şey yoksa 0 döner
            }

            // Düğümü kurtardık, ziyaret edildi olarak işaretle
            ziyaretEdildi[x, y] = true;
            int kurtarilan = 1; // Bu düğüm kurtarıldı, 1 ekle

            // Komşu hücrelere git (yukarı, aşağı, sağ, sol)
            kurtarilan += DüğümleriKurtar(grid, ziyaretEdildi, x - 1, y); // Yukarı
            kurtarilan += DüğümleriKurtar(grid, ziyaretEdildi, x + 1, y); // Aşağı
            kurtarilan += DüğümleriKurtar(grid, ziyaretEdildi, x, y - 1); // Sol
            kurtarilan += DüğümleriKurtar(grid, ziyaretEdildi, x, y + 1); // Sağ

            return kurtarilan;
        }
    }
}
