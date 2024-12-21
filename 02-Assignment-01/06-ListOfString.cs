using System;
using System.Linq;
using System.Collections;

namespace ListOfStudents{
    public class Student{
        public static void Main(){

            ArrayList stu = new ArrayList();
            stu.Add("Binayak");
            stu.Add("Deep");
            stu.Add("Abiral");
            stu.Add("Samir");
            stu.Add("Dipesh");

            Console.WriteLine("All students in List: ");

            foreach(string s in stu){
                Console.WriteLine(s);
            }

            stu.Remove("Samir");

            Console.WriteLine("\nUpdated List: ");

            foreach(string s in stu){
                Console.WriteLine(s);
            }

            stu.Sort();

            Console.WriteLine("\nStudents in alphabetical order: ");

            foreach(string s in stu){
                Console.WriteLine(s);
            }

            string str = "Samir";
            if(stu.Contains(str)){
                Console.WriteLine("\n{0} is in the list",str);
            } else{
                Console.WriteLine("\n{0} is not in the list",str);
            }

        }
    }
}