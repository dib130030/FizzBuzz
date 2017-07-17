using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzzTestSuite
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void TestFizzBuzz()
        {
            var fb = new FizzBuzzLib.FizzBuzzClass(15);
            string last = string.Empty;
            foreach (var line in fb.FizzBuzz())
            {
                last = line;
            }
            Assert.AreEqual(last, "15 FizzBuzz");
        }
    }
}
