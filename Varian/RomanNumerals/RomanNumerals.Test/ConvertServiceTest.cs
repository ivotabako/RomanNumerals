using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals;

namespace RomanNumerals.Test
{
    [TestClass]
    public class ConvertServiceTest
    {
        private ISolution svc;

        [TestInitialize()]
        public void Initialize()
        {
            //svc = new ConvertServiceDeclarativeSolution();
            //svc = new ConvertService();
            svc = new ConvertServiceAlgorithmicSolution();
        }

        [TestMethod]
        public void OneTo_I_Test()
        {
            
            string result = svc.DoTransform(1);

            Assert.AreEqual("I", result);
        }

        [TestMethod]
        public void FiveTo_V_Test()
        {           
            string result = svc.DoTransform(5);

            Assert.AreEqual("V", result);
        }

        [TestMethod]
        public void TenTo_X_Test()
        {            
            string result = svc.DoTransform(10);

            Assert.AreEqual("X", result);
        }

        [TestMethod]
        public void FiftyTo_L_Test()
        {            
            string result = svc.DoTransform(50);

            Assert.AreEqual("L", result);
        }

        [TestMethod]
        public void HundredTo_C_Test()
        {          
            string result = svc.DoTransform(100);

            Assert.AreEqual("C", result);
        }

        [TestMethod]
        public void FiveHundredTo_D_Test()
        {
           
            string result = svc.DoTransform(500);

            Assert.AreEqual("D", result);
        }

        [TestMethod]
        public void ThousandTo_M_Test()
        {
         
            string result = svc.DoTransform(1000);

            Assert.AreEqual("M", result);
        }

        [TestMethod]
        public void TwoTo_II_Test()
        {
          
            string result = svc.DoTransform(2);

            Assert.AreEqual("II", result);
        }

        [TestMethod]
        public void FiftyTwoTo_LII_Test()
        {
          
            string result = svc.DoTransform(52);

            Assert.AreEqual("L II", result);
        }

        [TestMethod]
        public void NinetySevenTo_XCVII_Test()
        {
           
            string result = svc.DoTransform(97);

            Assert.AreEqual("XC VII", result);
        }

        [TestMethod]
        public void FourHundredSixtySevenTo_CDLXVII_Test()
        {
            
            string result = svc.DoTransform(467);

            Assert.AreEqual("CD LX VII", result);
        }

        [TestMethod]
        public void EightHundredSeventyFiveTo_DCCCLXXV_Test()
        {
          
            string result = svc.DoTransform(875);

            Assert.AreEqual("DCCC LXX V", result);
        }

        [TestMethod]
        public void ThreeThousandSixHundredTwentyFiveTo_MMMDCXXV_Test()
        {
          
            string result = svc.DoTransform(3625);

            Assert.AreEqual("MMM DC XX V", result);
        }

        [TestMethod]
        public void NumberBiggerThan3999_Test()
        {
          
            string result = svc.DoTransform(5432);

            Assert.AreEqual("5432", result);
        }

        [TestMethod]
        public void NumberSmallerThan1_Test()
        {
           
            string result = svc.DoTransform(-35);

            Assert.AreEqual("-35", result);
        }

        [TestMethod]
        public void FourTo_IV_Test()
        {
            

            string result = svc.DoTransform(4);

            Assert.AreEqual("IV", result);
        }

        [TestMethod]
        public void EightTo_VIII_Test()
        {
            

            string result = svc.DoTransform(8);

            Assert.AreEqual("VIII", result);
        }

        [TestMethod]
        public void ThirdteenTo_XIII_Test()
        {
            

            string result = svc.DoTransform(13);

            Assert.AreEqual("X III", result);
        }

        [TestMethod]
        public void ThousandNinehundredFiftySixTo_MCMLVI_Test()
        {
            

            string result = svc.DoTransform(1956);

            Assert.AreEqual("M CM L VI", result);
        }

        [TestMethod]
        public void ThreeHundredNinetySixTo_CCCXCVI_Test()
        {
            

            string result = svc.DoTransform(396);

            Assert.AreEqual("CCC XC VI", result);
        }
    }
}