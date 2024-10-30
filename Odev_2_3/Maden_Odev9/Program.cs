using System;

class AsteroidMining
{
    // Enerji matrisi boyutunu alır ve minimum enerjiyi hesaplar
    static int MinEnergyPath(int[,] energy, int N)
    {
        // DP matrisini oluştur
        int[,] dp = new int[N, N];

        // Başlangıç hücresinin enerjisini ayarla
        dp[0, 0] = energy[0, 0];

        // İlk satırı doldur (sadece sağa hareket edilebilir)
        for (int j = 1; j < N; j++)
        {
            dp[0, j] = dp[0, j - 1] + energy[0, j];
        }

        // İlk sütunu doldur (sadece aşağıya hareket edilebilir)
        for (int i = 1; i < N; i++)
        {
            dp[i, 0] = dp[i - 1, 0] + energy[i, 0];
        }

        // Geri kalan hücreler için minimum enerji hesapla
        for (int i = 1; i < N; i++)
        {
            for (int j = 1; j < N; j++)
            {
                // Sağdan, aşağıdan veya çaprazdan gelen minimum maliyeti bul
                int minPrevious = Math.Min(dp[i - 1, j], Math.Min(dp[i, j - 1], dp[i - 1, j - 1]));

                // O hücreye minimum enerji harcayarak gelmeyi hesapla
                dp[i, j] = energy[i, j] + minPrevious;
            }
        }

        // Hedef hücreye ulaşmak için gereken minimum enerji miktarı
        return dp[N - 1, N - 1];
    }

    static void Main()
    {
        int N = 3; // Örnek bir matris boyutu
        int[,] energy = {
            { 1, 3, 5 },
            { 2, 8, 2 },
            { 4, 1, 3 }
        };

        int result = MinEnergyPath(energy, N);
        Console.WriteLine("En az enerji harcayan yolun maliyeti: " + result);
        Console.ReadLine();
    }
}
