using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZamanYolculugu_Odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;  //Günümüzü alıyoruz

            List<int> primeNumbers = new List<int>();   //Asal sayıları listede tutması için bir liste oluşturduk
            primeNumbers.Add(2);            //2 bilinen ve aykırı olduğu için direkt statik bir şekilde yazdık

            for (int i=3;i<=31;i++) {       //3ten sonra asal mı diye bakıyoruz
                bool isPrime = true;        //Her sayı prime olarak değişken tanımladık ve eğer bölünürse bu false olacak
                for (int j = 2; j < i; j++)
                {
                    if (i%j==0) {       //Tam bölüyor ise prime değil
                        isPrime = false;
                        break;          //Bir tane bölen var ise prime olmadığı için break ile erkenden çıkıyoruz döngüden
                    }
                }

                if (isPrime) {          //Eğer prime ise 
                    primeNumbers.Add(i);    //Asal sayılar listemize ekliyoruz
                }
            }

            DateTime endDate = new DateTime(3000,1,1);  //İstenilen son tarih 3000 yılı olduğu için ilk gününü aldık

            int[] evenNumbers = {2,4,6,8,11};           //Bir yılın maksimum 12 ayı olduğu için direkt rakamları toplamı çift olanları diziye yazdık

            for (DateTime date = today.AddDays(1); date < endDate; date = date.AddDays(1))      //Günümüzün bir gün sonrasından 3000 yılının bir gün öncesine kadar gidecek
            {
                if (evenNumbers.Contains(date.Month)) {             //Ayın rakamları toplamı çift mi diye baktık
                    if (primeNumbers.Contains(date.Day))            //Gün asal sayı mı diye baktık
                    {
                        Console.WriteLine(date.ToString("dd/MM/yyyy"));     //Günü yazdırıyoruz
                    }
                }
            }

            Console.ReadLine();

        }
    }
}
