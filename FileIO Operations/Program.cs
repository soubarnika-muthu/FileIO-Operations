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

            //BinaryFileOperation operation = new BinaryFileOperation();
            ////operation.BinarySerialization();
            //operation.BinaryDeSerialization();
            XmlFileOperation xml = new XmlFileOperation();
            //xml.XMLSerialization();
            xml.XMLDeserialization();

            Console.Read();
        }
    }
}
