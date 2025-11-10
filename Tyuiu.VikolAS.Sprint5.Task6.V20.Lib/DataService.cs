using System;
using System.IO;
using System.Linq;
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

            // Разделители слов
            char[] separators = new char[] { ' ', '\t', '\r', '\n' };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            int count = 0;
            foreach (var word in words)
            {
                // Убираем все небуквенные символы (знаки препинания)
                string cleanWord = new string(word.Where(c => char.IsLetterOrDigit(c)).ToArray());

                if (cleanWord.Length == 6)
                    count++;
            }

            return count;
        }
    }
}
