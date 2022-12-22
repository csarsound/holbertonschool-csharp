using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        var dicto = new Dictionary<string, int>();
        foreach (KeyValuePair<string, int> item in myDict)
        {
            dicto.Add(item.Key, item.Value * 2);
        }
        return dicto;
    }
}
