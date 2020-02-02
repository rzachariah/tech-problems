using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using minSum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace minSumTest
{
    [TestClass]
    public class Cases
    {
        [TestMethod]
        public void Case0()
        {
            Assert.AreEqual(1, Result.minSum(new List<int> { 2 }, 1));
        }

        [TestMethod]
        public void Case1()
        {
            Assert.AreEqual(4, Result.minSum(new List<int> { 2, 3 }, 1));
        }

        [TestMethod]
        public void Case3()
        {
            Assert.AreEqual(75, Result.minSum(new List<int> { 100, 100 }, 3));
        }

        [TestMethod]
        public void Case4()
        {
            var input = Enumerable.Repeat(10000, 10000).ToList();
            Assert.AreEqual(50000000, Result.minSum(input, 10000));
        }

        [TestMethod]
        public void Case5()
        {
            var input = Enumerable.Repeat(10000, 10000).ToList();
            Assert.AreEqual(3130000, Result.minSum(input, 50000));
        }

        [TestMethod]
        public void Case6()
        {
            var input = Enumerable.Repeat(10000, 10000).ToList();
            var sw = Stopwatch.StartNew();
            Assert.AreEqual(10000, Result.minSum(input, 10000000));
            Assert.IsTrue(sw.ElapsedMilliseconds < 1000);
        }

        [TestMethod]
        public void Case7()
        {
            var input = Enumerable.Repeat(10000, 100000).ToList();
            var sw = Stopwatch.StartNew();
            Assert.AreEqual(100000, Result.minSum(input, 10000000));
            Assert.IsTrue(sw.ElapsedMilliseconds < 1000);
        }
    }
}
