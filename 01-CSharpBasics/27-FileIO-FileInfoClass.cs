using System;
using System.IO;
namespace FileInfoClass{
    class Program{
        public static void Main(){
            string filePath = "E:\\FileIOCSharp\\hello.txt";
            FileInfo finfo = new FileInfo(filePath);

            if(finfo.Exists){
                Console.WriteLine("File name: {0}",finfo.Name);
                Console.WriteLine("File extension: {0}",finfo.Extension);
                Console.WriteLine("File size: {0} bytes",finfo.Length);
                Console.WriteLine("File creation time: {0}",finfo.CreationTime);
                Console.WriteLine("File last accessed: {0}",finfo.LastAccessTime);
                Console.WriteLine("File directory: {0}",finfo.DirectoryName);

                string anotherPath = "E:\\FileIOCSharp\\secondFile.txt";

                FileStream fs = File.Create(anotherPath);
                fs.Close();

                FileInfo finfoanother = new FileInfo(anotherPath);

                if(finfoanother.Exists){
                    Console.WriteLine("File created successfully");
                }else{
                    Console.WriteLine("File creation failed");
                }


                finfo.CopyTo(anotherPath, true);
                Console.WriteLine("File copied to "+anotherPath);

                // FileInfo copiedfile = new FileInfo(anotherPath);
                // copiedfile.Delete();
                // Console.WriteLine("File deleted "+anotherPath);
            } else{
                Console.WriteLine("File doesn't exists");
            }
        }
    }
}