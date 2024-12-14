using System;
using System.Collections.Generic;

namespace Generics
{
    public class Gen<T>
    {
        private T str;

        public Gen(T str)
        {
            this.str = str;
        }

        public T showData()
        {
            return str;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("a", 299);
            d.Add("y", 399);

            Dictionary<int, string> a = new Dictionary<int, string>();
            a.Add(1, "JB");
            a.Add(2, "SR");

            foreach (var g in d)
            {
                Console.WriteLine(g.Key + " " + g.Value);
            }

            Console.WriteLine(" ");
            foreach (var j in a)
            {
                Console.WriteLine(j.Key + " " + j.Value);
            }

            // User defined generic class
            Gen<string> gs = new Gen<string>("Hello");
            Console.WriteLine(gs.showData());

            Gen<int> intGen = new Gen<int>(20);
            Console.WriteLine(intGen.showData());

            Gen<double> doubleGen = new Gen<double>(2.70980);
            Console.WriteLine(doubleGen.showData());
        }
    }
}