using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int countKeys = 0;
        foreach (KeyValuePair<string, string> pair in myDict)
        {
            countKeys++;
        }
        return countKeys;
    }
}
