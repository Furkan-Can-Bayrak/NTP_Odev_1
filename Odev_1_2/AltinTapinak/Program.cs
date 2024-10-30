using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltinTapinak
{
    class Program
    {
        static void Main(string[] args)
        {
            // Labirent tanımladık
            int[,] labirent = {
            { 1, 0, 0, 0 },
            { 1, 1, 0, 1 },
            { 0, 1, 1, 1 },
            { 0, 0, 0, 1 }
        };

            // kisa yolu bulur
            int adimSayisi = EnKisaYol(labirent);

            if (adimSayisi == -1)
            {
                Console.WriteLine("Yol Yok");
            }
            else
            {
                Console.WriteLine("En kısa yol: " + adimSayisi + " adım.");
            }
            Console.Read();
        }

        static int EnKisaYol(int[,] labirent)
        {
            int n = labirent.GetLength(0); // Grid boyutu
            if (labirent[0, 0] == 0 || labirent[n - 1, n - 1] == 0)
            {
                return -1; // Başlangıç veya bitiş noktası kapalıysa yol yok
            }

            // Hareket yönleri (yukarı, aşağı, sol, sağ)
            int[] dx = { -1, 1, 0, 0 };
            int[] dy = { 0, 0, -1, 1 };

            // Ziyaret edilen hücreleri takip etmek için bir dizi
            bool[,] ziyaretEdildi = new bool[n, n];

            // kuyruk yapısı (x, y, adım sayısı)
            Queue<(int, int, int)> kuyruk = new Queue<(int, int, int)>();
            kuyruk.Enqueue((0, 0, 1)); // Başlangıç noktası ve adım sayısı 1
            ziyaretEdildi[0, 0] = true;

            // Kuyruk boşalana kadar döngü
            while (kuyruk.Count > 0)
            {
                var (x, y, adim) = kuyruk.Dequeue();

                // Hazineye ulaşıldı mı?
                if (x == n - 1 && y == n - 1)
                {
                    return adim; // En kısa yol bulundu
                }

                // 4 yöne hareket et
                for (int i = 0; i < 4; i++)
                {
                    int yeniX = x + dx[i];
                    int yeniY = y + dy[i];

                    // Yeni pozisyon geçerli mi?
                    if (yeniX >= 0 && yeniX < n && yeniY >= 0 && yeniY < n &&
                        labirent[yeniX, yeniY] == 1 && !ziyaretEdildi[yeniX, yeniY])
                    {
                        // Geçerli pozisyona git ve kuyruğa ekle
                        ziyaretEdildi[yeniX, yeniY] = true;
                        kuyruk.Enqueue((yeniX, yeniY, adim + 1));
                    }
                }
            }

            return -1; // Yol yoksa -1 döner
        }
    }
}
