using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    // Polinomu parçalayıp her terimi elde etmek için bir fonksiyon
    static Dictionary<int, int> ParsePolynomial(string polynomial)
    {
        var terms = new Dictionary<int, int>(); // Derece ve katsayı çiftlerini saklayacak sözlük
        var matches = Regex.Matches(polynomial, @"([+-]?\d*)x\^(\d+)|([+-]?\d*x?)"); // Her terimi bulmak için regex

        foreach (Match match in matches)
        {
            if (match.Value == "") continue; // Boş eşleşmeleri atla

            int coefficient = 1;
            int exponent = 0;

            if (match.Groups[1].Value != "")
            {
                coefficient = match.Groups[1].Value == "+" || match.Groups[1].Value == "-"
                    ? int.Parse(match.Groups[1].Value + "1")
                    : int.Parse(match.Groups[1].Value);
                exponent = int.Parse(match.Groups[2].Value);
            }
            else if (match.Groups[3].Value != "")
            {
                coefficient = match.Groups[3].Value == "+" || match.Groups[3].Value == "-"
                    ? int.Parse(match.Groups[3].Value + "1")
                    : match.Groups[3].Value.Contains("x")
                    ? (match.Groups[3].Value == "" ? 1 : int.Parse(match.Groups[3].Value))
                    : int.Parse(match.Groups[3].Value);
                exponent = match.Groups[3].Value.Contains("x") ? 1 : 0;
            }

            if (terms.ContainsKey(exponent))
                terms[exponent] += coefficient; // Aynı derecedeki katsayıları toplar
            else
                terms[exponent] = coefficient; // Yeni bir terimse ekler
        }

        return terms;
    }

    // İki polinomu toplayan fonksiyon
    static Dictionary<int, int> AddPolynomials(Dictionary<int, int> poly1, Dictionary<int, int> poly2)
    {
        var result = new Dictionary<int, int>(poly1); // İlk polinomu başlangıç olarak alır

        foreach (var term in poly2)
        {
            if (result.ContainsKey(term.Key))
                result[term.Key] += term.Value; // Aynı derece varsa katsayıları toplar
            else
                result[term.Key] = term.Value; // Yoksa yeni bir terim olarak ekler
        }

        return result;
    }

    // İki polinomu çıkaran fonksiyon
    static Dictionary<int, int> SubtractPolynomials(Dictionary<int, int> poly1, Dictionary<int, int> poly2)
    {
        var result = new Dictionary<int, int>(poly1); // İlk polinomu başlangıç olarak alır

        foreach (var term in poly2)
        {
            if (result.ContainsKey(term.Key))
                result[term.Key] -= term.Value; // Aynı derece varsa katsayıları çıkarır
            else
                result[term.Key] = -term.Value; // Yoksa negatif bir terim olarak ekler
        }

        return result;
    }

    // Polinomu okunabilir bir formata çeviren fonksiyon
    static string PolynomialToString(Dictionary<int, int> poly)
    {
        var result = "";
        foreach (var term in poly)
        {
            if (term.Value == 0) continue; // Katsayı 0 ise terimi yazmaz
            result += (term.Value > 0 && result != "" ? "+" : "")
                    + (term.Value == 1 && term.Key > 0 ? "" : term.Value.ToString())
                    + (term.Key > 0 ? "x" + (term.Key > 1 ? "^" + term.Key : "") : "");
        }
        return result == "" ? "0" : result;
    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Birinci polinomu girin veya çıkmak için 'exit' yazın:");
            string input1 = Console.ReadLine();

            if (input1.ToLower() == "exit") break; // Çıkış komutu

            Console.WriteLine("İkinci polinomu girin:");
            string input2 = Console.ReadLine();

            var poly1 = ParsePolynomial(input1); // İlk polinomu analiz eder
            var poly2 = ParsePolynomial(input2); // İkinci polinomu analiz eder

            var sum = AddPolynomials(poly1, poly2); // Polinomları toplar
            var difference = SubtractPolynomials(poly1, poly2); // Polinomları çıkarır

            Console.WriteLine("Toplam: " + PolynomialToString(sum)); // Toplamı gösterir
            Console.WriteLine("Fark: " + PolynomialToString(difference)); // Farkı gösterir
        }
        Console.ReadLine();
    }
}
