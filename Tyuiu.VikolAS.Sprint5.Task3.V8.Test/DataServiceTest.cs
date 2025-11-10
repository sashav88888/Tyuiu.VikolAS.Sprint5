using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.VikolAS.Sprint5.Task3.V8.Lib;

namespace Tyuiu.VikolAS.Sprint5.Task3.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestSaveToFileTextData()
        {
            DataService ds = new DataService();
            int x = 3;
            string path = ds.SaveToFileTextData(x);

            double expected = Math.Round((Math.Pow(x, 2) + 1) / (3 * x + 4), 3);

            double result;
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                result = reader.ReadDouble();
            }

            Assert.AreEqual(expected, result);
        }
    }
}
