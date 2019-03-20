using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDWinform.Model;

namespace TDDWinformTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateAreaTest()
        {
            Rectangle rect = new Rectangle();
            rect.Length = 12;
            rect.Breadth = 3;

            Assert.AreEqual(12, rect.Length);
            Assert.AreEqual(3, rect.Breadth);
            Assert.AreEqual(36, rect.CalculateArea());
        }
    }
}
