using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LAB3Task
{
    internal class Course
    {

        private string courseName;
        private string courseCode;
        private int courseCredit;

        public string CourseName 
        {
           get { return courseName; }
            set { courseName = value; }
        }

        public string CourseCode
        {
            get { return courseCode; }
            set { courseCode = value; }
        }

        public int CourseCredit
        {
            get { return courseCredit; }
            set { courseCredit = value; }
        }

        public Course() { }

        public Course(string courseName,string courseCode,int courseCredit) { 
            this.courseName = courseName;
            this.courseCode = courseCode;
            this.courseCredit = courseCredit;
        }

        public void ShowCourseInfo()
        {
            Console.WriteLine("Course Name: "+courseName);
            Console.WriteLine("Course Code: "+courseCode);
            Console.WriteLine("Course Credit: "+courseCredit);
        }

    }
}
