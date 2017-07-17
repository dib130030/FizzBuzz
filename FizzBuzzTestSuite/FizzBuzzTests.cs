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
        static string GetLastFizzBuzz(FizzBuzzLib.FizzBuzzClass fb)
        {
            string last = string.Empty;
            foreach (var line in fb.FizzBuzz())
            {
                last = line;
            }
            return last;
        }

        [Test]
        public void TestFizzBuzz3()
        {
            var fb = new FizzBuzzLib.FizzBuzzClass { UpperBound = 3 };
            string last = GetLastFizzBuzz(fb);
            Assert.AreEqual(last, "3 Fizz");
        }

        [Test]
        public void TestFizzBuzz5()
        {
            var fb = new FizzBuzzLib.FizzBuzzClass { UpperBound = 5 };
            string last = GetLastFizzBuzz(fb);
            Assert.AreEqual(last, "5 Buzz");
        }

        [Test]
        public void TestFizzBuzz14()
        {
            var fb = new FizzBuzzLib.FizzBuzzClass { UpperBound = 14 };
            string last = GetLastFizzBuzz(fb);
            Assert.AreEqual(last, "14");
        }

        [Test]
        public void TestFizzBuzz15()
        {
            var fb = new FizzBuzzLib.FizzBuzzClass { UpperBound = 15 };
            string last = GetLastFizzBuzz(fb);
            Assert.AreEqual(last, "15 FizzBuzz");
        }

        [Test]
        public void TestFizzBuzz25()
        {
            var fb = new FizzBuzzLib.FizzBuzzClass { UpperBound = 25 };
            string last = GetLastFizzBuzz(fb);
            Assert.AreEqual(last, "25 Buzz");
        }

        [Test]
        public void TestFizzBuzz27()
        {
            var fb = new FizzBuzzLib.FizzBuzzClass { UpperBound = 27 };
            string last = GetLastFizzBuzz(fb);
            Assert.AreEqual(last, "27 Fizz");
        }

        [Test]
        public void TestFizzBuzz30()
        {
            var fb = new FizzBuzzLib.FizzBuzzClass { UpperBound = 30 };
            string last = GetLastFizzBuzz(fb);
            Assert.AreEqual(last, "30 FizzBuzz");
        }

        [Test]
        public void TestFizzBuzzP5()
        {
            var fb = new FizzBuzzLib.FizzBuzzClass { UpperBound = 5, FizzNum = 5, BuzzNum = 7, FizzStr = "Fives", BuzzStr = "Sevens" };
            string last = GetLastFizzBuzz(fb);
            Assert.AreEqual(last, "5 Fives");
        }

        [Test]
        public void TestFizzBuzzP7()
        {
            var fb = new FizzBuzzLib.FizzBuzzClass { UpperBound = 7, FizzNum = 5, BuzzNum = 7, FizzStr = "Fives", BuzzStr = "Sevens" };
            string last = GetLastFizzBuzz(fb);
            Assert.AreEqual(last, "7 Sevens");
        }

        [Test]
        public void TestFizzBuzzP35()
        {
            var fb = new FizzBuzzLib.FizzBuzzClass { UpperBound = 35, FizzNum = 5, BuzzNum = 7, FizzStr = "Fives", BuzzStr = "Sevens" };
            string last = GetLastFizzBuzz(fb);
            Assert.AreEqual(last, "35 FivesSevens");
        }

        [Test]
        public void TestFizzBuzzInvalidUpperBound()
        {
            var fb = new FizzBuzzLib.FizzBuzzClass { UpperBound = -1 };
            string last = GetLastFizzBuzz(fb);
            Assert.AreEqual(last, string.Empty);
        }
    }
}
