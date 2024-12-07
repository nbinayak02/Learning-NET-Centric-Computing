using System;
namespace ControlStatements
{
    class Program
    {
        static void add(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        static void subtract(int x, int y)
        {
            Console.WriteLine(x - y);
        }

        static void multiply(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        static void Main()
        {
            int choice;
            int x, y;

            Console.WriteLine("Enter Your Choice Below: ");
            Console.WriteLine("1: Add 2:Subtract 3:Multiply");
            choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter two numbers: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    add(x, y);
                    break;

                case 2:
                    subtract(x, y);
                    break;

                case 3:
                    multiply(x, y);
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

            Console.ReadKey();
        }
    }
}