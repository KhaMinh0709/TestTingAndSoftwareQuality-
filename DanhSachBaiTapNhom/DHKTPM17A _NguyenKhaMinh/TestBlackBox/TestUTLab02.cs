using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestBlackBox
{
    [TestClass]
    public class TestUTLab02
    {
        MethodLibrary.MethodLibrary test = new MethodLibrary.MethodLibrary();

        [TestMethod]
        public void TestVaoSoNghiem()
        {
            TestCase(0, 0, 0, "Vô số nghiệm"); // Test case 1
        }

        [TestMethod]
        public void TestVoNghiem()
        {
            TestCase(1, 2, 4, "Vô nghiệm"); // Test case 2
        }

        [TestMethod]
        public void TestVoNghiemWithInvalidBoundary()
        {
            TestCase(1, 1, 1, "Vô nghiệm"); // Test case 3
        }

        [TestMethod]
        public void TestCoMotNghiem()
        {
            TestCase(1, 2, 1, "Có nghiệm kép"); // Test case 4
        }

        [TestMethod]
        public void TestCoHaiNghiemPhanBiet()
        {
            TestCase(1, -3, 2, "Có 2 nghiệm phân biệt"); // Test case 5
        }

        [TestMethod]
        public void TestCoNghiemKep()
        {
            TestCase(1, 2, 1, "Có nghiệm kép"); // Test case 6
        }

        [TestMethod]
        public void TestVoNghiemWithNegativeDiscriminant()
        {
            TestCase(1, 2, 4, "Vô nghiệm"); // Test case 7
        }

        [TestMethod]
        public void TestCoHaiNghiemPhanBietWithPositiveDiscriminant()
        {
            TestCase(1, -3, 2, "Có 2 nghiệm phân biệt"); // Test case 8
        }

        [TestMethod]
        public void TestCoNghiemKepWithDiscriminantZero()
        {
            TestCase(1, 2, 1, "Có nghiệm kép"); // Test case 9
        }

        [TestMethod]
        public void TestVoNghiemWithNonZeroCoefficients()
        {
            TestCase(1, 1, 1, "Vô nghiệm"); // Test case 10
        }

        [TestMethod]
        public void TestCoHaiNghiemPhanBietWithDiscriminantPositive()
        {
            TestCase(1, -5, 6, "Có 2 nghiệm phân biệt"); // Test case 11
        }

        [TestMethod]
        public void TestCoNghiemKepWithZeroDiscriminant()
        {
            TestCase(1, 4, 4, "Có nghiệm kép"); // Test case 12
        }

        [TestMethod]
        public void TestVoNghiemWithCoefficientsLeadingToNegativeDiscriminant()
        {
            TestCase(1, 1, 1, "Vô nghiệm"); // Test case 13
        }

        [TestMethod]
        public void TestCoHaiNghiemPhanBietWithValidInput()
        {
            TestCase(2, 4, 2, "Có 2 nghiệm phân biệt"); // Test case 14
        }

        [TestMethod]
        public void TestCoHaiNghiemPhanBietWithMoreComplexValues()
        {
            TestCase(3, 5, 2, "Có 2 nghiệm phân biệt"); // Test case 15
        }

        [TestMethod]
        public void TestVoNghiemWithAnotherInvalidSet()
        {
            TestCase(2, 2, 2, "Vô nghiệm"); // Test case 16
        }

        private void TestCase(int a, int b, int c, string expectedResult)
        {
            float x1, x2;
            string output = test.SolveQuadratic(a, b, c, out x1, out x2);
            Assert.AreEqual(expectedResult, output);
        }
    }
}

