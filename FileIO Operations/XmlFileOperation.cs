using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace FileIO_Operations
{
    class XmlFileOperation
    {
        //converting the object into the xml format
        public void XMLSerialization()
        {
            string path = @"C:\Users\hp\source\repos\FileIO Operations\FileIO Operations\XmlFile.xml";
            //creating the object for the personData
            PersonData data = new PersonData();
            data.name = "soubarnika";
            data.age = 21;
            //creating the stream for the file to write
            FileStream file = File.OpenWrite(path);
            //it convert the object into xml format
            XmlSerializer serializer = new XmlSerializer(typeof(PersonData));
            serializer.Serialize(file, data);
        }
        public void XMLDeserialization()
        {
            
            string path = @"C:\Users\hp\source\repos\FileIO Operations\FileIO Operations\XmlFile.xml";
            //creating the stream for the file to read
            FileStream fs = File.OpenRead(path);
            //xml object to perform deserialization
            XmlSerializer xs = new XmlSerializer(typeof(PersonData));
            //use xmlonject to deserialize dta from the file
            PersonData data = (PersonData)xs.Deserialize(fs);
            //display the deserialized data
            Console.WriteLine("name: " + data.name);
            Console.WriteLine("age: " + data.age);
            Console.ReadKey();
        }
    }
}
