using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student s1=new Student("Mahir","S1","CSE",3.98f);
            s1.ShowInfo();
            

            Triangle T1=new Triangle(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()));
            T1.ShowInfo();
            T1.TestTriangle();

            Course c1 = new Course("Object Oriented Programming 2", "CS3102", 3);
            c1.ShowCourseInfo();

            Account a1 = new Account("Mahir", "A1", 10000);
            a1.ShowInfo();
            a1.Withdraw(500);
            a1.Deposit(5000);
            a1.ShowInfo();
        }
    }
}
