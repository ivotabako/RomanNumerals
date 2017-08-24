using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumerals.Test
{
    [TestClass]
    public class ReplaceServiceTest
    {
        [TestMethod]
        public void ReplaceService_Test1()
        {
            ReplaceService replaceSvc = new ReplaceService();

            var result = replaceSvc.DoTransform("Lorem ipsum 2 dolor sit amet.");

            Assert.AreEqual("Lorem ipsum II dolor sit amet.", result.Text);
            Assert.AreEqual(1, result.ReplacedNumbersCount);
        }

        [TestMethod]
        public void ReplaceService_Test2()
        {
            ReplaceService replaceSvc = new ReplaceService();

            var result = replaceSvc.DoTransform("Ut enim quis nostrum 1904 qui.");

            Assert.AreEqual("Ut enim quis nostrum M CM IV qui.", result.Text);
            Assert.AreEqual(1, result.ReplacedNumbersCount);

        }
        [TestMethod]
        public void ReplaceService_Test3()
        {
            ReplaceService replaceSvc = new ReplaceService();

            var result = replaceSvc.DoTransform("Consectetur 5 adipiscing elit 9." );

            Assert.AreEqual("Consectetur V adipiscing elit IX.", result.Text);
            Assert.AreEqual(2, result.ReplacedNumbersCount);
        }

        [TestMethod]
        public void ReplaceService_Test4()
        {
            ReplaceService replaceSvc = new ReplaceService();

            var result = replaceSvc.DoTransform(
                @"Lorem ipsum dolor sit amet, consetetur 
                sadipscing elitr, sed diam nonumy eirmod 
                tempor invidunt 1234 ut labore et dolore magna 
                aliquyam erat, sed diam voluptua. At vero 
                eos et accusam et justo duo dolores et ea rebum. 
                Stet clita kasd 954 gubergren, no sea takimata sanctus 
                est Lorem ipsum dolor sit amet. Lorem 177 ipsum dolor sit amet, 
                consetetur sadipscing elitr, sed diam nonumy eirmod tempor 
                invidunt ut labore12 et dolore 15 magna aliquyam erat, sed diam 
                voluptua. At vero eos et accusam 4567 et justo duo dolores et ea 
                rebum. 234Stet clita kasd gubergren, no sea takimata sanctus
                est Lorem ipsum dolor sit amet.");

            Assert.AreEqual(
                @"Lorem ipsum dolor sit amet, consetetur 
                sadipscing elitr, sed diam nonumy eirmod 
                tempor invidunt M CC XXX IV ut labore et dolore magna 
                aliquyam erat, sed diam voluptua. At vero 
                eos et accusam et justo duo dolores et ea rebum. 
                Stet clita kasd CM L IV gubergren, no sea takimata sanctus 
                est Lorem ipsum dolor sit amet. Lorem C LXX VII ipsum dolor sit amet, 
                consetetur sadipscing elitr, sed diam nonumy eirmod tempor 
                invidunt ut labore12 et dolore X V magna aliquyam erat, sed diam 
                voluptua. At vero eos et accusam 4567 et justo duo dolores et ea 
                rebum. 234Stet clita kasd gubergren, no sea takimata sanctus
                est Lorem ipsum dolor sit amet.", result.Text);
            Assert.AreEqual(4, result.ReplacedNumbersCount);
        }
    }
}
