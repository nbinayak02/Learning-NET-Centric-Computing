using System;
using System.Collections;
namespace Collections
{

    public class CList
    {

        public CList()
        {
            //arraylist is one of the type of collection
            ArrayList day = new ArrayList();

            //adding items in arraylist
            day.Add("Sunday");
            day.Add("Monday");
            day.Add("Tuesday");
            day.Add("Wednesday");
            day.Add("Thursday");
            day.Add("Friday");
            day.Add("Saturday");

            //properties
            Console.WriteLine("Capacity: {0}", day.Capacity);
            Console.WriteLine("Count: {0}", day.Count);

            //methods
            Console.WriteLine("Contains: {0}", day.Contains("Wednesday"));
            Console.WriteLine("IndexOf: {0}", day.IndexOf("Friday"));
            day.Insert(7, "Holiday");
            day.Remove("Saturday");
            day.Sort();
            // day.Reverse();

            Console.WriteLine("");


            foreach (string d in day)
            {
                Console.WriteLine(d);
            }

            // Capacity is the number of elements that the ArrayList can store.Count is the number of elements that are actually in the ArrayList.
            // Capacity is always greater than or equal to Count. If Count exceeds Capacity while adding elements, the capacity is automatically increased by reallocating the internal array before copying the old elements and adding the new elements.
        }
    }

    public class CHashTables
    {
        Hashtable ht = new Hashtable();
        public CHashTables()
        {
            ht.Add("Biratnagar", "Sandeep");
            ht.Add("Janakpur", "Anil");
            ht.Add("Kathmandu", "Karan");
            ht.Add("Chitwan", "Kushal");
            ht.Add("Pokhara", "Kushal");
            ht.Add("Lumbini", "Rohit");
            ht.Add("Sudurpaschim", "Dipendra");
            ht.Add("Karnali", "Sompal");

            Console.WriteLine("Count: {0}", ht.Count);
            Console.WriteLine("ContainsKey: {0}", ht.ContainsKey("Pokhara"));
            Console.WriteLine("ContainsValue: {0}", ht.ContainsValue("Kushal"));
            ht.Remove("Lumbini");

            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + " " + d.Value);
            }

            ht.Clear();
            Console.WriteLine("Printing after Clear() method");
            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + " " + d.Value);
            }


        }
    }

    public class CStack
    {
        Stack s = new Stack();

        public CStack()
        {
            s.Push(17);
            s.Push(18);
            s.Push(19);
            s.Push(10);

            foreach (int a in s)
            {
                Console.WriteLine(a);
            }

            s.Pop();
            Console.WriteLine("");

            foreach (int a in s)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("");
            Console.WriteLine(s.Peek());
        }
    }
    
    public class CQueue
    {
        Queue q = new Queue();

        public CQueue()
        {
            q.Enqueue(17);
            q.Enqueue(18);
            q.Enqueue(19);
            q.Enqueue(10);

            foreach (int a in q)
            {
                Console.WriteLine(a);
            }

            q.Dequeue();
            Console.WriteLine("");

            foreach (int a in q)
            {
                Console.WriteLine(a);
            }
        }
    }
    public class Program
    {
        public static void Main()
        {

            // CList cl = new CList();
            // CHashTables ch = new CHashTables();
            // CStack cs = new CStack();
            CQueue cq = new CQueue();
        }

    }

}