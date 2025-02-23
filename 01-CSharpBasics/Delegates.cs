using System;
namespace DelegatesAndEvents{

    class Program{

        public delegate void Calculation(int a, int b);

        public void Addition(int a, int b){
            Console.WriteLine("Sum is: ",a+b);
        }

        public void Subtraction(int a, int b){
            Console.WriteLine("Difference is: ",a-b);
        }

        public void Multiplication(int a, int b){
            Console.WriteLine("Product is: ",a*b);
        }

        public static void Main(){
            Program p = new Program();
            Calculation c = new Calculation(p.Addition);
            c += p.Multiplication;
            c += p.Subtraction;
            c.Invoke(4,2);
            // Console.ReadKey();
            
        }

    }

}