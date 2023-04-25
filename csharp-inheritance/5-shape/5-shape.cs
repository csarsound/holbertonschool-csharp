using System;

/// <summary>Write a class Shape</summary>
class Shape
{

    /// <summary>Throws an NotImplementedException with the message Area() is not implemented</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
