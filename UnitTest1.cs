using NUnit.Framework;
using WpfApp1;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            Class1 cl = new Class1();
            Assert.AreEqual(false,cl.A("-8","-9"));
        }
        [Test]
        public void Test2()
        {
            Class1 cl = new Class1();
            Assert.AreEqual(true, cl.A("8", "9"));
        }

        [Test]
        public void Test3()
        {
            Class1 cl = new Class1();
            Assert.AreEqual(true, cl.B("", ""));
        }
    }
}