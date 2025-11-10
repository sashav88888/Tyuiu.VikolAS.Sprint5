using System;
using System.IO;
using Tyuiu.VikolAS.Sprint5.Task5.V1.Lib;

namespace Tyuiu.VikolAS.Sprint5.Task5.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string tempDir = Path.GetTempPath();
            string filePath = Path.Combine(tempDir, "InPutDataFileTask5V1.txt");

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Файл не найден: {filePath}");
                return;
            }

            double result = ds.LoadFromDataFile(filePath);
            Console.WriteLine(result);
        }
    }
}
