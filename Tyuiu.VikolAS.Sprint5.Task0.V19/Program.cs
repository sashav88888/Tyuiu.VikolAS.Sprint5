using System;
using System.IO;
using Tyuiu.VikolAS.Sprint5.Task0.V19.Lib;

namespace Tyuiu.VikolAS.Sprint5.Task0.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Викол А.С. | ИСПб-25-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Задание #0. Вариант 19                                                       *");
            Console.WriteLine("* Тема: Файловый ввод-вывод.                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine();

            DataService ds = new DataService();
            int x = 3;
            string path = ds.SaveToFileTextData(x);

            Console.WriteLine($"Результат вычислений сохранен в файл: {path}");
            Console.WriteLine($"Содержимое файла: {File.ReadAllText(path)}");

            Console.ReadKey();
        }
    }
}
