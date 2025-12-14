using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office2
{
    internal class Manager:Employee
    {
        public Manager() { }

        public Manager(string name,decimal initialSalary):base(name,initialSalary)
        {
            Console.WriteLine("Manager constructed: "+Name);
        }

        public void GiveRaise(decimal amount)
        {
            if (amount > 0) salary += amount;
        }



    }
}
