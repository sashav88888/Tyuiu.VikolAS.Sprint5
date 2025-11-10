using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VikolAS.Sprint5.Task6.V20.Lib
{
    public class DataService : ISprint5Task6V20
    {
        public int LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден.", path);

            string text = File.ReadAllText(path);

            // Разбиваем на слова
            char[] separators = new char[] { ' ', '\t', '\r', '\n' };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            int count = 0;
            foreach (var word in words)
            {
                if (word.Length == 6)
                    count++;
            }

            return count;
        }
    }
}
