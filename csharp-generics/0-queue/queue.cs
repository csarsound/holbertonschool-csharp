using System;

/// <summary>
/// Class called Queue.
///</summary>
class Queue<T>
{
    /// <summary>
    /// Queue should not inherit from other classes or interfaces.
    /// </summary>
    /// <return> returns the Queue’s type.</return>
    public Type CheckType()
    {
        return typeof(T);
    }
}
