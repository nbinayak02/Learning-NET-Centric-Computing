using System;
namespace DelegatesDemo{
    public class Area{

        public delegate void Circle(double r);
        public delegate void Rectangle(double l, double b);
        public delegate void Triangle(double b, double h);

        public void AreaOfC(double r){
            Console.WriteLine("The area of circle having radius {0} is {1}",r,3.14*r*r);
        }

        public void AreaOfR(double l, double b){
            Console.WriteLine("The area of rectangle having length {0} and breadth {1} is {2}",l,b,l*b);
        }

        public void AreaOfT(double b, double h){
            Console.WriteLine("The area of triangle having base {0} and height {1} is {2}",b,h,(1.0/2.0 *b*h));
        }

        public static void Main(){

            Area a = new Area();

            Circle c = new Circle(a.AreaOfC);
            Rectangle r = new Rectangle(a.AreaOfR);
            Triangle t = new Triangle(a.AreaOfT);

            c(4.5);
            r(2.0, 3.0);
            t(5.0, 8.0);

        }
    }

}

// Output:
// The area of circle having radius 4.5 is 63.585
// The area of rectangle having length 2 and breadth 3 is 6
// The area of triangle having base 5 and height 8 is 20