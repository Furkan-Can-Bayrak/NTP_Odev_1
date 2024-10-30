using System;
using System.Collections.Generic;

class TempleGateSolver
{
    // Bu fonksiyon operatörleri ve sayıları belirli kurallara göre sıralayarak sonucu bulmaya çalışır
    static bool FindCombination(int[] numbers, char[] operators, int index, int currentResult, List<string> expression)
    {
        // Tüm sayılar ve operatörler işlendiğinde sonucu kontrol et
        if (index == numbers.Length)
        {
            if (currentResult > 0) // Sonuç sıfırdan büyük mü kontrol et
            {
                Console.WriteLine("Geçerli Çözüm: " + string.Join(" ", expression));
                return true;
            }
            return false;
        }

        bool foundSolution = false;

        // Sayıyı ve operatörü işle
        foreach (char op in operators)
        {
            int newResult = currentResult;

            // İşlem yap ve sonucu kontrol et
            switch (op)
            {
                case '+':
                    newResult += numbers[index];
                    break;
                case '-':
                    newResult -= numbers[index];
                    break;
                case '*':
                    newResult *= numbers[index];
                    break;
                case '/':
                    if (numbers[index] != 0) // Bölme işleminde sıfır kontrolü
                        newResult /= numbers[index];
                    else
                        continue;
                    break;
            }

            // Yeni sonuç sıfırdan büyükse işlemi devam ettir
            if (newResult > 0)
            {
                // Operatörü ve sayıyı ifadeye ekle
                expression.Add(op.ToString());
                expression.Add(numbers[index].ToString());

                // Sonraki adıma geç (backtracking ile devam et)
                foundSolution = FindCombination(numbers, operators, index + 1, newResult, expression);

                // Çözüm bulunduysa döngüyü durdur
                if (foundSolution) break;

                // Çözüm bulunamazsa son işlemi geri al
                expression.RemoveAt(expression.Count - 1);
                expression.RemoveAt(expression.Count - 1);
            }
        }

        return foundSolution;
    }

    static void Main()
    {
        // Örnek sayı dizisi ve operatörler
        int[] numbers = { 7, 3, 5, 2 };
        char[] operators = { '+', '-', '*', '/' };

        // İlk sayıyı ekleyerek işlemleri başlat
        List<string> expression = new List<string> { numbers[0].ToString() };
        bool success = FindCombination(numbers, operators, 1, numbers[0], expression);

        if (!success)
            Console.WriteLine("Geçerli bir çözüm bulunamadı.");
        Console.ReadLine();
    }
}
