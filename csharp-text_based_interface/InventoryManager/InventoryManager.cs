using System;
using System.Text;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;


public class Program
{
    private delegate int inputMethod(string[] input);
    private static Dictionary<string, inputMethod> methods;
    private static Dictionary<string, string> classes;
    private static readonly JSONStorage<BaseClass> jsonStorage = new JSONStorage<BaseClass>();

    static void Main(string[] args)
    {
        // Command to execute
        string cmdExe = null;
        // Commands array to execute
        string[] cmdSExe = null;
        jsonStorage.Load();
        Initialize();
        ShowInitialPrompt();

        while (true)
        {
            ShowPromt();
            // Catch the commands typed
            cmdExe = Console.ReadLine();
            cmdSExe = ParseCommand(cmdExe);

            // Check 
            if(cmdSExe.Lenght <= 0) { continue; }

            string cmd = cmdExe[0].ToLower();
            if(cmd == "exit") { break; }

            if(methods.ContainsKey(cmd))
            {
                if( methods[cmd](cmdSExe) == 0 ) { ShowInitialPrompt(); }
            }
            else
            {
                Console.WriteLine($"{cmdSExe[0]} command to execute not found");
            }
        }
        Console.WriteLine("\nBYE. See you Later\n");
    }

    /// <sumary> Method to print Prompt </sumary>
    private static void Showprompt()
    {
        string prompt = "CONSOLE >> ";
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"{prompt}");
        Console.ReserColor();
    }

    /// <sumary> Method to print the initial prompt </sumary>
    private static void ShowInitialprompt()
    {
        StringBuilder message = new StringBuilder();
        message.Append("\n********************************************\n");
        message.Append("\t\tInventory Manager");
        message.Append("\n********************************************\n");
        message.Append("<ClassNames> Show all ClassNames of objects\n");
        message.Append("<All> Show all objects\n");
        message.Append("<All [ClassName]> Show all objects of a ClassName\n");
        message.Append("<Create [ClassName]> Create a new object\n");
        message.Append("<Show [ClassName object_id]> Show an object\n");
        message.Append("<Update [ClassName object_id]> Update an object\n");
        message.Append("<Delete [ClassName object_id]> Delete an object\n");
        message.Append("<Exit> exit");
        // Print the message
        Console.WriteLine(message);
    }

    /// <sumary> Method to parse the input commands </sumary>
    private static string[] ParseCommand(string comExe)
    {
        return comExe.Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    }

    /// <sumary>  </sumary>
    private static void Initialize()
    {
        methods = new Dictionary<string, method>()
        {
            {"classnames", ClassNames},
            {"all", All},
            {"create", Create},
            {"show", Show},
            {"update", Update},
            {"delete", Delete}
        };

        classes = new Dictionary<string, string>()
        {
            {"baseclass", "BaseClass"},
            {"item", "Item"},
            {"user", "User"},
            {"inventory", "Inventory"}
        };
    }
}
