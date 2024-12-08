using System;
namespace MethodOverloading{
    class Multiplication{
        public int mul(int a, int b){
            return a*b;
        }

        public int mul(int a, int b, int c){
            return a*b*c;
        }

        public int mul(int a, int b, int c, int d){
            return a*b*c*d;
        }
    }

    class Program{
        static void Main(){
            Multiplication m = new Multiplication();
            Console.WriteLine(m.mul(2,3));
            Console.WriteLine(m.mul(2,3,4));
            Console.WriteLine(m.mul(2,3,4,5));

        }
    }
}