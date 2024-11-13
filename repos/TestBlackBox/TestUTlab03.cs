using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestBlackBox
{
    [TestClass]
    public class TestUTLab03
    {
        MethodLibrary.MethodLibrary test = new MethodLibrary.MethodLibrary();

        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        "|DataDirectory|\\dataUTlab03.csv", "dataUTlab03.csv",
        DataAccessMethod.Sequential),
        DeploymentItem("dataUTlab03.csv"), TestMethod]
        public void TestTinhChiSo()
        {
            var chiSoCu = TestContext.DataRow["chiSoCu"].ToString();
            var chiSoMoi = TestContext.DataRow["chiSoMoi"].ToString();
            var expectedOutput = TestContext.DataRow["ExpectedOutput"].ToString();

            if (expectedOutput == "-1")
            {
                Assert.ThrowsException<Exception>(() =>
                {
                    int cu = Convert.ToInt32(chiSoCu);
                    int moi = Convert.ToInt32(chiSoMoi);
                    test.TinhTienDien(cu, moi);
                });
            }
            else
            {
                int cu = Convert.ToInt32(chiSoCu);
                int moi = Convert.ToInt32(chiSoMoi);
                int expected = Convert.ToInt32(expectedOutput);

                double actual = test.TinhTienDien(cu, moi);

                Assert.AreEqual(expected, actual);
            }
        }
    }
}
