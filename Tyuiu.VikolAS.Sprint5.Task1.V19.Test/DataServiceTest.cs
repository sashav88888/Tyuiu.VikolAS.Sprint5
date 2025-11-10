using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.VikolAS.Sprint5.Task1.V19.Lib;

namespace Tyuiu.VikolAS.Sprint5.Task1.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(-5, 5);

            Assert.IsTrue(File.Exists(path));

            string[] lines = File.ReadAllLines(path);
            Assert.AreEqual(11, lines.Length);
        }
    }
}
