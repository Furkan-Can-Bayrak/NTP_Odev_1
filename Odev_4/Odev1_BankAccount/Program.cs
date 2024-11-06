using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1_BankAccount
{
    class Account {
        private string accountNumber;
        private decimal balance;

        public Account(string accountNumber, decimal balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }


       private decimal Balance {
            get { return balance; }
            set { balance = value; }
        }

        public void paraYatir(decimal miktar) {
            Balance += miktar;
            Console.WriteLine(miktar+" lira para yatırıldı");
        }

        public void paraCek(decimal miktar) {
            if (balance - miktar >= 0)
            {
                Balance -= miktar;
                Console.WriteLine(miktar + " lira para çekildi");
            }
            else {
                throw new Exception();
            }
            
        }

        public void bakiyeBilgisi() {
            Console.WriteLine("Bakiye: "+Balance);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account ac = new Account("2fwew42",15000);
            ac.paraCek(14500);
            ac.paraYatir(100);
            ac.bakiyeBilgisi();
            Console.ReadLine();
        }
    }
}
