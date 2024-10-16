using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkıMatrisinCarpimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan matris boyutu alıyoz
            Console.Write("Matris boyutunu girin (N): ");
            int n = Convert.ToInt32(Console.ReadLine()); // Kullanıcının girdiği değeri tam sayı olarak alıyoruz

            // n x n boyutunda üç adet matris oluşturuyoruz
            int[,] A = new int[n, n]; // Birinci matris
            int[,] B = new int[n, n]; // İkinci matris
            int[,] C = new int[n, n]; // Sonuç matrisi (çarpım sonucu buraya yazılacak)

            // A matrisinin elemanlarını kullanıcıdan alıyoruz
            Console.WriteLine("Birinci matrisin elemanlarını girin:");
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < n; j++) 
                {
                    Console.Write($"A[{i},{j}]: "); // Burada yazdığı değer nerede görsün diye yaptık
                    A[i, j] = Convert.ToInt32(Console.ReadLine()); // Kullanıcıdan değeri alıyoruz
                }
            }

            // B elemanlarını kullanıcıdan alıyoruz
            Console.WriteLine("İkinci matrisin elemanlarını girin:");
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < n; j++) 
                {
                    Console.Write($"B[{i},{j}]: ");
                    B[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Matris çarpım işlemini gerçekleştiriyoruz
            for (int i = 0; i < n; i++) // Sonuç matrisinin her bir satırı için döngü
            {
                for (int j = 0; j < n; j++) // Sonuç matrisinin her bir sütunu için döngü
                {
                    C[i, j] = 0; // C matrisinin (i, j) elemanını sıfırlıyoruz

                    // A'nın i. satırı ile B'nin j. sütununun elemanlarını çarpıp topluyoruz
                    for (int k = 0; k < n; k++) // A ve B matrisleri için iç döngü
                    {
                        C[i, j] += A[i, k] * B[k, j]; // Çarpımların toplamını C[i,j]'ye ekliyoruz
                    }
                }
            }

            // Sonuç matrisini (C) ekrana yazdırıyoruz
            Console.WriteLine("Sonuç matrisi (C):");
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < n; j++) 
                {
                    Console.Write(C[i, j] + "\t"); // Her elemanı ekrana yazdırıyoruz. Güzel gözüksün diye t kullandık
                }
                Console.WriteLine(); // Satır sonuna geldiğimizde alt satıra geçiyoruz
            }
            Console.ReadLine();
        }
    }
}
