using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sprint6.Task0.V24.Lib;

namespace Tyuiu.VorobevSA.Sprint6.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();

            int x = 3;
            double res = service1.Calculate(x);
            Assert.AreEqual(res, 256);
        }
    }
}
