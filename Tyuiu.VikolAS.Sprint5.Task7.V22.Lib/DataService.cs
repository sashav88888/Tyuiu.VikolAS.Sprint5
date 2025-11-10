using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VikolAS.Sprint5.Task7.V22.Lib
{
    public class DataService : ISprint5Task7V22
    {
        public string LoadDataAndSave(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден", path);

            string content = File.ReadAllText(path, Encoding.UTF8);

            // Заменяем все знаки препинания на #
            StringBuilder sb = new StringBuilder();
            foreach (char c in content)
            {
                sb.Append(char.IsPunctuation(c) ? '#' : c);
            }

            string outputFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V22.txt");
            File.WriteAllText(outputFile, sb.ToString(), Encoding.UTF8);

            return outputFile;
        }
    }
}
