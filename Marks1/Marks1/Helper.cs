using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Marks1
{
    internal class Helpers
    {
        public static int SumAll(params int[] numbers) {

            int sum = 0;

            foreach (int number in numbers) { 
                sum+= number;  
        }
            return sum;
            
        }

        public static void AddBonus(ref int total,int bonus){
            total += bonus;
        }
        static void Main(string[] args)
        {
            int[][]Student=new int [3][];

            Student[0] = new[] { 50, 60 };
            Student[1] = new[] {70,75};
            Student[2] = new[] { 80 };

            for (int i = 0; i < Student.Length; i++)
            {
                Console.Write("Student " + i +": ");
                
                for (int j = 0; j < Student[i].Length; j++) {

                    Console.Write(Student[i][j] + " ");
                }
                Console.WriteLine("| Total = "+ Helpers.SumAll(Student[i]));
            }
            int total = Helpers.SumAll(Student[2]);
            AddBonus(ref total,5);
            Console.WriteLine("Student 2(after bonus) Total = "+total);
            }

    }
}
