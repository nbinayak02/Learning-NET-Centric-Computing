using System;
namespace Indexers
{

    public class NPL
    {
        private string[] names = new string[8]; //field of array type
                                                //this below is property
        public string this[int i] //only difference is this keyword and parameter list
        {
            get
            {
                return names[i];
            }
            set
            {
                names[i] = value;
            }
        }
    }

    public class Program
    {
        static void Main()
        {
            NPL teams = new NPL();
            teams[0] = "BK"; //if there was no indexer then we would set value as teams.names = "bk";
            teams[1] = "JB";
            teams[2] = "CR";
            teams[3] = "KG";
            teams[4] = "PA";
            teams[5] = "LL";
            teams[6] = "SR";
            teams[7] = "KY";

            Console.WriteLine("The teams of Nepal Premier League are: ");

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(teams[i]);
            }
        }
    }
}