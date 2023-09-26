using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.CherepanovVS.Sprint1.Task1.V19.Lib;

namespace Tyuiu.CherepanovVS.Sprint1.Task1.V19.Test
{
    [TestClass]
    public class DataService
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService1 ret = new DataService1();
            double x = 5.0;
            double y = 1.0;
            double i = ret.Calculate(x, y);
            Assert.AreEqual(i, 4);
        }
    }
}
