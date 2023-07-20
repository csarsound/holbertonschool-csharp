using NUnit.Framework;
using InventoryLibrary;
using System.Collections.Generic;

namespace InventoryManagement.Tests
{
    [TestFixture]
    public class JSONStorageTests
    {
        private JSONStorage storage;

        [SetUp]
        public void TestInitialize()
        {
            // Configurar el ambiente de prueba
            storage = new JSONStorage();
            storage.Cargar(); // Cargar datos de prueba desde un archivo JSON de prueba o usar un diccionario de prueba
        }

        [Test]
        public void TestAddAndRetrieveItem()
        {
            // Prueba agregar un nuevo objeto a JSONStorage y luego recuperarlo para verificar si los datos son correctos

            // Creamos un objeto de prueba (puedes usar la clase Item o cualquier otra clase que herede de BaseClass)
            Item item = new Item
            {
                id = "1",
                name = "Item de prueba",
                description = "Este es un artículo de prueba",
                price = 10.99f,
                tags = new List<string> { "prueba", "artículo" }
            };

            // Agregamos el objeto a JSONStorage
            storage.Nuevo(item);

            // Recuperamos el objeto de JSONStorage por su id
            Item retrievedItem = (Item)storage.Todos()["Item.1"];

            // Verificamos si los datos son correctos
            Assert.AreEqual(item.id, retrievedItem.id);
            Assert.AreEqual(item.name, retrievedItem.name);
            Assert.AreEqual(item.description, retrievedItem.description);
            Assert.AreEqual(item.price, retrievedItem.price);
            CollectionAssert.AreEqual(item.tags, retrievedItem.tags);
        }

        [Test]
        public void TestDeleteItem()
        {
            // Prueba eliminar un objeto de JSONStorage y verifica que ya no esté presente en la lista

            // Creamos un objeto de prueba y lo agregamos a JSONStorage
            Item item = new Item
            {
                id = "2",
                name = "Item a eliminar",
                price = 19.99f
            };
            storage.Nuevo(item);

            // Verificamos que el objeto esté presente antes de la eliminación
            Assert.IsTrue(storage.Todos().ContainsKey("Item.2"));

            // Eliminamos el objeto
            storage.Eliminar("Item", "2");

            // Verificamos que el objeto ya no esté presente después de la eliminación
            Assert.IsFalse(storage.Todos().ContainsKey("Item.2"));
        }

        [Test]
        public void TestUpdateItem()
        {
            // Prueba actualizar un objeto en JSONStorage y verifica que los datos se hayan actualizado correctamente

            // Creamos un objeto de prueba y lo agregamos a JSONStorage
            Item item = new Item
            {
                id = "3",
                name = "Item original",
                price = 9.99f
            };
            storage.Nuevo(item);

            // Recuperamos el objeto y verificamos que los datos originales estén presentes
            Item retrievedItem = (Item)storage.Todos()["Item.3"];
            Assert.AreEqual("Item original", retrievedItem.name);
            Assert.AreEqual(9.99f, retrievedItem.price);

            // Actualizamos los datos del objeto
            item.name = "Item actualizado";
            item.price = 14.99f;
            storage.Actualizar("Item", "3", item);

            // Recuperamos el objeto actualizado y verificamos que los datos hayan cambiado
            retrievedItem = (Item)storage.Todos()["Item.3"];
            Assert.AreEqual("Item actualizado", retrievedItem.name);
            Assert.AreEqual(14.99f, retrievedItem.price);
        }
    }
}
