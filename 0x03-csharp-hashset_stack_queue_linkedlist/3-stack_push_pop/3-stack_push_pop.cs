using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aStack.Count);
        if (aStack.Count <= 0)
        {
            Console.WriteLine("Stack is empty");
            Console.WriteLine("Stack contains \"{0}\": False", search);
            aStack.Push(newItem);
            return(aStack);
        }
        else
        {
            Console.WriteLine("Top item: {0}", aStack.Peek());
        }
        bool isIn = false;
        foreach (string item in aStack)
        {
            if (item == search)
            {
                isIn = true;
            }
        }
        if (isIn == false)
        {
            Console.WriteLine("Stack contains \"{0}\": False", search);
            aStack.Push(newItem);
            return(aStack);
        }
        Console.WriteLine("Stack contains \"{0}\": True", search);
        while (aStack.Contains(search))
        {
            aStack.Pop();
        }
        aStack.Push(newItem);
        return(aStack);

    }
}
