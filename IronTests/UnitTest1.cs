using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iron;

namespace IronTests
{
    [TestClass]
    public class UnitTest1
    {
        IIronRandomGenerator randomGenerator = new IronRandomGeneratorForTest();

        [TestMethod]
        public void TestDoIroningTemp()
        {
            Premium prem = new Premium(randomGenerator);
            Assert.AreEqual("premium is ironing with Cotton program", (prem.DolroningTemp(170)));
        }

        [TestMethod]
        public void TestDoIroningProgram()
        {
            Regular reg = new Regular(randomGenerator);
            Assert.AreEqual("regular is ironing with 150 deegrees", (reg.DolroningProg("Cotton")));
        }

        [TestMethod]
        public void FailTemp()
        {
            Premium prem = new Premium(randomGenerator);
            Assert.AreEqual("Invalid temperature name for ironing.", (prem.DolroningTemp(300)));
        }

        [TestMethod]
        public void FailProgram()
        {
            Regular reg = new Regular(randomGenerator);
            Assert.AreEqual("We do not have a program for ironing underwear", (reg.DolroningProg("underwear")));
        }

        [TestMethod]
        public void TestAutodescale()
        {
            Regular reg = new Regular(randomGenerator);
            Assert.AreEqual("Machine has been used 3 times and need cleaning", reg.Autodescale());
        }

        [TestMethod]
        public void TestAutoDescalePremium()
        {
            Premium prem = new Premium(randomGenerator);
            Assert.AreEqual("Machine is cleaned", prem.Autodescale());
        }

        [TestMethod]
        public void TestDescale()
        {
            Regular reg = new Regular(randomGenerator);
            reg.timesUsed = 4;
            Assert.AreEqual("Machine has been used 3 times and need cleaning", reg.DolroningTemp(156));
        }


        [TestMethod]
        public void CheckButton()
        {

        }
    }

    
}
