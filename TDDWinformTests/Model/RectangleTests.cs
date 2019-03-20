using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDWinform.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDWinform.Model.Tests
{
    [TestClass()]
    public class RectangleTests
    {
        [TestMethod()]
        public void CalculateAreaTest()
        {
            Rectangle rect = new Rectangle();
            rect.Length = 12;
            rect.Breadth = 3;

            Assert.AreEqual(36, rect.CalculateArea());
        }
    }
}