using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VikolAS.Sprint5.Task6.V20.Lib;

namespace Tyuiu.VikolAS.Sprint5.Task6.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            // Создаем временный файл с тестовыми данными
            string tempPath = Path.Combine(Path.GetTempPath(), "TestFile.txt");
            File.WriteAllText(tempPath, "apple banana orange cherry melon grape");

            int result = ds.LoadFromDataFile(tempPath);

            // В строке 3 слова длиной 6 символов: banana, orange, cherry
            Assert.AreEqual(3, result);
        }
    }
}
