using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementation of File IO operations");
            string filepath = @"C:\Users\hp\source\repos\FileIO Operations\FileIO Operations\TextFile1.txt";
            string outputFile = @"C:\Users\hp\Desktop\Output.txt";
            BasicOperation.FileExists(filepath);
            BasicOperation.ReadAllLine(filepath);
            BasicOperation.ReadFile(filepath);
           // BasicOperation.CopyFile(filepath,outputFile);
            BasicOperation.ReadFromStreamReader(filepath);
            BasicOperation.WriteUsingStreamWriter(filepath);
           
            Console.Read();
        }
    }
}
