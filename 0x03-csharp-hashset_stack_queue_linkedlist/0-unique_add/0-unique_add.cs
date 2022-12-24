using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        
        HashSet<int> set = new HashSet<int>(myList);
        int number = 0;
        
        foreach (int i in set)
        {
            number = number + i;
        }
        return (number);
    }
}
