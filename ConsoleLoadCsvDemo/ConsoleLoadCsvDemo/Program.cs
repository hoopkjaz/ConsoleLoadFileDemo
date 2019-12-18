using System;

namespace ConsoleLoadCsvDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteFileToConsole write = new WriteFileToConsole();
            WriteFileToJson writeJson = new WriteFileToJson();
          write.Load();

            //write.LoadPerson();

           var b = writeJson.WriteToJson();
            Console.WriteLine(b);
        }       
    }
}
