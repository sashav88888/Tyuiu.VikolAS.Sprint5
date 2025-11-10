using System;
using System.IO;
using Tyuiu.VikolAS.Sprint5.Task1.V19.Lib;

namespace Tyuiu.VikolAS.Sprint5.Task1.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Викол А.С. | ИСПб-25-1 | Вариант 19";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #5                                                     *");
            Console.WriteLine("* Тема: Запись табулированных данных в файл                     *");
            Console.WriteLine("* Задание: Вариант 19                                           *");
            Console.WriteLine("* Выполнил: Викол А.С. | ИСПб-25-1                              *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine();

            int startValue = -5;
            int stopValue = 5;

            string path = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Результаты табулирования функции:");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("  x\tf(x)");
            Console.WriteLine("------------------------------------");

            int xVal = startValue;
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    Console.WriteLine($"{xVal,3}\t{line}");
                    xVal++;
                }
            }

            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Файл с результатами: {path}");
        }
    }
}
