using System;
namespace StringsInCSharp{
    class Program{
    static void Main(){

        string firstString;
        firstString = "This is string 1";
        Console.WriteLine(firstString);

        //initializing empty string
        // string second = "";
        //instead of that we can also 
        string second = System.String.Empty;
        Console.WriteLine(second);

        //creating string from char array
        char[] letters = {'a','p','p','l','e'};
        string alpha = new string(letters);
        Console.WriteLine(alpha);

        //constant string
        const string message = "This is a message";
        Console.WriteLine(message);
        // string message = "hello"; error

        //string properties
        Console.WriteLine(firstString.Length);
       
       //string methods
       Console.WriteLine(string.Concat(firstString, alpha));
       Console.WriteLine(firstString.IndexOf('s'));
       Console.WriteLine(firstString.ToUpper());
       Console.WriteLine(firstString.ToLower());
        
    }

    }
}