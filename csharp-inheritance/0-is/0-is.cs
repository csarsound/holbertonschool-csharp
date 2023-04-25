using System;

/// <summary>Obj class</summary>
class Obj
{
    /// <summary>Returns True if the object is an int, otherwise return False.</summary>
    public static bool IsOfTypeInt(object obj)
    {
        return obj.GetType() == typeof(int);
    }
}
