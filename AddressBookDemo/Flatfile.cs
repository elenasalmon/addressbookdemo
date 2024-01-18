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
        // if continued with csv route, would want to make this a user input in future

        public void PullFromCsv(string filePath, ref string err, ref List<string[]> data)
        {
            try
            {
                using (TextFieldParser parser = new TextFieldParser(filePath))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

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
