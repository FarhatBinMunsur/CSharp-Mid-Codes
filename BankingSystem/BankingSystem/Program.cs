using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account Mahir=new Account(01,"Mahir",15000);
            Mahir.ShowInfo();
            Mahir.WithDraw(1000);
            Console.WriteLine();
            Mahir.ShowInfo();

            Console.WriteLine();

            Employee e1 = new Employee(6, "Labib", 19000, "Accounts");
            e1.UpdateSalary(20000);
            e1.showinfo();

            Account A2 = new SavingsAccount(02, "Rahim", 12000, 500);
            A2.ShowInfo();

            A2.Deposit(500);

            CreditAccount c1 = new CreditAccount(3, "Hamid", 50000, 6000);
            c1.ShowInfo();
            c1.WithDraw(56000);
            c1.ShowInfo();

            Account.ConvertToUSD(A2.Balance);

            Console.WriteLine("Total Accounts: "+Account.count);

            Account a3=new Account();

            //Console.WriteLine();
            //a3.ID = 4;
            //Console.WriteLine(a3.ID);




        }
    }
}
