using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aQueue.Count);
        if (aQueue.Count > 0)
        {
            Console.WriteLine("First item: {0}", aQueue.Peek());
        }
        else
        {
            Console.WriteLine("Queue is empty");
        }
        aQueue.Enqueue(newItem);
        if (aQueue.Contains(search))
        {
            Console.WriteLine("Queue contains \"{0}\": True", search);
            while (aQueue.Contains(search))
            {
                aQueue.Dequeue();
            }
        }
        else
        {
            Console.WriteLine("Queue contains \"{0}\": False", search);
        }
        return(aQueue);

    }
}
