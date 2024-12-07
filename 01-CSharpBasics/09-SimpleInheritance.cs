using System;
namespace Inheritance
{

    //base class
    class Shape
    {
        protected double length;
        protected double breadth;

        public void setDimension(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
    }

    //class rectangle deriving class shape 
    class Rectangle : Shape
    {
        public double Area()
        {
            return length * breadth;
        }
    }

    class Program
    {
        static void Main()
        {
            Rectangle r1 = new Rectangle();
            r1.setDimension(23.23, 56.25); //calling base class method from derived class object
            Console.WriteLine("The area of r1 is {0}", r1.Area());
        }
    }
}