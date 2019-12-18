using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLoadCsvDemo
{
    class WriteFileToJson
    {
        public string WriteToJson()
        {
            var csv = new List<string[]>(); // or, List<YourClass>
            var lines = System.IO.File.ReadAllLines(constants.FileName);
            foreach (string line in lines)
                csv.Add(line.Split(',')); // or, populate YourClass          
            
            return JsonConvert.SerializeObject(csv);
        }
    }
}
