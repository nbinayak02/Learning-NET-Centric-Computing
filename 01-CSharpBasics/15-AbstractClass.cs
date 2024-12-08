using System;
namespace AbstractClass{
    public abstract class Bank{
       public abstract void withdrawMoney(double amnt);
    }

    class Customer:Bank{
        double maxAmnt = 50000;
       public override void withdrawMoney(double amnt){
            if(amnt <= maxAmnt){
                Console.WriteLine("Your money can be withdrawn");
            } else{
                Console.WriteLine("The maximum amount you can withdraw is Rs.{0}",maxAmnt);
            }
        }
    }

    class Program{
        static void Main(){
            // Bank b = new Bank();//cannot instantiate abstract class
            Console.WriteLine("Enter the amount of money to withdraw: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            Customer cs = new Customer();
            cs.withdrawMoney(amount);
        }
    }
}