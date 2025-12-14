using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Manager m1 = new Manager("Tony Stark",25000.00m);
            m1.GiveRaise(1500.00m);
            m1.Show();
        }
    }
}
