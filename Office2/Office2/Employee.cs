using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office2
{
    internal class Employee
    {

        string name;
        protected decimal salary;

        public string Name { get { return name;} }
        public decimal Salary {  get { return salary;} set { salary = value; } }
        public Employee() { }
        public Employee(string name, decimal initialsalary)
        {
            this.name = name;
            this.salary = initialsalary;
            Console.WriteLine("Employee constructed: "+ this.Name);

        }

        public void Show() {
            Console.WriteLine($"Name = {name}, Salary = {salary:0.00}");

        }


    }
}
