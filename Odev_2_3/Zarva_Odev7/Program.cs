using System;
using System.Collections.Generic;

class ZarvaMaze
{
    static int M = 5; // Labirent satır sayısı
    static int N = 5; // Labirent sütun sayısı
    static (int x, int y)[] directions = { (0, 1), (1, 0), (0, -1), (-1, 0) }; // Sağ, aşağı, sol, yukarı yönleri

    // Belirli bir sayı asal mı değil mi kontrol eden fonksiyon
    static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        for (int i = 2; i * i <= num; i++)
            if (num % i == 0) return false;
        return true;
    }

    // Koordinatın her iki basamağı asal mı kontrol eden fonksiyon
    static bool HasPrimeDigits(int num)
    {
        int tens = num / 10; // Onlar basamağı
        int ones = num % 10; // Birler basamağı
        return IsPrime(tens) && IsPrime(ones); // Her iki basamağın asal olup olmadığını döndürür
    }

    // Hücre geçerli mi kontrol eden fonksiyon
    static bool CanOpenDoor(int x, int y)
    {
        if (x >= M || y >= N || x < 0 || y < 0) return false; // Koordinatlar sınır dışında ise geçersiz
        if (!HasPrimeDigits(x) || !HasPrimeDigits(y)) return false; // Basamaklar asal değilse geçersiz
        return (x + y) % (x * y) == 0; // Toplam, çarpıma bölünüyorsa geçerli
    }

    // Labirentte yol bulmak için BFS algoritması
    static List<(int x, int y)> FindPath()
    {
        var queue = new Queue<(int x, int y, List<(int, int)> path)>(); // Konum ve yolu içeren kuyruk
        queue.Enqueue((0, 0, new List<(int, int)> { (0, 0) })); // Başlangıç konumunu kuyrukta sıraya ekler

        var visited = new HashSet<(int, int)>(); // Ziyaret edilen hücreleri kaydeder
        visited.Add((0, 0)); // Başlangıç noktası ziyaret edildi

        while (queue.Count > 0)
        {
            var (x, y, path) = queue.Dequeue(); // Kuyruktan konum ve yolu çıkarır

            // Hedefe ulaşıldıysa yolu döndürür
            if (x == M - 1 && y == N - 1) return path;

            // Komşu hücreleri kontrol eder
            foreach (var (dx, dy) in directions)
            {
                int newX = x + dx;
                int newY = y + dy;

                // Yeni konum geçerli ve ziyaret edilmemişse
                if (CanOpenDoor(newX, newY) && !visited.Contains((newX, newY)))
                {
                    visited.Add((newX, newY)); // Yeni konumu ziyaret edilmiş olarak işaretler
                    var newPath = new List<(int, int)>(path) { (newX, newY) }; // Yeni yolu oluşturur
                    queue.Enqueue((newX, newY, newPath)); // Yeni konumu kuyruğa ekler
                }
            }
        }
        return null; // Yol bulunamadıysa null döner
    }

    static void Main()
    {
        var path = FindPath(); // Yolu bulmak için fonksiyonu çağırır

        if (path != null)
        {
            Console.WriteLine("Yol bulundu:");
            foreach (var (x, y) in path)
            {
                Console.WriteLine($"({x}, {y})"); // Her adımı yazdırır
            }
        }
        else
        {
            Console.WriteLine("Şehir kayboldu!"); // Yol bulunamadıysa çıktı verir
        }
        Console.ReadLine();
    }
}
