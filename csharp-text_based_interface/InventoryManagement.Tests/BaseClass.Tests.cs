using NUnit.Framework;
using System;
namespace InventoryManagement.Tests
{
    [TestFixture()]
    public class BaseClass_Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BaseClass_Instance()
        {
            BaseClass bs = new BaseClass();
            Assert.AreEqual(bs.date_created, bs.date_updated);
        }

        [Test]
        public void BaseClass_Instance_Properties(
            [Values("id", "date_created", "date_updated")] string prop)
        {
            BaseClass bs = new BaseClass();
            Type myType = bs.GetType();

            Assert.IsNotNull(myType.GetProperty(prop));
        }

        [Test]
        public void BaseClass_Instance_Properties_Types()
        {
            BaseClass bs = new BaseClass();
            Type myType = bs.GetType();

            Assert.IsTrue(myType.GetProperty("id").PropertyType == typeof(string));
            Assert.IsTrue(myType.GetProperty("date_created").PropertyType == typeof(DateTime));
            Assert.IsTrue(myType.GetProperty("date_updated").PropertyType == typeof(DateTime));
        }
    }
}
