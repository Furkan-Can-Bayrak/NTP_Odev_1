using System;
using System.Collections.Generic;

class Decryptor
{
    // Mesajın uzunluğuna kadar gerekli Fibonacci sayılarını hesaplayan fonksiyon
    static List<int> GenerateFibonacciSeries(int length)
    {
        List<int> fibonacci = new List<int> { 1, 1 };
        for (int i = 2; i < length; i++)
        {
            fibonacci.Add(fibonacci[i - 1] + fibonacci[i - 2]); // Her yeni sayı önceki iki sayının toplamıdır
        }
        return fibonacci;
    }

    // Belirli bir sayının asal olup olmadığını kontrol eden fonksiyon
    static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        for (int i = 2; i * i <= num; i++)
            if (num % i == 0) return false;
        return true;
    }

    // Şifreli mesajı çözme fonksiyonu
    static string DecryptMessage(string encryptedMessage)
    {
        int length = encryptedMessage.Length;
        var fibonacci = GenerateFibonacciSeries(length); // Fibonacci serisini oluştur
        char[] originalMessage = new char[length]; // Orijinal mesajı saklamak için dizi

        for (int i = 0; i < length; i++)
        {
            int encryptedAscii = encryptedMessage[i]; // Şifreli karakterin ASCII değeri
            int position = i + 1; // Pozisyon, 1'den başlar

            int modValue = IsPrime(position) ? 100 : 256; // Asal pozisyon için mod 100, değilse mod 256
            int possibleValue = encryptedAscii; // Mod işlemi sonucunda elde edilen değer

            // Mod işlemini tersine çevirmeye çalış
            while (possibleValue < 128 || possibleValue > 255)
            {
                possibleValue += modValue; // ASCII değer aralığına ulaşana kadar mod eklenir
            }

            // Fibonacci çarpanını tersine uygula
            int originalAscii = possibleValue / fibonacci[i];

            // Orijinal ASCII değerini karaktere çevir
            originalMessage[i] = (char)originalAscii;
        }

        return new string(originalMessage); // Orijinal mesajı döndür
    }

    static void Main()
    {
        Console.WriteLine("Şifrelenmiş mesajı girin:");
        string encryptedMessage = Console.ReadLine(); // Kullanıcıdan şifreli mesajı al

        string decryptedMessage = DecryptMessage(encryptedMessage); // Mesajı çöz
        Console.WriteLine("Çözülen mesaj: " + decryptedMessage); // Çözülen mesajı yazdır
        Console.ReadLine();
    }
}
