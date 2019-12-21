using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace ActivityMonitor.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            using (var sw = new StringWriter()) {

                Console.SetOut(sw);

                ActivityMonitor.Program.print();

                var result = sw.ToString().Trim();

                Assert.AreEqual("Activity monitor!", result);
            }           
        }
    }
}
