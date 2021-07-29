using CsvHelper;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_Operations
{
    class CSVFileOperation
    {
        List<PersonData> list = new List<PersonData>();
        string csvFile = @"C:\Users\hp\source\repos\FileIO Operations\FileIO Operations\CSVFile.csv";
        public void ReadInput()
        {
            list.Add(new PersonData("soubar", 20));
            list.Add(new PersonData("Gemini", 22));
            list.Add(new PersonData("shanthi", 47));
            list.Add(new PersonData("venkat", 57));
            WriteInToCSVFile();

        }
        public void WriteInToCSVFile()
        {

            using (StreamWriter writer = new StreamWriter(csvFile))
            {
                //creating the csv writer path
                using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                   
                    //create the header that are the properties of the Person Data
                    csvWriter.WriteHeader<PersonData>();
                    csvWriter.NextRecord();
                    csvWriter.WriteRecords(list);
                }
            }
            ReadFromCsvFile();
        }
        public void ReadFromCsvFile()
        {
            List<PersonData> record;
            using (StreamReader reader = new StreamReader(csvFile))
            {
                //creating the csv reader path
                using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    
                    //get all the record as list
                    record = csvReader.GetRecords<PersonData>().ToList();
                }
            }
            foreach (var l in record)
            {
                //printing the list
                Console.WriteLine("Name:" + l.name + " Age:" + l.age);
            }
        }
    }
}