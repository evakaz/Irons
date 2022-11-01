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
            Assert.AreEqual("premium is ironing with Cotton program", (prem.DoIroning(170)));
        }

        [TestMethod]
        public void TestDoIroningProgram()
        {
            Regular reg = new Regular(randomGenerator);
            Assert.AreEqual("regular is ironing with 150 deegrees.", (reg.DoIroning("Cotton")));
        }

        [TestMethod]
        public void FailTemp()
        {
            Premium prem = new Premium(randomGenerator);
            Assert.AreEqual("Invalid temperature name for ironing.", (prem.DoIroning(300)));
        }

        [TestMethod]
        public void FailProgram()
        {
            Regular reg = new Regular(randomGenerator);
            Assert.AreEqual("We do not have a program for ironing underwear", (reg.DoIroning("underwear")));
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
            Assert.AreEqual("Machine has been used 3 times and need cleaning", reg.DoIroning(156));
        }


        [TestMethod]
        public void CheckButton()
        {

        }


        [TestMethod]
        public void IroningLinenProgram()
        {
            Premium prem = new Premium(randomGenerator);
            Assert.AreEqual("This iron doesn't have linen program.", prem.DoIroning("Linen"));
        }


        [TestMethod]
        public void IroningLinenProgramLinen()
        {
            Linen lin = new Linen(randomGenerator);
            Assert.AreEqual("linen is ironing with 200 deegrees.", lin.DoIroning("Linen"));
        }
    }

    
}
