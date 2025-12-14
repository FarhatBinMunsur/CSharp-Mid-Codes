using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace LAB2Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //2
            for(int i = 1; i <= 5; i++)
            {
                for(int j = i; j <= i + 4; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            //4
            int oddSum = 0,evenSum = 0;
            for(int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0) evenSum += i;
                else oddSum += i;

            }
            Console.WriteLine("Sum of ODD : "+oddSum);  
            Console.WriteLine("Sum of Even: "+evenSum);

            //5

            for(int i = 1; i <= 5; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(i);
            }

            //6

            int n=int.Parse(Console.ReadLine());
            int result = 1;
            for (int i = n; i >= 1; i--)
            {
                result *= i;
            }
            Console.WriteLine(result);
            

        }
    }
}
