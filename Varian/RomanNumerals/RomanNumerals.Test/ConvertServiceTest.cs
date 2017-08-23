using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals;

namespace RomanNumerals.Test
{
    [TestClass]
    public class ConvertServiceTest
    {
        [TestMethod]
        public void OneTo_I_Test()
        {
            ConvertService svc = new ConvertService();

            string result = svc.DoTransform(1);

            Assert.AreEqual("I", result);
        }

        [TestMethod]
        public void FiveTo_V_Test()
        {
            ConvertService svc = new ConvertService();

            string result = svc.DoTransform(5);

            Assert.AreEqual("V", result);
        }

        [TestMethod]
        public void TenTo_X_Test()
        {
            ConvertService svc = new ConvertService();

            string result = svc.DoTransform(10);

            Assert.AreEqual("X", result);
        }

        [TestMethod]
        public void FiftyTo_L_Test()
        {
            ConvertService svc = new ConvertService();

            string result = svc.DoTransform(50);

            Assert.AreEqual("L", result);
        }

        [TestMethod]
        public void HundredTo_C_Test()
        {
            ConvertService svc = new ConvertService();

            string result = svc.DoTransform(100);

            Assert.AreEqual("C", result);
        }

        [TestMethod]
        public void FiveHundredTo_D_Test()
        {
            ConvertService svc = new ConvertService();

            string result = svc.DoTransform(500);

            Assert.AreEqual("D", result);
        }

        [TestMethod]
        public void ThousandTo_M_Test()
        {
            ConvertService svc = new ConvertService();

            string result = svc.DoTransform(1000);

            Assert.AreEqual("M", result);
        }

        [TestMethod]
        public void TwoTo_II_Test()
        {
            ConvertService svc = new ConvertService();

            string result = svc.DoTransform(2);

            Assert.AreEqual("II", result);
        }

        [TestMethod]
        public void FiftyTwoTo_LII_Test()
        {
            ConvertService svc = new ConvertService();

            string result = svc.DoTransform(52);

            Assert.AreEqual("L II", result);
        }

        [TestMethod]
        public void NinetySevenTo_XCVII_Test()
        {
            ConvertService svc = new ConvertService();

            string result = svc.DoTransform(97);

            Assert.AreEqual("XC VII", result);
        }

        [TestMethod]
        public void FourHundredSixtySevenTo_CDLXVII_Test()
        {
            ConvertService svc = new ConvertService();

            string result = svc.DoTransform(467);

            Assert.AreEqual("CD LX VII", result);
        }

        [TestMethod]
        public void EightHundredSeventyFiveTo_DCCCLXXV_Test()
        {
            ConvertService svc = new ConvertService();

            string result = svc.DoTransform(875);

            Assert.AreEqual("DCCC LXX V", result);
        }

        [TestMethod]
        public void ThreeThousandSixHundredTwentyFiveTo_MMMDCXXV_Test()
        {
            ConvertService svc = new ConvertService();

            string result = svc.DoTransform(3625);

            Assert.AreEqual("MMM DC XX V", result);
        }
    }
}
