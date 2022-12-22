using System;
using System.Linq;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var sorted = myDict.Keys.ToList();
        
        sorted.Sort();
        foreach (var key in sorted)
        {
            Console.WriteLine("{0}: {1}", key, myDict[key]);
        }
    }
}
