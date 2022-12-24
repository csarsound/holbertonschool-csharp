using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> uniq2 = new HashSet<int>(list2);
        HashSet<int> interator = new HashSet<int>(list1);
        interator.IntersectWith(uniq2);
        List<int> tot = new List<int>();
        
        foreach (var a in interator)
        {
            tot.Add(a);
        }
        return(tot);

    }
}
