using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class CreditAccount : Account
    {
        double crLimit;

        public double CrLimit{
          get {  return crLimit; } 
          set { crLimit = value; } 
        }

        public CreditAccount() { }
        public CreditAccount(int id,string name , double balance,double crLimit) : base(id, name, balance)
        {
            this.crLimit = crLimit;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Credit Limit : "+crLimit);
        } 

        public override void WithDraw(double amount)
        {
            if (amount > balance + crLimit)
            {
                Console.WriteLine("Limit Crossed !");
            }
            balance-=amount;

        }
    }
}
