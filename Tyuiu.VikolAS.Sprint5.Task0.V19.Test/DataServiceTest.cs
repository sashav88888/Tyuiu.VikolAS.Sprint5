using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.VikolAS.Sprint5.Task0.V19.Lib;

namespace Tyuiu.VikolAS.Sprint5.Task0.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculationAndFileSave()
        {
            DataService ds = new DataService();
            int x = 3;

            string path = ds.SaveToFileTextData(x);
            Assert.IsTrue(File.Exists(path));

            string result = File.ReadAllText(path);
            double value = Convert.ToDouble(result);

            double expected = Math.Round((2 * Math.Pow(x, 2) - 1) / Math.Sqrt(Math.Pow(x, 2) - 2), 3);
            Assert.AreEqual(expected, value);
        }
    }
}
