using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Class2Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////infinty loop- for loop er () e kichu na likhle always true
            //int i = 0;

            //for ( ; ; )
            //{
            //   Console.WriteLine(i+" Mahir");
            //   i++;
            //}

            ////infinty loop - while()
            //while (true)
            //{
            //    Console.WriteLine("Hello");

            //}

            //infinty loop - do .. while()
            //do
            //{
            //    Console.WriteLine("Kaniz");

            //}
            //while (true);

            //Take user input until user inputs a value greater than 10
            int x;
            do
            {

                x=int.Parse(Console.ReadLine());
                if(x<10)Console.WriteLine("Less than 10.Insert Again!");

            }
            while (x<10);


            //ternary operator
            int y=int.Parse(Console.ReadLine());
            Console.WriteLine(y%2==0?"EVEN" : "ODD");



            //if divided by 2-DB2,if divided by 3-DB3,else ND

            Console.WriteLine(y%2==0?"DB2" : ( y%3==0? "DB3" : "ND"));


            int z = int.Parse(Console.ReadLine());

            z = (z == 0 ? 9 : 7);
            Console.WriteLine("Z= "+z);


        }
    }
}
