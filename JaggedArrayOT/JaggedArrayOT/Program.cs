using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayOT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] ar = new int[4][] {
                new []{5,6,7,8 },
                new []{0,0},
                new []{10,11,12},
                new []{0}

            };

            for (int i = 1; i < ar.Length; i += 2)
            {
                for (int j = 0; j < ar[i].Length; j++)
                {
                    ar[i][j] = ar[i - 1][j] * 2;
                }
            }

            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = 0; j < ar[i].Length; j++)
                {
                    Console.Write(ar[i][j] + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine();

            //prevQues
            int[][] myArray = new int[4][];
            myArray[0] = new int [] { 1, 3, 5, 7, 9, 2 };
            myArray[1] = new int [4];
            myArray[2] = new int[] { 2,4,6,8,5,3 };
            myArray[3] = new int [4];

            for(int row = 0;  row< 4;  row+= 2)
            {
                for(int col = 1; col < myArray[row].Length; col++)
                {
                    Console.Write("{0} ", myArray[row][col]);    //placeholder printing of a value
                }
                Console.WriteLine();
            }

            for (int index = 0; index < myArray[1].Length;index++) {

                myArray[1][index]=myArray[0][index+1]*2;
            }

            for(int index = 0; index < myArray[3].Length; index++)
            {
                myArray[3][index] = myArray[2][index] + myArray[2][index + 2];

            }

            for (int row = 1; row < 4; row += 2)
            {
                for(int column = 0; column < myArray[row].Length; column++)
                {
                    Console.Write("{0} ", myArray[row][column]);
                }
                Console.WriteLine();
                
            }

            int[,] ar10 = new int[,] { {1,2,5},{3,4,4},{1,2,3} };

        }
    }
}
