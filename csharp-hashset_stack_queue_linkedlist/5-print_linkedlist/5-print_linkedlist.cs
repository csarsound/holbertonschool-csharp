using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> newLinkedList = new LinkedList<int>();
        if (size < 0)
            return (newLinkedList);

        for (int value = 0; value < size; value++)
            newLinkedList.AddLast(value);

        foreach (var node in newLinkedList)
            Console.WriteLine(node);

        return (newLinkedList);
    }
}
