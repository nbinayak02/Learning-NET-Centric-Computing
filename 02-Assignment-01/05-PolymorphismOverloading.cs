using System;
namespace Polymorphism
{

    class Methods
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a + "+" + b + "=" + (a + b));
        }

        public void add(int a, int b, int c)
        {
            Console.WriteLine(a + "+" + b + "+" + c + "=" + (a + b + c));
        }

        public void add(double a, double b)
        {
            Console.WriteLine(a + "+" + b + "=" + (a + b));
        }
    }
    class Program
    {
        static void Main()
        {
            Methods m = new Methods();
            m.add(2, 6);
            m.add(7, 8, 3);
            m.add(3.5, 67.3);
        }
    }
}