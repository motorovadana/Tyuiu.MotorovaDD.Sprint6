using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MotorovaDD.Sprint6.Task4.V26.Lib;
namespace Tyuiu.MotorovaDD.Sprint6.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            {
                DataService ds = new DataService();
                int startValue = -5;
                int stopValue = 5;
                double[] valueArray;
                valueArray = ds.GetMassFunction(startValue, stopValue);
                double res = valueArray[0];
                double wait = 19.81;
            }
            
        }
    }
}
