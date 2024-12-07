using System;
namespace UseOfBaseKeyword
{
    class Food
    {
       protected string name;
       protected double calorie;

        public Food(string name, double calorie)
        {
            this.name = name;
            this.calorie = calorie;
        }

       public void display()
        {
            Console.WriteLine("Food: {0} gives calorie: {1}", name, calorie);
        }
    }

    class Veg : Food
    {
        public Veg(string name, double calorie) : base(name, calorie){}
        public new void display(){
            base.display();
            Console.WriteLine("It is vegeterian food");
        }
    }

    class Program{
        static void Main(){
            Veg rice = new Veg("Rice",12.67);
            rice.display();
        }
    }
}