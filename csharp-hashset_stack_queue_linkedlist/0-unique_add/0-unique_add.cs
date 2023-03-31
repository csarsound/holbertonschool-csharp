using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static int Sum(List<int> myList)
    {
        int sum = 0;

        foreach (var element in myList.Distinct())
        {
            sum = sum + element;
        }
        return (sum);
    }
}
