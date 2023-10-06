using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.CherepanovVS.Sprint1.Task6.V10.Lib; 

namespace Tyuiu.CherepanovVS.Sprint1.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string strTest = "Здравствуйте, как вас зовут?";
            string res = ds.DeleteMiddleLetter(strTest);
            string wait = "Здравствуйте кк вс зоут";
            Assert.AreEqual(res, wait);
        }
    }
}
