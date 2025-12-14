using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LAB3Task
{
    internal class Account
    {
        private string acccName;
        private string accID;
        private int balance;

        public string AccName
        {
            get { return acccName; }
            set { acccName = value; }
        }

        public string AccID
        { 
            get { return accID; } 
            set { accID = value; } 
        }

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
         
        public Account() { }
        public Account(string accName,string accID,int bal) {
            this.acccName = accName;
            this.accID = accID;
            balance=bal;

        }

        public void ShowInfo()
        {
            Console.WriteLine("Account Name : "+acccName);
            Console.WriteLine("Acccount ID: "+accID);
            Console.WriteLine("Balance: "+balance);
        }

        public void Deposit(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid! ");
                return;
            }
            balance += amount;
        }

        public void Withdraw(int amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Invalid! ");
                return ;
            }
            balance-=amount;
            
        }
    }
}
