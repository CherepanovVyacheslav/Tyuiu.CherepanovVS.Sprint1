using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.CherepanovVS.Sprint1.V0.Lib;

namespace Tyuiu.CherepanovVS.Sprint1.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 3;
            var i = ds.Calculate(x, y);
            Assert.AreEqual(i, -7);



        }
    }
}
