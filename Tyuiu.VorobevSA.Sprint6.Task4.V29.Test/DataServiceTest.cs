using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sprint6.Task4.V29.Lib;

namespace Tyuiu.VorobevSA.Sprint6.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            double[] TestA = new double[] { -32.26, -27.50, -22.80, -17.95, -12.97, -9, -0.31, 3.77, 8.57, 13.42, 18.28 };
            CollectionAssert.AreEqual(TestA, service1.GetMassFunction(-5, 5));
        }
    }
}
