using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.CherepanovVS.Sprint1.Task4.V19.Lib;


namespace Tyuiu.CherepanovVS.Sprint1.Task4.V19.Test
{
    [TestClass]
    public class DataSrviceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 4;
            double wait = 3;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
