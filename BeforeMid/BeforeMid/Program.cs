using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BeforeMid
{
    internal class Program
    {

        static void Printname(string f, string l)
        {
            Console.WriteLine(f + " " + l);
        }
        static void Main(string[] args)
        {
            //    int i = 0, j = 1, k;
            //    for (; i < 5; i++)
            //    {
            //        k = j++ + ++j;
            //        Console.Write(k + " ");

            //    }

            //    int[] ar = new int[] { 1, 2, 3 };

            //    int[][] ar1 = new int[4][];
            //    ar1[0] = new int[] { 1, 3 };
            //    ar1[1] = new int[] { 2, 3, 5, 3 };
            //    ar1[2] = new[] { 23, 5, 63, 3, 4 };
            //    ar1[3] = new[] { 12, 3, 3 };

            //    int[][] ar3 = new int[4][]
            //    {
            //       new int[] { 1, 3 },
            //    new int[] { 2, 3, 5, 3 },
            //    new[] { 23, 5, 63, 3, 4 },
            //    new[] { 12, 3, 3 },
            //};



            //    int[] arr = { 1, 2, 3, 4, 5 };

            //    var ar5 = new[] { 1, 2, 3, 10000000000 };
            //    Console.WriteLine(ar5.GetType());


            //Console.WriteLine(Convert.ToString(Console.ReadKey()));

            //Console.WriteLine(Convert.ToInt32(Console.ReadLine()));

            //Console.WriteLine(Math.Round(2.3326,3));

            //int x = Int32.Parse(Console.ReadLine());

            //Console.WriteLine(x % 2==0?"DB2":x%3==0?"DB3": "ND");

            //int[,] a = new int[4,2];
            //a[0,1] = 1;


            //int[][] ar1 = new int[4][];
            //    ar1[0] = new int[] { 1, 3 };
            //ar1[1] = new int[] { 2, 3, 5, 3 };
            //ar1[2] = new[] { 23, 5, 63, 3, 4 };
            //ar1[3] = new int []{ 12, 3, 3 };
            //Console.WriteLine();

             Printname(l:"F",f:"Mahir");

            int x = 5;
            int y = ++x;
            Console.WriteLine(x+y);
            
        }
    }
}
