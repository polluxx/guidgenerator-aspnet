using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JunitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodOk()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestMethodFail()
        {
            //Assert.Fail();
            Assert.IsTrue(true);
        }
    }
}
