using System;
using System.Linq;
using System.Collections.Generic;

namespace LambdaExp
{

    public class Program
    {

        public static void Main()
        {

            //use of where in lambda

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            Console.WriteLine("Even numbers from array are: ");

            foreach (int n in evenNumbers)
            {
                Console.WriteLine(n);
            }

            //use of select in lambda

            List<string> names = new List<string>(){
                "hydrogen","helium","lithium","berrillium","boron","carbon","nitrogen","oxygen"
            };

            var upperCaseNames = names.Select(n => n.ToUpper());

            Console.WriteLine("Elements in upper case are: ");

            foreach (var s in upperCaseNames)
            {
                Console.WriteLine(s);
            }

            //use of orderby and orderbydescending in lambda
            int[] id = new int[] { 12, 56, 43, 97, 2, 45, 78 };

            var asc = id.OrderBy(i => i);
            var desc = id.OrderByDescending(i => i);

            Console.WriteLine("Numbers in ascending: ");

            foreach(var a in asc){
                Console.Write(a+" ");
            }

            Console.WriteLine("\nNumbers in descending: ");

            foreach(var d in desc){
                Console.Write(d+" ");
            }

            //combining all

            var all = numbers.Where(x=>x%2==0).Select(x=>x*x).OrderByDescending(x=>x);

            Console.WriteLine("\nAdvance Lamda: ");

            foreach(var a in all){
                Console.Write(a+" ");
            }

        }

    }

}