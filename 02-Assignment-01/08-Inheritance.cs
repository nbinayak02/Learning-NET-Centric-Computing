using System;
namespace Inheritance
{
    class Product
    {
        protected string name;
        protected double price;

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }

    class Electronics : Product
    {
        public Electronics(string name, double price) : base(name, price) { }
        public void showProduct()
        {
            Console.WriteLine("Name: {0} Price: {1}", name, price);
        }
    }

    class Program
    {
        static void Main()
        {

            Electronics phone = new Electronics("Samsung", 235634.5);
            phone.showProduct();
        }
    }
}