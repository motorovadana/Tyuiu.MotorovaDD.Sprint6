using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.MotorovaDD.Sprint6.Task6.V6.Lib;

namespace Tyuiu.MotorovaDD.Sprint6.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = "file.txt";
            System.IO.File.WriteAllText(path, "kvrwY jVdRV wFrlYaZtHI AJuvHYzIfi WfmrpQjAze gtlOC XuLENkL l oqCuXN lG YebQ BV ypiUHHFJ eAezSXF aPIjKf wMQ M ltxrhBXm eqSGAiC PvLqtMALPm zCOZQ Qxv HbJcPW wUdVEuNB aidoqRW");
            string result = ds.CollectTextFromFile(path);

            string exp = " YebQ HbJcPW";
            Assert.AreEqual(exp, result);
            System.IO.File.Delete(path);
        }
    }
}
