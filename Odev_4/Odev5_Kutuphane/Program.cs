using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5_Kutuphane
{

    class Book {
        public string name { get; set; }
        private int pageNumber { get; set; }


        public Book(string name, int pageNumber) {
            this.name = name;
            this.pageNumber = pageNumber;
        }
    }


    class Kutuphane{
       public List<Book> books = new List<Book>();


        public void kitaplariListele() {
            foreach (Book book in books) {
                Console.WriteLine(book.name);
            }
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Kutuphane kutuphane = new Kutuphane();
            Book sucVeCeza = new Book("Suç ve Ceza",400);
            Book agirYasam = new Book("Ağır Yaşam",200);
            Book hormonGucu = new Book("Hormonların GÜcü",384);

            kutuphane.books.Add(sucVeCeza);
            kutuphane.books.Add(agirYasam);
            kutuphane.books.Add(hormonGucu);

            kutuphane.kitaplariListele();
            Console.ReadLine();
        }
    }
}
