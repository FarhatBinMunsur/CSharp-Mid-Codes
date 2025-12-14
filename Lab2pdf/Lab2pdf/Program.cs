using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2pdf
{
    internal class Program
    {
        int rec(int n)
        {
            if (n == 1) return 1;

            return n * rec(n - 1);
        }
        static void Main(string[] args)
        {
            //int n = Int32.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    if (i % 2 == 0) Console.Write(i + " ");
            //}

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(i);
            }

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 6; j++)
            //    {
            //        if (i % 2 == 0 && j % 2 == 0) Console.Write("X");
            //        else if (i % 2 == 0 && j % 2 != 0) Console.Write("O");
            //        else if (i % 2 != 0 && j % 2 == 0) Console.Write("O");
            //        else Console.Write("X");
            //    }
            //    Console.WriteLine();
            //}


            //3
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(i + j);
            //    }
            //    Console.WriteLine();
            //}

            //int oddSum = 0, evenSum = 0;

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0) evenSum += i;
            //    else oddSum += i;

            //}
            //Console.WriteLine("Sum of Even numbers: " + evenSum);
            //Console.WriteLine("Sum off Odd numbers: " + oddSum);


            int fact = 1;
            for (int i = 5; i >=1; i--)
            {
                fact *= i;
            }
            Console.WriteLine("Factorial of 5: " + fact);

            ////7

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int j = 4; j >= i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



            //int[] marks = new int[5];
            //string[] subject=new string[5] { "Physics", "Chemistry", "Biology", "Mathematics", "Computer" };
            //int sum = 0;
            //for (int i = 0; i < marks.Length; i++)
            //{
            //    Console.Write(subject[i]+": "); 
            //    marks [i] = Int32.Parse(Console.ReadLine());

            //    if (marks[i] >= 90) Console.WriteLine(subject[i] +" : A+");
            //    else if (marks[i] >=85 && marks[i] <= 89) Console.WriteLine(subject[i]+" : A");
            //    else if (marks[i] >=80 && marks[i] < 85) Console.WriteLine(subject[i] + " :B+");
            //    else if (marks[i] >=75 && marks[i] <= 79) Console.WriteLine(subject[i] + " : B");
            //    else if (marks[i] >=50 && marks[i] < 75) Console.WriteLine(subject[i] + " : C+");
            //    else Console.WriteLine(subject[i] + " : F");
            //    sum += marks[i];
            //}

            //double percentage = ((double)sum / 500) * 100;
            //Console.WriteLine("Percentage: "+percentage);



            Console.WriteLine(rec(5));






        }
    }
}
