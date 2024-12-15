using System;
using System.IO;
namespace ReadingFile{
    class ReadFile{
        public void ReadData(){
            StreamReader sr = new StreamReader("E:\\FileIOCSharp\\hello.txt");
            Console.WriteLine("Contents of File: ");
            //move the pointer to beginning of file
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            //read a single line at one time
            string str = sr.ReadLine();
            while(str!=null){
                //readline reads single line and returns null at the end of file. then iterate until str contains null

                //write to console
                Console.WriteLine(str);
                //read next line and loop
                str = sr.ReadLine();
            }
            sr.Close();
        }
    }

    class Program{
        static void Main(){
            ReadFile rf = new ReadFile();
            rf.ReadData();
        }
    }
}