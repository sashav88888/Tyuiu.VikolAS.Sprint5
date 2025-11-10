using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VikolAS.Sprint5.Task4.V21.Lib;
using System.IO;

namespace Tyuiu.VikolAS.Sprint5.Task4.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Создаем временный файл
            string tempFile = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4V0.txt");
            File.WriteAllText(tempFile, "2.5"); // пример значения

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(tempFile);

            // Вычисляем ожидаемый результат
            double expected = Math.Round(Math.Pow(2.5, 3) * Math.Cos(2.5) + 2 * 2.5, 3);
            Assert.AreEqual(expected, result);
        }
    }
}
