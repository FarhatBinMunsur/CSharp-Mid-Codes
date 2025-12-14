using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function1
{
    internal class Program
    {
        static void Add(int a,int b) {
            Console.WriteLine("Result = {0}",a+b);
        }

        //Function Overloading 
        static void Add(int a, int b,int c)
        {
            Console.WriteLine("Result = {0}", a + b + c);
        }

        //Optional parameter
        static void Add(int a,int b,int x=0,int y=0) {
            Console.WriteLine($"Result is :{a+b+x+y}");
            
        }

        static int Multiplication(int a, int b, int x = 1, int y = 1)
        {
            Console.Write($"Result is :");
                return a*b*x*y;

        }

        static void PrintName(string f,string l) {
            Console.WriteLine("FName : "+f);
            Console.WriteLine("LName :"+l);

        }

        static int subtraction(int a,int b) {
            return a - b;
        }

        static void Main(string[] args)
        {
            Program.Add(30,23);
            Add(20,30,34);
            Add(12, 32);

            //optional parameter functions
            Add(12,34,2,3);
            Console.WriteLine(Multiplication(12, 3));

            //positional parameter passing
            PrintName("Farhat","Mahir");
            //name parameter passing
            PrintName(l:"Mahir",f:"Farhat");


            Console.WriteLine(subtraction(20, 12));
            Console.WriteLine(subtraction(b:20,a:12));
        }
    }
}
