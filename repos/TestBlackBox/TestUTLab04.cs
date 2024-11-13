using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestBlackBox
{
    [TestClass]
    public class TestUTLab04
    {
        MethodLibrary.MethodLibrary test = new MethodLibrary.MethodLibrary();

        // Test case 1: Valid partition (s0 = 0)
        [TestMethod]
        public void TestMethod1()
        {
            long s;
            long k = test.Sum(0, out s);
            Assert.AreEqual(1, k);
            Assert.AreEqual(1, s);
        }

        // Test case 2: Valid partition (s0 = 1)
        [TestMethod]
        public void TestMethod2()
        {
            long s;
            long k = test.Sum(1, out s);
            Assert.AreEqual(2, k);
            Assert.AreEqual(3, s);
        }

        // Test case 3: Valid partition (s0 = 10)
        [TestMethod]
        public void TestMethod3()
        {
            long s;
            long k = test.Sum(10, out s);
            Assert.AreEqual(4, k);
            Assert.AreEqual(10, s);
        }

        // Test case 4: Valid partition (s0 = 20)
        [TestMethod]
        public void TestMethod4()
        {
            long s;
            long k = test.Sum(20, out s);
            Assert.AreEqual(6, k);
            Assert.AreEqual(21, s);
        }

        // Test case 5: Valid partition (s0 = 100)
        [TestMethod]
        public void TestMethod5()
        {
            long s;
            long k = test.Sum(100, out s);
            Assert.AreEqual(14, k);
            Assert.AreEqual(105, s);
        }

        // Test case 6: Valid partition (s0 = 500)
        [TestMethod]
        public void TestMethod6()
        {
            long s;
            long k = test.Sum(500, out s);
            Assert.AreEqual(32, k);
            Assert.AreEqual(528, s);
        }

        // Test case 7: Invalid partition (s0 = -1)
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod7()
        {
            long s;
            test.Sum(-1, out s);
        }

        // Test case 8: Invalid partition (s0 = -10)
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod8()
        {
            long s;
            test.Sum(-10, out s);
        }

        // Test case 9: Valid boundary (s0 = 2)
        [TestMethod]
        public void TestMethod9()
        {
            long s;
            long k = test.Sum(2, out s);
            Assert.AreEqual(3, k);
            Assert.AreEqual(6, s);
        }

        // Test case 10: Valid boundary (s0 = 3)
        [TestMethod]
        public void TestMethod10()
        {
            long s;
            long k = test.Sum(3, out s);
            Assert.AreEqual(4, k);
            Assert.AreEqual(10, s);
        }

        // Test case 11: Invalid boundary (s0 = -2)
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod11()
        {
            long s;
            test.Sum(-2, out s);
        }

        // Test case 12: Invalid boundary (s0 = -100)
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod12()
        {
            long s;
            test.Sum(-100, out s);
        }
    }
}
