using System;
namespace ConstructorDemo{
    public class Rectangle{
        private double length;
        private double breadth;
        public Rectangle(){
            length = 0.0;
            breadth = 0.0;
            Console.WriteLine("Default Constructor Initialized");
        }

        public Rectangle(double length, double breadth){
            this.length = length;
            this.breadth = breadth;
            Console.WriteLine("Parameterized Constructor Initialized");
        }

        public double Area(){
            return length*breadth;
        }
    }

    class Program{
        public static void Main(){

            Rectangle r1 = new Rectangle();
            Console.WriteLine("Area of rectangle 1 is: "+r1.Area());

            Rectangle r2 = new Rectangle(23.56, 767.23);
            Console.WriteLine("Area of rectangle 2 is: "+r2.Area());
        }
    }
}

// Output:
// Default Constructor Initialized
// Area of rectangle 1 is: 0
// Parameterized Constructor Initialized
// Area of rectangle 2 is: 18075.9388