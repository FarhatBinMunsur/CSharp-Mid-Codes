using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(i);
            }

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        //if (i == j) Console.Write(j);
            //        //else Console.Write(" ");
            //        Console.Write((i == j) ? j.ToString() : " ");
            //    }
            //    Console.WriteLine();

            //}

            //concept of array

            //int s1, s2, s3, s4, s5;
            //s1 = int.Parse(Console.ReadLine());
            //s2 = int.Parse(Console.ReadLine());
            //s3 = int.Parse(Console.ReadLine());
            //s4 = int.Parse(Console.ReadLine());
            //s5 = int.Parse(Console.ReadLine());


            //int[] array =new int[5];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());

            //}

            //foreach(int x in array)
            //{
            //    Console.WriteLine(x);
            //}


            int[] ar=new int[5];
            int[] ar2 = new int[5] {1,2,3,4,5};
            int[] ar3 = new int[] { 1, 2, 3 };
            int[] ar5 = new[]{1};

            int[] ar6 = {1,2};
            int[] ar7;
            //ar6[2] = 14;

            int[][] ar8 = new int[3][]
            {
                new []{1,2,3},
                new []{1,2 },
                new []{1}
            };

            int[][] ar9 = new int[3][];

            ar9[0] =new []{1,2,3};

            ar9[1] = new[] { 1, 2, 3 };

            ar9[2] = new[] { 1, 2, 3 };

            //for (int i = 0; i < 3; i++)
            //{
            //    for(int j=0; j < ar9[i].Length; j++)
            //    {
            //        Console.Write(ar9[i][j]+" ");
            //    }
            //    Console.WriteLine();
            //}

            int[][] myArray=new int[4][];

            myArray[0]=new int[] {1,3,5,7,9,2};
            myArray[1] = new int[4];
            myArray[2] = new int[] { 2, 4, 6, 8, 5, 3 };
            myArray[3] = new int[4];

            for(int r = 0; r < 4; r+=2)
            {
                for(int col = 1; col < myArray[r].Length; col++)
                {
                    Console.Write("{0} ", myArray[r][col]);
                }
                Console.WriteLine();
            }

            for(int i = 0; i < myArray[1].Length; i++)
            {
                myArray[1][i] = myArray[0][i + 1] * 2;
            }

            for (int i = 0; i < myArray[3].Length; i++)
            {
                myArray[3][i] = myArray[2][i] + myArray[2][i+2];
            }

            for (int i = 1; i < 4; i += 2)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write("{0} ", myArray[i][j]);
                }

                Console.WriteLine();


            }















            




        }
    }
}
