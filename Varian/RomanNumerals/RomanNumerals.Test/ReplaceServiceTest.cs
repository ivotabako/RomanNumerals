using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumerals.Test
{
    [TestClass]
    public class ReplaceServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            ReplaceService replaceSvc = new ReplaceService();
            var result = replaceSvc.DoTransform("Lorem ipsum 2 dolor sit amet.");
            Assert.AreEqual("Lorem ipsum II dolor sit amet.", result.Text);
            Assert.AreEqual(1, result.ReplacedNumbersCount);
        }

        [TestMethod]
        public void TestMethod2()
        {
            ReplaceService replaceSvc = new ReplaceService();
            var result = replaceSvc.DoTransform("Ut enim quis nostrum 1904 qui.");
            Assert.AreEqual("Ut enim quis nostrum M CM IV qui.", result.Text);
            Assert.AreEqual(1, result.ReplacedNumbersCount);

        }
        [TestMethod]
        public void TestMethod3()
        {
            ReplaceService replaceSvc = new ReplaceService();
            var result = replaceSvc.DoTransform("Consectetur 5 adipiscing elit 9." );
            Assert.AreEqual("Consectetur V adipiscing elit IX.", result.Text);
            Assert.AreEqual(2, result.ReplacedNumbersCount);
        }
    }
}
