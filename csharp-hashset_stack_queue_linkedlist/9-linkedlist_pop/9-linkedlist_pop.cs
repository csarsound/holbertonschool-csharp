using System;
using System.Collection.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        LinkedListNode<int> Node;

        if (myLList.Count == 0)
            return (0);

        Node = myLList.First;

        myLList.RemoveFirst();

        return (Node.Value);
    }
}
