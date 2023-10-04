using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.CherepanovVS.Sprint1.Task3.V19.Lib;

namespace Tyuiu.CherepanovVS.Sprint1.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wate = 6;
            var res = ds.ConvertInchToKm(x,y);
            Assert.AreEqual(wate, res);

        }
    }
}
