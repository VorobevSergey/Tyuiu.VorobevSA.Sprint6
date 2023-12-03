using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sprint6.Task3.V5.Lib;

namespace Tyuiu.VorobevSA.Sprint6.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            int[,] testMode1 = { { 30,-20,7,-8,9},
                                 { 32,17,-14,-7,33},
                                 { 19,-19,-13,14,-20},
                                 { 11,30,-1,26,6},
                                 { 30,-15,-20,-5,15} };
            int[,] testMode2 = { { 30,-20,-20,-8,9},
                                 { 32,17,-14,-7,33},
                                 { 19,-19,-13,14,-20},
                                 { 11,30,-1,26,6},
                                 { 30,-15,7,-5,15} };
            CollectionAssert.AreEqual(testMode2, service1.Calculate(testMode1));
        }
    }
}
