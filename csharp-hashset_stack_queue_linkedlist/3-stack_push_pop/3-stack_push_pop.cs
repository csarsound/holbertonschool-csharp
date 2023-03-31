using System;
using System.Collection.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        // Print the number of items in the aStack
        Console.WriteLine("Number of items: {0}", aStack.Count);

        // Print the item at the top of aStack without removing it
        if (aStack.Count != 0)
            Console.WriteLine("Top item: {0}", aStack.Peek());
        else
            Console.WriteLine("Stack is empty");

        // Print if aStack contains a given item search
        bool contains = aStack.Contains(search);
        Console.WriteLine("Stack contains \"{0}\": {1}", search, contains);

        // If aStack contains the given item search, remove all items up to and
        // including search; otherwise, leave aStack as is
        Stack<string> newStack = new Stack<string>(aStack);

        if (aStack.Contains(search))
        {
            foreach (var item in newStack)
            {
                if (aStack.Pop() == search)
                    break;
            }
        }
        // Add a new given item newItem to aStack
        aStack.Push(newItem);

        // Return aStack
        return(aStack);
    }
}
