using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Mark(0-100): ");
           int gr=Convert.ToInt16(Console.ReadLine())/10;

            Console.Write("Grade: ");

            switch (gr) { 
                case 10:
                    Console.WriteLine("A+");
                    break;
                case 9:
                    Console.WriteLine("A+");
                    break;
                case 8:
                    Console.WriteLine("A");
                    break;
                case 7:
                    Console.WriteLine("B+");
                    break;
                case 6:
                    Console.WriteLine("B");
                    break;
                case 5:
                    Console.WriteLine("C+");
                    break;
                case 4: 
                    Console.WriteLine("C");
                    break;
                case 3: 
                    Console.WriteLine("D");
                    break;  
                default:
                    Console.WriteLine("Fail");
                    break;
            }
        }
    }
}
