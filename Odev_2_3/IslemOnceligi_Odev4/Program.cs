using System;
using System.Collections.Generic;

class Program
{
    // İşlem önceliğini belirlemek için bir fonksiyon tanımlıyoruz
    static int GetPrecedence(char op)
    {
        if (op == '+' || op == '-') return 1; // Toplama ve çıkarma en düşük öncelikte
        if (op == '*' || op == '/') return 2; // Çarpma ve bölme orta öncelikte
        if (op == '^') return 3;              // Üs alma en yüksek öncelikte
        return 0;
    }

    // Verilen operatörün soldan mı sağdan mı öncelikli olduğunu belirleyen fonksiyon
    static bool IsRightAssociative(char op)
    {
        return op == '^'; // Üs alma işlemi sağdan önceliklidir
    }

    // İki sayı ve bir operatörü alıp sonucu hesaplayan bir fonksiyon
    static double ApplyOperation(double a, double b, char op)
    {
        switch (op)
        {
            case '+': return a + b;
            case '-': return a - b;
            case '*': return a * b;
            case '/': return a / b;
            case '^': return Math.Pow(a, b);
        }
        return 0;
    }

    // Shunting Yard algoritması ile işlemleri ayrıştıran fonksiyon
    static double EvaluateExpression(string expression)
    {
        Stack<double> values = new Stack<double>();     // Sayılar için bir yığın oluşturuyoruz
        Stack<char> operators = new Stack<char>();      // Operatörler için bir yığın oluşturuyoruz

        for (int i = 0; i < expression.Length; i++)
        {
            // Boşlukları atlıyoruz
            if (expression[i] == ' ') continue;

            // Karakter bir sayı ise
            if (char.IsDigit(expression[i]))
            {
                double value = 0;

                // Birden fazla basamaklı sayılar için tüm rakamları okuyup topluyoruz
                while (i < expression.Length && char.IsDigit(expression[i]))
                {
                    value = (value * 10) + (expression[i] - '0');
                    i++;
                }

                values.Push(value); // Sayıyı sayılar yığınına ekliyoruz
                i--; // Döngüde bir adım geri gidiyoruz çünkü bir karakter fazla ilerledik
            }
            else if (expression[i] == '(')
            {
                operators.Push(expression[i]); // Aç parantezi operatör yığınına ekliyoruz
            }
            else if (expression[i] == ')')
            {
                // Kapanan parantezi görene kadar işlemleri değerlendiriyoruz
                while (operators.Peek() != '(')
                {
                    double val2 = values.Pop();
                    double val1 = values.Pop();
                    char op = operators.Pop();

                    Console.WriteLine($"{val1} {op} {val2}");
                    values.Push(ApplyOperation(val1, val2, op));
                }
                operators.Pop(); // Aç parantezi yığından çıkarıyoruz
            }
            else
            {
                // Operatörün önceliğine göre işlem sırasını kontrol ediyoruz
                while (operators.Count > 0 && GetPrecedence(operators.Peek()) >= GetPrecedence(expression[i]) && !IsRightAssociative(expression[i]))
                {
                    double val2 = values.Pop();
                    double val1 = values.Pop();
                    char op = operators.Pop();

                    Console.WriteLine($"{val1} {op} {val2}");
                    values.Push(ApplyOperation(val1, val2, op));
                }

                operators.Push(expression[i]); // Operatörü yığına ekliyoruz
            }
        }

        // Geriye kalan tüm işlemleri değerlendiriyoruz
        while (operators.Count > 0)
        {
            double val2 = values.Pop();
            double val1 = values.Pop();
            char op = operators.Pop();

            Console.WriteLine($"{val1} {op} {val2}");
            values.Push(ApplyOperation(val1, val2, op));
        }

        return values.Pop(); // Nihai sonucu döndürüyoruz
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Bir matematiksel ifade girin:");
        string expression = Console.ReadLine(); // Kullanıcıdan matematiksel ifadeyi alıyoruz

        double result = EvaluateExpression(expression); // İfadeyi değerlendiriyoruz
        Console.WriteLine($"Sonuç: {result}"); // Sonucu ekrana yazdırıyoruz
        Console.ReadLine();
    }
}
