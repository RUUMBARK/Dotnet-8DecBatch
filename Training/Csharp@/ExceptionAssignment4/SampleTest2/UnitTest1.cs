using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleTest2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Default")]
        public void TestMethod1()
        {
            var test = new ExceptionAssignment4.MyStack();
            Assert.IsFalse(test.IsNoob);
        }
    }
}

