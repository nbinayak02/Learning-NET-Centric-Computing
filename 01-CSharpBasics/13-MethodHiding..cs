using System;
namespace MethodHiding{
    class Test{
        public void Display(){
            Console.WriteLine("Test");
        }
    }

    class Program:Test{
        public new void Display(){
            Console.WriteLine("Program");
        }

        static void Main(){
            Program p = new Program();
            p.Display();
        }
    }

    
}