using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VikolAS.Sprint5.Task4.V21.Lib
{
    public class DataService : ISprint5Task4V21
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            string text = File.ReadAllText(path).Trim();
            if (!double.TryParse(text, out double x))
                throw new InvalidDataException("Файл не содержит корректное вещественное число.");

            double y = Math.Pow(x, 3) * Math.Cos(x) + 2 * x;
            return Math.Round(y, 3);
        }
    }
}
