using System;
namespace ClassProperties
{
    class Doctor
    {
        private string name = "";
        private int age = 0;
        private string speciality = "";

        //declaring property for name 
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Speciality
        {
            get { return speciality; }
            set { speciality = value; }
        }

    }

    class Program{
        static void Main(){

            //object1
            Doctor drbin = new Doctor();
            drbin.Name = "Dr. Binayak";
            drbin.Age = 20;
            drbin.Speciality = "Heart";
            Console.WriteLine(drbin.Name);
            Console.WriteLine(drbin.Age);
            Console.WriteLine(drbin.Speciality);
        }
    }
}