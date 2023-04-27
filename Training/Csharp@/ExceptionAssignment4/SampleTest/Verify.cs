using ExceptionAssignment4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions; 

namespace SampleTest
{
    [TestClass]
    public class Verify
    {
        [TestMethod]7 
        public void TestMethod1()
        {
            var test = new MyStack();
            Assert.IsFalse(test.IsNoob);   
        }

        [TestMethod]
        public void TestMethod2()
        {
            int a = 3;
            Assert.IsNull(a);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int a = 3;
            int b = 3;
            Assert.AreEqual(a , b);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int x = 3;
            int y = 4;
            Assert.AreNotEqual(x, y);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string r = "Hello Ruchita";
            StringAssert.Contains(r, "Hello");
        }

        [TestMethod]
        public void TestMethod6()
        {
            int x = 20;
            Assert.IsFalse(x < 3);
        }
    }
}    