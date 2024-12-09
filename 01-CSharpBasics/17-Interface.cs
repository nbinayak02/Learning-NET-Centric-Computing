using System;
using Interfaces;
namespace Interfaces
{
    interface Product
    {
        void getProductDetails();
        double getAmount();
    }

    public class Book : Product
    {
        private string bookName;
        public string Author;
        private double price;

        public Book()
        {
            bookName = "";
            Author = "";
            price = 0.0;
        }

        public Book(string bookName, string Author, double price){
            this.bookName = bookName;
            this.price = price;
            this.Author = Author;
        }

        public void getProductDetails(){
            Console.WriteLine("Book Name: {0}\n Book Author: {1}",bookName,Author);
        }

        public double getAmount(){
            return price;
        }

        
    }

    public class Laptop:Product{
        private string name;
        private string brand;
        private double price;

        public Laptop(){
            name = "";
            brand = "";
            price = 0.0;
        }

        public Laptop(string name, string brand, double price){
            this.name = name;
            this.brand = brand;
            this.price = price;
        }

        public void getProductDetails(){
            Console.WriteLine("Laptop Name: {0} \n Brand: {1}",name, brand);
        }

        public double getAmount(){
            return price;
        }
    }

    class Program{
        static void Main(){
            Book b = new Book("Rich dad poor dad","Unknown",234.45);
            b.getProductDetails();
            Console.WriteLine("Price of book is: "+b.getAmount());

            Laptop l = new Laptop("Aspire 3", "Acer", 1234000.231);
            l.getProductDetails();
            Console.WriteLine("Price of laptop is: "+l.getAmount());
        }
    }
}