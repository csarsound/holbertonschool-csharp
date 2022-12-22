using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int val = 0;
        string ks = "";

        if (myList.Count == 0)
			return "None";

        foreach(KeyValuePair<string, int> key in myList)
        {
            if (key.Value >= val)
            {
                val = key.Value;
                ks = key.Key;
            }
        }
        return ks;    
    }
}
