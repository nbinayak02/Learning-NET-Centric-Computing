using System;
namespace ClassAndObjects
{
    public class Shape
    {
        //member variables-these are called fields(they can be read or set directly)
        private int length;
        private int breadth;

        //member methods
        public void setDimension(int l, int b)
        {
            this.length = l;
            this.breadth = b;
        }

        public string getDimension()
        {
            string r = "Length: " + length + " Breadth: " + breadth;
            return r;
        }

        public int calcArea()
        {
            return length * breadth;
        }


    }

    class Rectangle
    {
        static void Main()
        {

            //object 1
            Shape rect = new Shape();
            rect.setDimension(2, 4);
            Console.WriteLine("The dimension of rectangle is: " + rect.getDimension());
            Console.WriteLine("The area of rectangle is: " + rect.calcArea());

            //object 2
            Shape sqre = new Shape();
            sqre.setDimension(3, 3);
            Console.WriteLine("The dimension of square is: " + sqre.getDimension());
            Console.WriteLine("The area of square is: " + sqre.calcArea());
        }
    }
}