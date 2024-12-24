using System;
using System.Linq;
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
                new Student{Name = "Dipesh", Marks = 48.30, Department = "Bsc"},
                new Student{Name = "Samir", Marks = 35.90, Department = "Bsc.CSIT"},
                new Student{Name = "Deep", Marks = 39.5, Department = "BIM"}
            };

            Console.WriteLine("\nAll student information: ");

            foreach (var a in stu_info)
            {
                Console.WriteLine(a.Name + "\t" + a.Marks + "\t" + a.Department);
            }

            //where filters the data
            var filter = from s in stu_info where s.Marks >= 40 select s;

            Console.WriteLine("\nStudents having marks >= 40: ");

            foreach (var a in filter)
            {
                Console.WriteLine(a.Name + "\t" + a.Marks + "\t" + a.Department);
            }

            //OrderBy sorts the data

            var sort = stu_info.OrderBy(s => s.Marks).ToList();

            Console.WriteLine("\nStudent sorted in ascending order by marks: ");
            foreach (var a in sort)
            {
                Console.WriteLine(a.Name + "\t" + a.Marks + "\t" + a.Department);
            }

            //GroupBy

            var group = stu_info.GroupBy(s => s.Department);

            Console.WriteLine("\nStudent grouped by Department: ");

            foreach (var g in group)
            {
                Console.WriteLine("\nDepartment = {0}", g.Key);
                Console.WriteLine("----------");
                foreach (var a in g)
                {
                    Console.WriteLine(a.Name + "\t" + a.Marks + "\t" + a.Department);
                }

            }
        }
    }
}

// Output:
// All student information:
// Binayak 45.23   Bsc.CSIT
// Abiral  50.45   BIM
// Dipesh  48.3    Bsc
// Samir   35.9    Bsc.CSIT
// Deep    39.5    BIM

// Students having marks >= 40:
// Binayak 45.23   Bsc.CSIT
// Abiral  50.45   BIM
// Dipesh  48.3    Bsc

// Student sorted in ascending order by marks:      
// Samir   35.9    Bsc.CSIT
// Deep    39.5    BIM
// Binayak 45.23   Bsc.CSIT
// Dipesh  48.3    Bsc
// Abiral  50.45   BIM

// Student grouped by Department:

// Department = Bsc.CSIT
// ----------
// Binayak 45.23   Bsc.CSIT
// Samir   35.9    Bsc.CSIT

// Department = BIM
// ----------
// Abiral  50.45   BIM
// Deep    39.5    BIM

// Department = Bsc
// ----------
// Dipesh  48.3    Bsc