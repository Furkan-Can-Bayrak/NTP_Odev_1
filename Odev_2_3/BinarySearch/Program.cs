using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch_Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dizinizin boyutunu girin: ");
            int limit = Convert.ToInt32(Console.ReadLine());    //Dizinin boyutunu istiyoruz
            int[] array = new int[limit];                       //Aldığımız boyut ile arrayi boyutu ile beraber tanımladık. İçi boş
            for (int i = 0; i<array.Length;i++) {               //Arrayin içini doldurmak için arrayin boyutu kadar turladık
                Console.Write((i+1)+". indexe değer verin: ");  //Kullanıcı hangi indexe değer verdiğini anlasın diye işini kolaylaştırdık
                array[i] = Convert.ToInt32(Console.ReadLine()); //Yazdığı değeri arraye yerleştirdik
            }
            Console.WriteLine("-------- DİZİ TANIMLANDI --------");
            Array.Sort(array);      //Arrayi küçükten büyüğe doğru sıralar

            Console.Write("Dizinin içinde aranmasını istediğiniz sayıyı yazın: ");
            int targetNumber = Convert.ToInt32(Console.ReadLine());


            int end = limit-1;       //Arrayın limitini alıyoruz
            int start = 0;           //Arrayın ilk indisini alıyoruz yani 0
            bool isFound = false;    

            if (array[start] == targetNumber || array[end] == targetNumber)
            {
                isFound = true;
            }

            while (end - start > 1) {
                int diff = end - start;
                int index = start + diff / 2;

                if (array[index] == targetNumber)
                {
                    isFound = true;
                    break;
                }
                else if (array[index] > targetNumber)
                {
                    end = index;
                }
                else {
                    start = index;
                }



            }


            if (isFound)
            {
                Console.WriteLine("Aradığınız sayı dizide var.");
            }
            else {
                Console.WriteLine("Aradığınız sayı dizide yok.");
            }

            Console.Read();
        }
    }
}
