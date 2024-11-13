using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestBlackBox
{
    [TestClass]
    public class TestUTLab01
    {
        MethodLibrary.MethodLibrary test = new MethodLibrary.MethodLibrary();
        public TestContext TestContext { get; set; }


        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        "|DataDirectory|\\dataUTLab01.csv", "dataUTLab01.csv",
        DataAccessMethod.Sequential),
        DeploymentItem("dataUTLab01.csv"), TestMethod]
        public void TestMethod1()
        {
            var aValue = TestContext.DataRow["A"].ToString();
            var bValue = TestContext.DataRow["B"].ToString();
            var cValue = TestContext.DataRow["C"].ToString();
            var expectedResult = TestContext.DataRow["result"].ToString();

            if (expectedResult == "exception")
            {
                Assert.ThrowsException<Exception>(() =>
                {
                    int a = Convert.ToInt32(aValue);
                    int b = Convert.ToInt32(bValue);
                    int c = Convert.ToInt32(cValue);
                    test.Max(a, b, c);
                });
            }
            else
            {
                int a = Convert.ToInt32(aValue);
                int b = Convert.ToInt32(bValue);
                int c = Convert.ToInt32(cValue);
                int expected = Convert.ToInt32(expectedResult);

                int actual = test.Max(a, b, c);

                Assert.AreEqual(expected, actual);
            }
        }
    }
}
