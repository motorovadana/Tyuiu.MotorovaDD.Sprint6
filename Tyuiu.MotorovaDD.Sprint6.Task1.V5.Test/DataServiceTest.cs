using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MotorovaDD.Sprint6.Task1.V5.Lib;

namespace Tyuiu.MotorovaDD.Sprint6.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueWaitArray = new double[len];

            valueWaitArray[0] = 8.04;
            valueWaitArray[1] = 6.68;
            valueWaitArray[2] = 4.84;
            valueWaitArray[3] = 1.76;
            valueWaitArray[4] = 0.45;
            valueWaitArray[5] = 0.50;
            valueWaitArray[6] = -0.87;
            valueWaitArray[7] = 0.00;
            valueWaitArray[8] = -3.88;
            valueWaitArray[9] = -6.83;
            valueWaitArray[10] = -8.88;

            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
