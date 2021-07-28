using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileIO_Operations
{
    class BinaryFileOperation
    {
        //converting the object into the binary format
        public void BinarySerialization()
        {
            string path = @"C:\Users\hp\source\repos\FileIO Operations\FileIO Operations\Binary.txt";
            //creating the object for the personData
            PersonData data = new PersonData();
            data.name = "Soubarnika";
            data.age = 21;
            data.name = "Shanthi";
            data.age = 41;
            //creating the stream for the file to write
            FileStream file = File.OpenWrite(path);
            //it convert the object into binary format
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file, data);
        }
        public void BinaryDeSerialization()
        {
            string path = @"C:\Users\hp\source\repos\FileIO Operations\FileIO Operations\Binary.txt";
            //creating the stream for the file to write
            FileStream file = File.OpenRead(path);
            BinaryFormatter binary = new BinaryFormatter();
            //deserialize the binary format into object
            PersonData person = (PersonData)binary.Deserialize(file);
            Console.WriteLine("Person detail");
            Console.WriteLine("Name:{0}  Age:{1}", person.name, person.age);
        }
    }
}
