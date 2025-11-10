using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.VikolAS.Sprint5.Task5.V1.Lib;

namespace Tyuiu.VikolAS.Sprint5.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Создаем временный файл для теста
            string tempFile = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V1.txt");
            File.WriteAllText(tempFile, "1 2 3 4 5 6 7.0 8.5 10.0");

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(tempFile);

            // Ожидаемая сумма чисел, делящихся на 2: 2 + 4 + 6 + 7.0 + 10.0? 
            // Только четные: 2 + 4 + 6 + 10 = 22
            Assert.AreEqual(22.0, result);
        }
    }
}
