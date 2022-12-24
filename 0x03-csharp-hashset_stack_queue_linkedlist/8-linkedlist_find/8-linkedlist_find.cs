using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int i = 0;
        foreach (int item in myLList)
        {
            if (item != value)
            {
                i++;
            }
            else
            {
                return(i);
            }
        }
        return(-1);
    }
}
