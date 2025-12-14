using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    internal class Program
    {
        enum month
        {
            january = 1,
            february,
            march,
            april,
            may
        }
        enum month2
        {
            january = 1,
            february=3,
            march=5,
            april=7,
            may=9
        }
        
        static void Main(string[] args)
        {

            Console.WriteLine((int)month.april);

            int input=Int32.Parse(Console.ReadLine());
            Console.WriteLine((month)input);

        }
    }
}
