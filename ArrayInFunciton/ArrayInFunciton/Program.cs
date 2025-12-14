using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInFunciton
{
    internal class Program
    {

        static void Summation(int [] a) {
            int sum = 0;
            
            foreach (int x in a) {
                sum += x;

            }

            Console.WriteLine("Result: "+sum);
        }

        static void Summation1(params int[] arr)
        {
            int sum = 0;
            foreach (int x in arr) {
                sum += x;
            }

            Console.WriteLine("Result2: "+sum);
        }
        static void Main(string[] args)
        {
            Summation(new int[] { 10, 12, 14, 56 });
            Summation(new int[5] { 10, 17, 12, 14, 56 });

            //Using params - array hisebe value pass kra lagbe na
            Summation1(1,2,3,4,5,6,7);
        }
    }
}
