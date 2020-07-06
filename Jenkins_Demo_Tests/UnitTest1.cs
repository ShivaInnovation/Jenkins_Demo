using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace Jenkins_Demo_Tests
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World! from Jenkins";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Jenkins_Demo.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}
