using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.VikolAS.Sprint5.Task2.V19.Lib;

namespace Tyuiu.VikolAS.Sprint5.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestSaveToFileTextData()
        {
            DataService ds = new DataService();

            int[,] matrix =
            {
                { 9, 2, 5 },
                { 8, 8, 2 },
                { 7, 4, 8 }
            };

            string path = ds.SaveToFileTextData(matrix);

            Assert.IsTrue(File.Exists(path));

            string[] lines = File.ReadAllLines(path);
            Assert.AreEqual("0;2;0", lines[0]);
            Assert.AreEqual("8;8;2", lines[1]);
            Assert.AreEqual("0;4;8", lines[2]);
        }
    }
}
