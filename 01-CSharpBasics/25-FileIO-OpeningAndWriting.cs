using System;
using System.IO;
namespace FileIOStreamWriterClass{
    class WriteToFile{
        public void Data(){
            //streamwriter class for writing character to stream in a particular format
            StreamWriter sw = new StreamWriter("E:\\FileIOCSharp\\hello.txt");

            Console.WriteLine("Enter the text to write on file: ");

            //reading input from console
            string sr = Console.ReadLine();

            //method to write a line in buffer
            sw.WriteLine(sr);
            //to write in output stream
            sw.Flush();
            //to close the stream
            sw.Close();
        }
    }
// When you use sw.WriteLine, the input data (characters) is first written to a buffer (a temporary memory area managed by StreamWriter).
// The data from the buffer is periodically written to the file in chunks (not immediately) to optimize performance. This means some data might still be sitting in the buffer after WriteLine.
// When you call Flush, the entire buffer content is forcibly written to the file, ensuring that all pending data is saved.
// After Flush, the buffer is cleared, leaving it empty for new data.
    class Program{
        static void Main(){
            WriteToFile wr = new WriteToFile();
            wr.Data();
        }
    }
}