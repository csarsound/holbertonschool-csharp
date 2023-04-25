using System;
using System.Reflection;

/// <summary>Write a method that prints the names of the available properties and methods of an object</summary>
class Obj
{
    /// <summary>Prints the Properties and Methods names</summary>
    public static void Print(object myObj)
    {
        // getting the Object name
        string className = myObj.GetType().Name;

        // Printing the properties of the object
        Console.WriteLine("{0} Properties:", className);
        foreach (var item in myObj.GetType().GetProperties())
        {
            Console.WriteLine(item.Name);
        }

        // Printing the properties of the object
        Console.WriteLine("{0} Methods:", className);
        foreach (var item in myObj.GetType().GetMethods())
        {
            Console.WriteLine(item.Name);
        }
    }
}
