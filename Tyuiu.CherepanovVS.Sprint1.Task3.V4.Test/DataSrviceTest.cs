using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.CherepanovVS.Sprint1.Task3.V4.Lib;

namespace Tyuiu.CherepanovVS.Sprint1.Task3.V4.Test
{
    [TestClass]
    public class DataSrviceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double priceNotebook = 2.75;
            double priceCover = 0.5;
            int quantity = 7;
            double wate = 22.75;
            var res = ds.PurchaseAmount(priceNotebook, priceCover, quantity);
            Assert.AreEqual(wate, res);

        }
    }
}