using System;
using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VikolAS.Sprint5.Task1.V19.Lib
{
    public class DataService : ISprint5Task1V19
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            var culture = new CultureInfo("ru-RU");

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                    double denom = 3.0 * x + 0.5;
                    double fraction;
                    if (Math.Abs(denom) < Double.Epsilon)
                    {
                        fraction = 0.0;
                    }
                    else
                    {
                        fraction = 2.0 / denom;
                    }

                    // Формула: sin(x) + ( 2/(3x+0.5) - 2*cos(x)*2*x )
                    double y = Math.Sin(x) + (fraction - 2.0 * Math.Cos(x) * 2.0 * x);

                    writer.WriteLine(y.ToString("F2", culture));
                }
            }

            return path;
        }
    }
}
