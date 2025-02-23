using System;
namespace Delegates
{

    class Test
    {

        //these are the delegates
        public delegate void multiply(int a, int b);
        public delegate void divide(int a, int b);

        //these are the methods we're passing to delegates
        //so these methods should also have same signature

        public static void product(int a, int b){
            Console.WriteLine(a*b);
        }

        public static void division(int a, int b){
            Console.WriteLine(a/b);
        }

        static void Main(){

            // Test t = new Test();

            //making delegates objects and passing methods
            multiply m = new multiply(product);
            divide d = new divide(division);

            m(4,2);
            d(4,2);
        }
    }
}