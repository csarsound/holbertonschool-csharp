using System;

namespace InventoryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            JSONStorage storage = new JSONStorage();
            storage.Cargar();

            Console.WriteLine("Inventory Manager");
            Console.WriteLine("-------------------------");

            while (true)
            {
                Console.WriteLine("\nComandos disponibles:");
                Console.WriteLine("<ClassNames> show all ClassNames of objects");
                Console.WriteLine("<All> show all objects");
                Console.WriteLine("<All [ClassName]> show all objects of a ClassName");
                Console.WriteLine("<Create [ClassName]> a new object");
                Console.WriteLine("<Show [ClassName object_id]> an object");
                Console.WriteLine("<Update [ClassName object_id]> an object");
                Console.WriteLine("<Delete [ClassName object_id]> an object");
                Console.WriteLine("<Exit> Quit the application");

                Console.Write("\nIngrese un comando: ");
                string input = Console.ReadLine().Trim();
                string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length == 0)
                {
                    Console.WriteLine("Comando inválido. Intente nuevamente.");
                    continue;
                }

                string command = parts[0].ToLower();
                if (command == "exit")
                {
                    storage.Guardar();
                    break;
                }

                switch (command)
                {
                    case "classnames":
                        storage.ClassNames();
                        break;
                    case "all":
                        if (parts.Length == 1)
                            storage.All();
                        else if (parts.Length == 2)
                            storage.All(parts[1]);
                        else
                            Console.WriteLine("Comando inválido. Intente nuevamente.");
                        break;
                    case "create":
                        if (parts.Length == 2)
                            storage.Create(parts[1]);
                        else
                            Console.WriteLine("Comando inválido. Intente nuevamente.");
                        break;
                    case "show":
                        if (parts.Length == 3)
                            storage.Show(parts[1], parts[2]);
                        else
                            Console.WriteLine("Comando inválido. Intente nuevamente.");
                        break;
                    case "update":
                        if (parts.Length == 3)
                            storage.Update(parts[1], parts[2]);
                        else
                            Console.WriteLine("Comando inválido. Intente nuevamente.");
                        break;
                    case "delete":
                        if (parts.Length == 3)
                            storage.Delete(parts[1], parts[2]);
                        else
                            Console.WriteLine("Comando inválido. Intente nuevamente.");
                        break;
                    default:
                        Console.WriteLine("Comando inválido. Intente nuevamente.");
                        break;
                }
            }
        }
    }
}
