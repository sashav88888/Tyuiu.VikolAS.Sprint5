using System;
using Tyuiu.VikolAS.Sprint5.Task6.V20.Lib;

namespace Tyuiu.VikolAS.Sprint5.Task6.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            // Создаем путь к файлу в temp (для примера)
            string tempPath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "InPutDataFileTask6V20.txt");
            Console.WriteLine($"Используется файл: {tempPath}");


            int count = ds.LoadFromDataFile(tempPath);
            Console.WriteLine($"Количество слов длиной 6 символов: {count}");
        }
    }
}
