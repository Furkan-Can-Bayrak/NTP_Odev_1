using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_3_2
{

    struct ComplexNumber
    {
        // Gerçek ve sanal (imajiner) kısımlar
        public double Real { get; set; }
        public double Imaginary { get; set; }

        // Yapıcı metot: Karmaşık sayıyı oluşturur
        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // Toplama işlemi: İki karmaşık sayıyı toplar
        public ComplexNumber Add(ComplexNumber other)
        {
            return new ComplexNumber(Real + other.Real, Imaginary + other.Imaginary);
        }

        // Çıkarma işlemi: İki karmaşık sayı arasındaki farkı hesaplar
        public ComplexNumber Subtract(ComplexNumber other)
        {
            return new ComplexNumber(Real - other.Real, Imaginary - other.Imaginary);
        }

        // Karmaşık sayıyı (a + bi) formatında döndürür
        public override string ToString()
        {
            string sign = Imaginary >= 0 ? "+" : "-"; // Sanal kısmın işareti
            return $"{Real} {sign} {Math.Abs(Imaginary)}i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
