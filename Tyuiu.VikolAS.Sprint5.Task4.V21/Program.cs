using System;
using Tyuiu.VikolAS.Sprint5.Task4.V21.Lib;

namespace Tyuiu.VikolAS.Sprint5.Task4.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string tempPath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "InPutDataFileTask4V0.txt");
            double result = ds.LoadFromDataFile(tempPath);

            Console.WriteLine(result);
        }
    }
}
