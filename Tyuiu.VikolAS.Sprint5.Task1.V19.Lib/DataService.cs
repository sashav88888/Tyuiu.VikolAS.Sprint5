using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VikolAS.Sprint5.Task1.V19.Lib
{
    public class DataService : ISprint5Task1V19
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                    double y;
                    double denominator = 3 * x + 0.5;
                    if (denominator == 0)
                    {
                        y = 0;
                    }
                    else
                    {
                        y = (Math.Sin(x) + (2 / denominator) - 2 * Math.Cos(x)) * 2 * x;
                    }
                    writer.WriteLine(Math.Round(y, 2));
                }
            }

            return path;
        }
    }
}
