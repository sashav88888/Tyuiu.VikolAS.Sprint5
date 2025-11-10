using System;
using Tyuiu.VikolAS.Sprint5.Task2.V19.Lib;

namespace Tyuiu.VikolAS.Sprint5.Task2.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Викол А.С. | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Работа с файлами CSV                                              *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант 19                                                              *");
            Console.WriteLine("* Выполнил: Викол А.С. | ИСПб-25-1                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Дан целочисленный массив 3x3. Заменить нечётные элементы на 0           *");
            Console.WriteLine("* и сохранить результат в файл OutPutFileTask2.csv                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            int[,] matrix = new int[3, 3];
            Console.WriteLine("Введите элементы матрицы 3x3:");

            for (int i = 0; i < 3; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = int.Parse(input[j]);
                }
            }

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(matrix);

            Console.WriteLine();
            Console.WriteLine($"Результат сохранён в файл: {path}");
        }
    }
}
