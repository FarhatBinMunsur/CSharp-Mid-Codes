using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LAB3Task
{
    internal class Triangle
    {
        private int x;
        private int y;
        private int z;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int C
        {
            get { return z; }
            set { z = value; }
        }

        public Triangle() { }
        public Triangle(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void ShowInfo()
        {
            Console.WriteLine("X: " + x);
            Console.WriteLine("Y: " + y);
            Console.WriteLine("Z: " + z);
        }
        public void TestTriangle()
        {
            if (x == y && y == z) Console.WriteLine("Equilateral");
            else if (x == y || x == z || y == z) Console.WriteLine("Isosceles");
            else Console.WriteLine("Scalene");
        }
    }
}
