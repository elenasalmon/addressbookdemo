using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDemo
{
    public class Flatfile
    {
        public void SaveToCsv(string data, string filePath, ref string err)
        {
            try
            {
                File.AppendAllText(filePath, data);
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
        }

        public string csvFilePath = "C:\\Temp\\AddressBookDemo.csv";

        public void PullFromCsv(string filePath, ref string err, ref List<string[]> data)
        {
            //List<string[] data = new List<string[]>();
            try
            {
                using (TextFieldParser parser = new TextFieldParser(filePath))
                {
                    // Set the parser properties
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    // Read and parse each line, adding it to "data" for output
                    // Does this work when the csv is empty?
                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();
                        data.Add(fields);
                    }
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
        }
    }
}
