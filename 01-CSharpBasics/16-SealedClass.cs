using System;
namespace SealedClass
{
    public class Bird
    {

    }

    sealed class Albatross : Bird
    {

    }

    class Penguin : Albatross
    {
        //error: cannot derive sealed class
    }

    class program
    {
        static void Main()
        {

        }
    }
}