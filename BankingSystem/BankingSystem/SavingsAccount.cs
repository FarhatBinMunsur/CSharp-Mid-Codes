using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class SavingsAccount:Account
    {
        double depositLimit;

        public double DepositLimit {  get { return depositLimit; } set { depositLimit = value; } }

        public SavingsAccount() { }

        public SavingsAccount(int id,string name , double balance ,double depositLimit) : base(id,name,balance) { 
            this.depositLimit = depositLimit; 
        }

        //if we write new keyword instead of override ,we will see only infos of Account class(3 info)
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Deposit Limit : {depositLimit}");
        }

        public override void Deposit(double amount) {
            if (amount > depositLimit)
            {
                Console.WriteLine("Limit Crossed !");
                return;
            }
            balance += amount;
        }


    }
}
