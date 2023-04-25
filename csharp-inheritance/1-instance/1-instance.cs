using System;
using System.Collections.Generic;

/// <summary>Provides some methods to work with Obj</summary>
class Obj
{
    /// <summary>Write a method that returns True if the object is an instance of, or if the object is an instance of a class that inherited from, Array, otherwise return False</summary>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}
