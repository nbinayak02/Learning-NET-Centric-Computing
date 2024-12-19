using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace LanguageIntegratedQuery
{

    public class Animal{
        public string name{get; set;}
        public int age{get; set;}
        public string sound{get; set;}
    }
    class LinqClass
    {
        public static void Main()
        {

            //data source
            int[] numbers = new int[] { 2, 4, 6, 8, 10, 2345, 7678, 24, 67, 234 };

            //Linq query
            var num = from n in numbers where n > 100 select n;

            //print
            foreach (int n in num)
            {
                Console.WriteLine(n);
            }

            //data source 2
            ArrayList pl = new ArrayList(){
                "Indian Premier League",
                "Nepal Premier League",
                "Pakistan Super League",
                "Bangladesh Premier League",
                "Lanka Premier League",
                "The Hundered",
                "Big Bash League"
            };

            //Linq query
            var result = from string p in pl where p.Contains("Premier") select p;

            //print result
            foreach(string s in result){
                Console.WriteLine(s);
            }

            //data source 3
            List<Animal> animals = new List<Animal>{
                new Animal{name = "Dog", age = 4, sound = "Bark"},
                new Animal{name = "Cat", age = 2, sound = "Meow"},
                new Animal{name = "Fox", age = 2, sound = "Bark"}
            };

            //linq query
            var barkingAnimals = from animal in animals where animal.sound == "Bark" select animal;

            //printing
            foreach(var animal in barkingAnimals){
                Console.WriteLine(animal.name + " " +animal.age);
            }
        }
    }
}