using System;
using System.Collection.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int sum = 0;

        foreach (var item in myLList)
            sum = sum + item;

        return (sum);
    }
}
