using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array(1D,MultiDimensional)

            int [] ar=new int[5];
            int [] ar2 = {1,3,4,6,7};
            int[] ar3 = new int[] {1,2,3,4,5,6,7};  //any number of value can be inputed

            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write(ar[i]+" ");
            }

            Console.WriteLine();

            //value read from an array and print by foreach LOOP
            foreach (int x in ar2)
            {
                Console.WriteLine(x);
            }

            //MultiDimensional Array

            int[,] Marr =  new int[3, 5];

            Marr[0,0]= 10;


            //input
            for (int i = 0; i < Marr.GetLength(0); i++)
            {
                for (int j = 0; j < Marr.GetLength(1); j++)
                {
                    Marr[i, j] = Int32.Parse(Console.ReadLine());

                }
            }

            //output
            for (int i = 0; i < Marr.GetLength(0); i++)
            {
                for (int j = 0; j < Marr.GetLength(1); j++)
                {
                    Console.Write(Marr[i,j]+" ");

                }
                Console.WriteLine() ;   
            }


            //Jagged Array -not sure about the number of values in 2nd Dimension

            int[][] arr= new int[3][];

            arr[0] = new int[4];
            arr[1] = new int[2];
            arr[2] = new int[3];

            //input
            for(int i = 0;i < arr.Length; i++)
            {
                for(int j = 0;j < arr[i].Length; j++)
                {
                    arr[i][j]  =Int32.Parse(Console.ReadLine());
                }
            }

            //Output
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
