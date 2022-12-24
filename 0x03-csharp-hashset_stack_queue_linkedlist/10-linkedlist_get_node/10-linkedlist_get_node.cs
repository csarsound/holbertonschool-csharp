using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (n > myLList.Count - 1 || n < 0)
        {
            return(0);
        }
        int con = 0;
        foreach (int i in myLList)
        {
            if(con == n)
            {
                return(i);
            }
            else
            {
                con++;
            }
        }
        return (0);

    }
}
