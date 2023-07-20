using NUnit.Framework;
using InventoryLibrary;

namespace InventoryManagement.Tests
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        public void TestUserProperties()
        {
            // Prueba para verificar las propiedades de la clase User

            // Crear un objeto de prueba User
            User user = new User
            {
                id = "1",
                name = "John Doe"
            };

            // Verificar las propiedades del objeto
            Assert.AreEqual("1", user.id);
            Assert.AreEqual("John Doe", user.name);
        }
    }
}
