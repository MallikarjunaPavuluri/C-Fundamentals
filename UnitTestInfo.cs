using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trainingwithcshap;
namespace InfoTest
{
    [TestClass]
    public class InfoTestClass
    {
        [TestMethod]
        public void TestGamilChech()
        {
            Info f = new Info();
           bool b= f.Gmailcheck("abc@gmail.com");
            Assert.AreEqual(true, b);
        }
        [TestMethod]
        public void TestDigits()
        {
            Info f = new Info();
            bool b = f.Digits("8008471623");
            Assert.AreEqual(true, b);

        }
    }
}
