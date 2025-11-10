using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VikolAS.Sprint5.Task7.V22.Lib;

namespace Tyuiu.VikolAS.Sprint5.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestLoadDataAndSave()
        {
            // Создаем временный файл с тестовыми данными
            string tempInput = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V22.txt");
            string testData = "Hello, world! Привет, мир.";
            File.WriteAllText(tempInput, testData);

            DataService ds = new DataService();
            string outputFile = ds.LoadDataAndSave(tempInput);

            string result = File.ReadAllText(outputFile);

            string expected = "Hello# world# Привет# мир#";

            Assert.AreEqual(expected, result);
        }
    }
}
