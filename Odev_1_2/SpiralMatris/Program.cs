using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Matris boyutunu giriniz (N): ");
            int n = int.Parse(Console.ReadLine());

            int[,] matris = new int[n, n];

            SpiralMatrisDoldur(matris, n);
            MatrisYazdir(matris, n);
            Console.Read();
        }

        static void SpiralMatrisDoldur(int[,] matris, int n)
        {
            int sayi = 1; // Doldurulacak sayılar 1'den başlıyor
            int sol = 0, sag = n - 1, ust = 0, alt = n - 1;

            // Tüm matris doldurulana kadar devam et
            while (sayi <= n * n)
            {
                // Sağa doğru git
                for (int i = sol; i <= sag; i++)
                {
                    matris[ust, i] = sayi++;
                }
                ust++; // Üst sınır aşağı kaydırıldı

                // Aşağı doğru git
                for (int i = ust; i <= alt; i++)
                {
                    matris[i, sag] = sayi++;
                }
                sag--; // Sağ sınır sola kaydırıldı

                // Sola doğru git
                for (int i = sag; i >= sol; i--)
                {
                    matris[alt, i] = sayi++;
                }
                alt--; // Alt sınır yukarı kaydırıldı

                // Yukarı doğru git
                for (int i = alt; i >= ust; i--)
                {
                    matris[i, sol] = sayi++;
                }
                sol++; // Sol sınır sağa kaydırıldı
            }
        }

        static void MatrisYazdir(int[,] matris, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matris[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }
        }



    }
}
