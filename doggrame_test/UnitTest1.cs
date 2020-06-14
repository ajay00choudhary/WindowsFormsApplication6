using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace doggrame_test
{
    [TestClass]
    public class UnitTest1
    {
        public int bet()
        {
            return (10);
        }
        public int winneramount()
        {
            return(20);
        }
        [TestMethod]
        public void TestMethod1()
        {
            int actual_scores = 10;
            UnitTest1 h = new UnitTest1();
            int expected = h.bet();
            Assert.AreEqual(actual_scores, expected, 0.001, "Game is running correctly");       
        }
        [TestMethod]
        public void TestMethod2()
        {
            int actual_scores = 20;
            UnitTest1 h = new UnitTest1();
            int expected = h.bet();
            Assert.AreEqual(actual_scores, expected, 0.001, "Game is running correctly");
        }
    }
}
