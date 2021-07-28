using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace FileIO_Operations
{
    class JsonFileOperation
    {
        //converting the object into the json file
        public void JSONSerialization()
        {
            try
            {
                string path = @"C:\Users\hp\source\repos\FileIO Operations\FileIO Operations\JsonData.json";
                PersonData person = new PersonData() { name = "soubarnika", age = 21 };
                string res = JsonConvert.SerializeObject(person);
                File.WriteAllText(path, res);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
