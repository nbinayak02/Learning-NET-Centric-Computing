using System;
using 
using System.Collections;
using System.Collections.Generic;

namespace LINQdemo
{

    public class Student
    {
        private string name;
        private double marks;
        private string department;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

    }

    public class Program
    {
        public static void Main()
        {
            List<Student> stu_info = new List<Student>(){
                new Student{Name = "Binayak", Marks = 45.23, Department = "Bsc.CSIT"},
                new Student{Name = "Abiral", Marks = 50.45, Department = "BIM"},
                new Student{Name = "Dipesh", Marks = 48.30, Department = "Bsc"}
            };

            Console.WriteLine("All student information: ");
            foreach (var a in stu_info)
            {
                Console.WriteLine(a.Name + "\t" + a.Marks + "\t" + a.Department);
            }


        }
    }
}