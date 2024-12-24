using System;
namespace ExceptionHandling
{
    class Program
    {
        static void Main()
        {

            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            try
            {
                int a = nums[10];
                Console.WriteLine(a);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Exception Occured: The index you are trying to access is out of range.");
            }
            finally
            {
                Console.WriteLine("This is finally block");
            }


        }
    }
}

// Output:
// Exception Occured: The index you are trying to access is out of range.
// This is finally block