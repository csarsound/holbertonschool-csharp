using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        // Print the number of items in aQueue
        Console.WriteLine("Number of items: {0}", aQueue.Count);

        // Print the item at the top of aQueue without removing it
        if (aQueue.Count != 0)
            Console.WriteLine("First item: {0}", aQueue.Peek());
        else
            Console.WriteLine("Queue is empty");

        // add a new given item newItem to aQueue
        aQueue.Enqueue(newItem);

        // Print if aQueue contains a given item search
        bool contains = aQueue.Contains(search);

        Console.WriteLine("Queue contains \"{0}\": {1}", search, contains);

        // If aQueue contains the given item search, remove all items up
        // to and including; otherwise, leave aQueue as is
        Queue<string> newQueue = new Queue<string>(aQueue);

        if (aQueue.Contains(search))
        {
            foreach (var item in newQueue)
            {
                if (aQueue.Dequeue() == search)
                    break;
            }
        }

        // return aQueue
        return(aQueue);
    }
}
