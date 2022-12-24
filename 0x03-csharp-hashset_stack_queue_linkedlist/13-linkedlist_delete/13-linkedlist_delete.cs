using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int i;

        LinkedListNode<int> tmp = myLList.First;
        if (index >= myLList.Count || index < 0)
        {
            return;
        }
        for (i = 0; i < index; i++)
        {
            tmp = tmp.Next;
        }
        myLList.Remove(tmp);
    }
}
