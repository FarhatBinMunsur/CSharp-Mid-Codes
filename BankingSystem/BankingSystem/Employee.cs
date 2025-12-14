using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class Employee
    {
        int id;
        string name;
        double salary;
        string dept;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name { get { return name; } set { name = value;  } }
        public double Salary { get { return salary; } set { salary = value; } } 
        public string Dept { get { return dept; } set { dept = value; } }

        public Employee() { }

        public Employee(int id, string name, double salary , string dept) {
            this.id=id;
            this.name=name;
            this.salary=salary;
            this.dept = dept;
        }

        public void showinfo() {
            Console.WriteLine("ID: "+id);
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Depertment: "+dept);

        }

        public void UpdateSalary(double amnt)
        {
            salary = amnt;
        }

    }
}
