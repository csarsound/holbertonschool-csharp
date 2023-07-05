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
}
