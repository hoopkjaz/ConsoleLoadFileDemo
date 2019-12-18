using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLoadCsvDemo
{
    public class WriteFileToConsole
    {
        public void Load()
        {
            // Get the data from path.
           // string sampleCSV = @"C:\Working\testing\sample.csv";
            string sampleCSV = constants.FileName;
            string[,] values = LoadCSV(sampleCSV);
            int num_rows = values.GetUpperBound(0) + 1;
            int num_cols = values.GetUpperBound(1) + 1;

            // Display the data to show we have it.

            for (int c = 0; c < num_cols; c++)
                Console.Write(values[0, c] + "\t");

            //Read the data.
            for (int r = 1; r < num_rows; r++)
            {
                //  dgvValues.Rows.Add();
                Console.WriteLine();
                for (int c = 0; c < num_cols; c++)
                {
                    Console.Write(values[r, c] + "\t");
                }
            }

            Console.ReadLine();
        }

        public void LoadPerson()
        {
             List<Person> list;
             Person person;

            list = new List<Person>();

            // Get the data from path.
            string sampleCSV = constants.FileName;

            string[,] values = LoadCSV(sampleCSV);
            int num_rows = values.GetUpperBound(0) + 1;

            //Read the data and add to List 
            for (int r = 1; r < num_rows; r++)
            {
                //name age mail company
                person = new Person(values[r, 0], int.Parse(values[r, 1]), values[r, 2], values[r, 3]);
                list.Add(person);
            }

            //read data from list
            foreach (var item in list)
            {
                Console.WriteLine(item.Name + "\t" + item.Age + "\t" + item.Company + "\t" + item.Mail + "\t");
            }
            Console.ReadLine();
        }

        private static string[,] LoadCSV(string filename)
        {
            // Get the file's text.
            string whole_file = System.IO.File.ReadAllText(filename);

            // Split into lines.
            whole_file = whole_file.Replace('\n', '\r');
            string[] lines = whole_file.Split(new char[] { '\r' },
                StringSplitOptions.RemoveEmptyEntries);

            // See how many rows and columns there are.
            int num_rows = lines.Length;
            int num_cols = lines[0].Split(',').Length;

            // Allocate the data array.
            string[,] values = new string[num_rows, num_cols];

            // Load the array.
            for (int r = 0; r < num_rows; r++)
            {
                string[] line_r = lines[r].Split(',');
                for (int c = 0; c < num_cols; c++)
                {
                    values[r, c] = line_r[c];
                }
            }

            // Return the values.
            return values;
        }
    }
}
