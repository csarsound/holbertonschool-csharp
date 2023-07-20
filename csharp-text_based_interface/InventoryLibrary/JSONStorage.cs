using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace InventoryLibrary
{
    public class JSONStorage
    {
        private readonly string rutaArchivo;

        public Dictionary<string, BaseClass> objetos { get; private set; }

        public JSONStorage()
        {
            rutaArchivo = Path.Combine("storage", "inventory_manager.json");
            objetos = new Dictionary<string, BaseClass>();
        }

        public Dictionary<string, BaseClass> Todos()
        {
            return objetos;
        }

        public void Nuevo(BaseClass obj)
        {
            string key = $"{obj.GetType().Name}.{obj.id}";
            objetos[key] = obj;
        }

        public void Guardar()
        {
            string jsonString = JsonSerializer.Serialize(objetos, new JsonSerializerOptions { WriteIndented = true });
            Directory.CreateDirectory("storage");
            File.WriteAllText(rutaArchivo, jsonString);
        }

        public void Cargar()
        {
            if (File.Exists(rutaArchivo))
            {
                string jsonString = File.ReadAllText(rutaArchivo);
                objetos = JsonSerializer.Deserialize<Dictionary<string, BaseClass>>(jsonString);
            }
            else
            {
                objetos = new Dictionary<string, BaseClass>();
            }
        }
    }
}
