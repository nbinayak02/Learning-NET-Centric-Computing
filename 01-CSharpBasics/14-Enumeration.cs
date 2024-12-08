namespace Enumeration{
    class Program{
            enum Months {Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sept, Oct, Nov, Dec};
        public static void Main(){
            int first =(int) Months.Jan;
            int last =(int) Months.Dec;
System.Console.WriteLine(first);
System.Console.WriteLine(last);
        }
    }
}