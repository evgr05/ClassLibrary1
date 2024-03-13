using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class BiblTests
        {
            [TestMethod]
            public void TestMinWhenFirstIsMin()
            {
                int result = Bibl.Min(2, 5, 7);
                Assert.AreEqual(2, result);
            }

            [TestMethod]
            public void TestMinWhenSecondIsMin()
            {
                int result = Bibl.Min(8, 4, 10);
                Assert.AreEqual(4, result);
            }

            [TestMethod]
            public void TestMinWhenThirdIsMin()
            {
                int result = Bibl.Min(6, 9, 3);
                Assert.AreEqual(3, result);
            }
            [TestMethod]
            public void TestNoMin()
            {
                int result = Bibl.Min(2, 5, 7);
                Assert.AreEqual(7, result);
            }
        }
    }
}