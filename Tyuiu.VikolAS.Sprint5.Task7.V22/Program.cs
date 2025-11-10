using System;
using Tyuiu.VikolAS.Sprint5.Task7.V22.Lib;

namespace Tyuiu.VikolAS.Sprint5.Task7.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Задача 7 Вариант 22";

            DataService ds = new DataService();

            string tempPath = System.IO.Path.GetTempPath();
            string inputFile = System.IO.Path.Combine(tempPath, "InPutDataFileTask7V22.txt");

            try
            {
                string outputFile = ds.LoadDataAndSave(inputFile);
                Console.WriteLine("Файл успешно обработан. Результат сохранен в: " + outputFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
    }
}
