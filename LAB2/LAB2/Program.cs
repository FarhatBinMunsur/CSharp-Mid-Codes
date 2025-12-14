using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Round(3.333,2));

            int asc = Console.Read();
            Console.WriteLine(asc);
            Console.ReadLine();         //Clear the buffer

            Console.WriteLine("ENter Two Number: ");

            Console.WriteLine(Convert.ToInt32(Console.ReadLine()) + Convert.ToInt32(Console.ReadLine()));
        }
    }
}
