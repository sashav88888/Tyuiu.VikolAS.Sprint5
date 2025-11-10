using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VikolAS.Sprint5.Task0.V19.Lib
{
    public class DataService : ISprint5Task0V19
    {
        public string SaveToFileTextData(int x)
        {
            // Формула y = (2x^2 - 1) / sqrt(x^2 - 2)
            double y = (2 * Math.Pow(x, 2) - 1) / Math.Sqrt(Math.Pow(x, 2) - 2);
            y = Math.Round(y, 3);

            // Получаем путь к временному файлу
            string tempDir = Path.GetTempPath();
            string filePath = Path.Combine(tempDir, "OutPutFileTask0.txt");

            // Сохраняем результат
            File.WriteAllText(filePath, y.ToString());

            return filePath;
        }
    }
}
