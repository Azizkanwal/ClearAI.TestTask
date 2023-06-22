using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClearAI.UnitTest
{
    [TestClass]
    public class SumAPI
    {
        [TestMethod]
        public void TestAddOfTwoNums()
        {
            // Test the Test/Add api
            var controller = new TestController();

            // Sum of two numbers
            var result = controller.Add(1,2);
            Assert.AreEqual(2, result);
        }
    }
}
