using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeModifier
{
    internal class Program
    {

        static void changevalue(out int x,out int y) {
            y = 10;
            x = 12;
        }

        static void changevalue2(ref int x, ref int y)
        {
            //y = 10;
            //x = 12;
        }
        static void Main(string[] args)
        {
            int x, y;
            changevalue(out x,out y);
            //Console.WriteLine("{0} {1}",x,y);
            //changevalue2(ref x, ref y);
            //Console.WriteLine("{0} {1}", x, y);


            var a = 12;
            var b = 3.0;

            var c = "Mahir";

            double sum = a + b;
            Console.WriteLine(sum);

            Console.WriteLine(c);
            dynamic a1 = 12, a2 = 15.00;
            int sum2 = a1 + a2;

        }
        

        
    }
}
