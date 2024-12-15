using System;
using System.IO;
namespace DirectoryClass
{
    class Program
    {
        static void Main()
        {
            string folderPath = "E:\\FileIOCSharp\\WorkingWithFileIO";

            if (Directory.Exists(folderPath))
            {
                Console.WriteLine("Folder exists in given path");
            }
            else
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("Folder doesn't exist in the given path. Creating new one...");
            }

            // if(Directory.Exists(folderPath)){
            //     Console.WriteLine("Deleting that folder");
            //     Directory.Delete(folderPath);
            // }

            Console.WriteLine("All drives in this PC: ");
            string[] drives = Directory.GetLogicalDrives();
            foreach (string drive in drives)
            {
                Console.WriteLine(drive);
            }

            Console.WriteLine("All folders inside E drive: ");
            string[] subDir = Directory.GetDirectories("E:\\");
            foreach (string s in subDir)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("All files inside FileIOCSharp folder: ");
            string[] files = Directory.GetFiles("E:\\FileIOCSharp");
            foreach (string f in files)
            {
                Console.WriteLine(f);
            }

        }
    }
}