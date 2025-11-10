using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VikolAS.Sprint5.Task3.V8.Lib
{
    public class DataService : ISprint5Task3V8
    {
        public string SaveToFileTextData(int x)
        {
            // Вычисляем значение функции
            double y = (Math.Pow(x, 2) + 1) / (3 * x + 4);

            // Округляем до 3 знаков после запятой
            y = Math.Round(y, 3);

            // Создаем временный путь к бинарному файлу
            string path = Path.GetTempFileName();

            // Сохраняем результат в бинарный файл
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(y);
            }

            return path;
        }
    }
}
