using System;
namespace MethodOverriding{
    public class SuperClass{
        public virtual void Display(){
            Console.WriteLine("Display method in Super class");
        }
    }

    public class BaseClass: SuperClass{
        public override void Display(){
            Console.WriteLine("Display method in base class");
        }
    }

    class Program{
        public static void Main(){

        SuperClass bc = new BaseClass();
        bc.Display();
        }
    }
}