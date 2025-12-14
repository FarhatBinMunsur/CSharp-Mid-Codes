using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3Task
{
    internal class Student
    {
        private string name;
        private string id;
        private string dept;
        private float cgpa;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Id { 
            get { return id; }
            set { id = value; }
        }

        

        public string Dept { 
            get { return dept; }
            set { dept = value; }
        }

        public float Cgpa {
            get { return cgpa; }
            set { cgpa = value; }
        }

        public Student() { }

        public Student(string name, string id,string dept,float cgpa)
        {
            this.name = name;
            this.id = id;
            this.dept = dept;
            this.cgpa = cgpa;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name : "+name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Depertment: " + dept);
            Console.WriteLine("CGPA: " + cgpa);
        }
    }
}
