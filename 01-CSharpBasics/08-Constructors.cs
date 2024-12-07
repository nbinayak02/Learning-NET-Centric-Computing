using System;
namespace Constructors
{
    class Laptop
    {
        string name;
        double price;

        //default constructor
        public Laptop()
        {
            Console.WriteLine("Welcome to Laptop Class!");
        }

        //parameterized constructor
        public Laptop(string name, double price)
        {
            this.name = name;
            this.price = price;
            Console.WriteLine("The price of {0} laptop is {1}", this.name, this.price);
        }
    }

    class Program
    {
        static void Main()
        {
            Laptop acer = new Laptop(); //calls default constructor
            Laptop acer3 = new Laptop("Acer Aspire 3", 110000.34); //calls parameterized constructor
        }
    }
}