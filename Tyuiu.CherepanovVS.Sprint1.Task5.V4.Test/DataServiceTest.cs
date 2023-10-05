using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.CherepanovVS.Sprint1.Task5.V4.Lib;


namespace Tyuiu.CherepanovVS.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServicTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int time = 2121545;
            int result = ds.SecondsToHours(time);
            int wait = 589;
            Assert.AreEqual(result, wait);
        }
    }
}
