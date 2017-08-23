using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals;

namespace RomanNumerals.Test
{
    [TestClass]
    public class ConvertServiceTest
    {
        [TestMethod]
        public void OneToITest()
        {
            ConvertService svc = new ConvertService();

            string result = svc.DoTransform(1);

            Assert.AreEqual("I", result);
        }

        [TestMethod]
        public void FiveToVTest()
        {
            ConvertService svc = new ConvertService();

            string result = svc.DoTransform(5);

            Assert.AreEqual("V", result);
        }

        [TestMethod]
        public void TenToXTest()
        {
            ConvertService svc = new ConvertService();

            string result = svc.DoTransform(10);

            Assert.AreEqual("X", result);
        }

        [TestMethod]
        public void FiftyToLTest()
        {
            ConvertService svc = new ConvertService();

            string result = svc.DoTransform(50);

            Assert.AreEqual("L", result);
        }

        [TestMethod]
        public void HundredToCTest()
        {
            ConvertService svc = new ConvertService();

            string result = svc.DoTransform(100);

            Assert.AreEqual("C", result);
        }

        [TestMethod]
        public void FiveHundredToDTest()
        {
            ConvertService svc = new ConvertService();

            string result = svc.DoTransform(500);

            Assert.AreEqual("D", result);
        }

        [TestMethod]
        public void ThousandToMTest()
        {
            ConvertService svc = new ConvertService();

            string result = svc.DoTransform(1000);

            Assert.AreEqual("M", result);
        }

    }
}
