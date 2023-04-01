using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int index = 0;

        foreach (var item in myLList)
        {
            if (index == n)
                return (item);

            index++;
        }

        return (0);
    }
}
