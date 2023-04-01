using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> node = myLList.First;

        while (node != null)
        {
            if (node.Value < n )
                node = node.Next;

            else
                return(myLList.AddBefore(node, n));
        }

        return (myLList.AddLast(n));
    }
}
