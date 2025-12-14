using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1
            //Console.WriteLine("Hello");
            //Console.Write("Farhat Bin Munsur");

            // //2,3
            // double a = Double.Parse(Console.ReadLine());
            //double b = Double.Parse(Console.ReadLine());
            // Console.WriteLine($"Result= {a+b}");

            // Console.WriteLine($"Result={(double)a / b}");

            //4
            //Console.WriteLine(-5 + 8 * 6);
            //Console.WriteLine((55 + 9) % 9);
            //Console.WriteLine(20 + -3 * (double)5 / 8);
            //Console.WriteLine(5 + (double)15 / 3 * 2 - (double)8 % 3);


            //5
            int x = Int32.Parse(Console.ReadLine()), y = Int32.Parse(Console.ReadLine());
            int sum = x + y;
            int Subtract = x - y;
            int multiply = x * y;
            double division = (double)x / y;
            double remainder = x % y;
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Subtraction = {Subtract}");
            Console.WriteLine($"Multiplication= {multiply}");
            Console.WriteLine("Division = {0}",division);
            Console.WriteLine($"Remainder = {remainder}");

            ////6
            //double d = ((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5));
            //Console.WriteLine(d);

            //7
            //double width = 5.6, height = 8.5;
            //double Area = (width * height);
            //double perimeter = 2 * (width + height);

            //Console.WriteLine("Area is {0}*{1} = {2:F2}", width, height, Area);
            //Console.WriteLine("Perimeter is 2*({0}+{1})={2:F2}", width, height, perimeter);

            ////8
            //Console.Write("First integer: ");
            //int fi = Int32.Parse(Console.ReadLine());

            //Console.Write("Second integer: ");
            //int si = Int32.Parse(Console.ReadLine());

            //if(fi<si) Console.WriteLine($"{fi}!={si}\n{fi}<{si}\n{fi}<={si}");
            //else if(fi>si) Console.WriteLine($"{fi}!={si}\n{fi}>{si}\n{fi}>={si}");
            //else Console.WriteLine($"{fi}={si}");


            //9
            //string s = Console.ReadLine();
            //string s2 = "";

            //for (int i = s.Length - 1; i >= 0; i--)
            //{
            //    s2 += s[i];
            //}

            //Console.WriteLine(s.Reverse().ToArray());

            ////10

            //double d1 = Double.Parse(Console.ReadLine()), d2 = Double.Parse(Console.ReadLine());
            //if (d1 > 0 && d1 < 1 && d2 > 0 && d2 < 1) Console.WriteLine("Between 0 and 1");
            //else Console.WriteLine("Not Between 0 and 1");


            //int a = 5;
            //double d = 20.34;
            //float f = 2.343f;

            // d = a;  //implicit  casting
            // a = (int)d;  //explicit casting

            // //Divide two integer

            // int a2 = 10, b = 3;
            // double result = a2 /(float)b;
            // Console.WriteLine(result);

            // string name = Console.ReadLine();
            // Console.WriteLine(name);

            // string input = Console.ReadLine();

            // int x=int.Parse(input);
            // int y=Int32.Parse(input);
            // int z=Convert.ToInt32(input);

            // Console.WriteLine("{0},{1},{2}",x,y,z);

            // Console.WriteLine(9 > 8?9:8);

        }
    }
}
