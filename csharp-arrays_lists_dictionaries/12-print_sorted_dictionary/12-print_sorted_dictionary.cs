using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> newList = new List<string>();
        foreach (KeyValuePair<string, string> pair in myDict)
        {
            newList.Add(pair.Key.ToString() + ": " + pair.Value.ToString());
        }
        newList.Sort();
        foreach (string valueDic in newList)
        {
            System.Console.WriteLine(valueDic);
        }
    }
}
