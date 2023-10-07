using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.CherepanovVS.Sprint1.Task7.V2.Lib;

namespace Tyuiu.CherepanovVS.Sprint1.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 2;
            double wait = 1.425;
            double z = ds.Calculate(x, y);
            double res = Math.Round(z, 3);
            Assert.AreEqual(wait, res);
        }
    }
}
