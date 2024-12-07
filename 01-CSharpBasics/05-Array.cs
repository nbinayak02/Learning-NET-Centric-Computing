using System;
namespace Arrays
{
    class Program
    {
        static void Main()
        {

            //oneD
            int[] nums = new int[9];
            nums = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int[] oddNums = new int[5] { 1, 3, 5, 7, 9 };

            int[] evenNums = { 2, 4, 6, 8 };

            //accessing
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + "\t");
            }

            Console.WriteLine("");

            foreach (int i in oddNums)
            {
                Console.Write(i + "\t");
            }

            //twoD
            string[,] twoDimen = new string[2, 4]{
                {"R1C1","R1C2","R1C3","R1C4"},
                {"R2C1","R2C2","R3C3","R4C4"}};

            Console.WriteLine("");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(twoDimen[i, j] + "\t");
                }
                Console.WriteLine("");
            }
            //threeD
            int[,,] threeD = new int[2, 2, 3]{
               { {1,2,0}, {3,4,0} },
               { {5,6,0}, {7,8,0} }
            };
            Console.WriteLine("");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write(threeD[i, j, k] + "\t");
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }


        }
    }
}