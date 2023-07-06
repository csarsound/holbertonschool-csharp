using System;

/// <summary>
/// Class called Queue.
///</summary>
class Queue<T>
{
    public Node head = null;
    public Node tail = null;
    public int count;

    /// <summary>
    /// Queue should not inherit from other classes or interfaces.
    ///</summary>
    /// <return> the Queue’s type.</return>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// Class to describe nodes of the queue
    /// </summary>
    public class Node
    {
        public T value = default(T);
        public Node next = null;

        /// <summary>
        /// Constructor for the node class
        /// </summary>
        /// <param name="variable">Value to add</param>
        public Node(T variable)
        {
            value = variable;
        }
    }

    /// <summary>
    /// the class Queue to create a new Node and add it to the end of the queue.
    /// </summary>
    public void Enqueue(T value)
    {
        Node temp = new Node(value);
        
        if (head == null)
        {
            head = temp;
            tail = temp;
        }
        else
        {
            tail.next = temp;
            tail = temp;
        }
        count++;
    }

    /// <summary>
    /// the class to return the number of nodes in the Queue.
    /// </summary>
    /// <returns> returns the number of nodes</returns>
    public int Count()
    {
        return count;
    }

    /// <summary>
    /// Method to remove the first node in the queue and returns its value.
    /// If the queue is empty, the method should write Queue is empty to the console
    /// </summary>
    /// <returns> return the default value of the parameter’s type</returns>
    public T Dequeue()
    {
        Node temp = head;

        if (temp == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        head = head.next;
        count--;
        return temp.value;
    }

    /// <summary>
    /// Method to return the value of the first node of the queue without removing the node.
    /// </summary>
    /// <returns> return the value of the first node of the queue</returns>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            return head.value;
        }
    }

    /// <summary>
    /// Method to print the queue, starting from the head.
    /// </summary>
    public void Print()
    {
        Node temp = head;
        
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return;
        }
        while (temp != null)
        {
            Console.WriteLine("{0}", temp.value);
            temp = temp.next;
        }
    }

    /// <summary>
    /// Method to concatenate all values in the queue only if the queue
    /// is of type String or Char.
    /// If the queue is not of type String or Char will return null
    /// </summary>
    /// <return> return the string concatenated</return>
    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }

        if (typeof(T).Name is string)
        {
            string tmp = new string("");
            Node temp = head;
            bool temp2 = true;

            while (temp != null)
            {
                if (temp2 != true && typeof(T).Name == "String")
                {
                    tmp += " ";
                }
                tmp += temp.value;
                temp = temp.next;
                temp2 = false;
            }
            return tmp;
        }
        else
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return null;
        }
    }
}
