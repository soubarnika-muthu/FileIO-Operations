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
    }
}
