using System;

namespace BeforeMid2
{
    class Animal  // Base class (parent) 
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public new void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0) Console.Write("X");
                    else if (i % 2 != 0 && j % 2 == 0) Console.Write("O");
                    else if (i % 2 == 0 && j % 2 != 0) Console.Write("O");
                    else Console.Write("X");
                }
                Console.WriteLine();
            }
            //int[] ar = new int[3];
            //Console.WriteLine(ar[1]);

            ////Console.ReadKey();
            //Console.WriteLine(int.Parse(Console.ReadLine()));

            //Console.WriteLine(Console.ReadLine().ToUpper());
            //Console.WriteLine(Console.ReadLine().Trim());

            //long a = (long)Math.Pow(2, 32);
            //Console.WriteLine(a);

            int x = Int32.Parse(Console.ReadLine());

            //switch (x)
            //{
            //    case 1:
            //        Console.WriteLine("ONE");
            //        break;
            //    case 2:
            //        Console.WriteLine("TWO");
            //        break;
            //    default:
            //        Console.WriteLine("none");
            //        break;

            //}


            //int y= Int32.Parse(Console.ReadLine());

            //y = (y == 9 ? 10 : 11);
            //Console.WriteLine(y);

            //Console.WriteLine(y%2==0?"DB2":(y%3==0?"DB3": "ND"));


            int n;
            do
            {
                n = Int32.Parse(Console.ReadLine());

            }
            while (n < 20);
        }
    }
}
