using System;
namespace Multicasting{
    class Test{
        public delegate void rectangle(double l, double b);

        public void area(double a, double b){
            Console.WriteLine("Area: {0}",a*b);
        }

        public void perimeter(double a, double b){
            Console.WriteLine("Perimeter: {0}",2*(a+b));
        }

        public static void Main(){
            Test t = new Test(); //class object
            rectangle r = new rectangle(t.area);//delegate object
            r+=t.perimeter; //passing another method in delegate
            r.Invoke(4.2, 5.7); //passing the values in both methods
            r.Invoke(6.3, 34.3);
            
        }
    }
}