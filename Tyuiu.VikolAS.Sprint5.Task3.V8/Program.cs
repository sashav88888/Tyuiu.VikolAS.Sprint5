using System;
using System.IO;
using Tyuiu.VikolAS.Sprint5.Task3.V8.Lib;

namespace Tyuiu.VikolAS.Sprint5.Task3.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Викол А.С. | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Работа с бинарными файлами                                        *");
            Console.WriteLine("* Задание: Вариант 8                                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Дано выражение y(x) = (x^2 + 1) / (3x + 4).                             *");
            Console.WriteLine("* Вычислить при x = 3 и сохранить результат в бинарный файл.              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int x = 3;
            string path = ds.SaveToFileTextData(x);

            double result;

            // Читаем значение из бинарного файла
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                result = reader.ReadDouble();
            }

            Console.WriteLine($"Результат вычисления при x = {x}: y = {result}");
            Console.WriteLine($"Файл сохранён по пути: {path}");
        }
    }
}
