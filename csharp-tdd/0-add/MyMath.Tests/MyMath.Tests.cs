using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(40, 40)]
        [TestCase(100, -20)]
        [TestCase(20, 60)]
        [TestCase(30, 50)]
        public void SimpleAdditionOperations(int valuea, int valueb)
        {
            var result = MyMath.Operations.Add(valuea, valueb);
            Assert.AreEqual(80, result);
        }
    }
}