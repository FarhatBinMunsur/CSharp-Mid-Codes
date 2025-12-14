using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class Account
    {
        private int id;
        protected string name;
        protected double balance;

        public int ID {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public Account() { }

        public Account(int id, string name, double balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;

            count++;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("ID : " + this.id);
            Console.WriteLine("NAME: " + this.Name);
            Console.WriteLine("Balance : " + this.balance);
        }

        public virtual void WithDraw(double amnt){
            if (amnt > balance)
            {

                Console.WriteLine("Invalid! ");
                return;
            }
            balance-=amnt;
        }

        public virtual void Deposit(double amnt)
        {
            if (amnt<0) {
                Console.WriteLine("Invalid! ");
            }

            balance+=amnt;
        }

        //class based method
        public static void ConvertToUSD(double amnt)
        {
            Console.WriteLine(Math.Floor(amnt/122));
           
        }

        public static int count=0;


    }

}
