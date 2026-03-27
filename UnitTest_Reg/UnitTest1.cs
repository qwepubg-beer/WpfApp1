using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static WpfApp1.Regestration;
namespace UnitTest_Reg
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(Enter("test","test"));
            Assert.IsFalse(Enter("test", "1234"));
            Assert.IsFalse(Enter("", ""));
            Assert.IsFalse(Enter("    ", "    "));
        }
    }
}

