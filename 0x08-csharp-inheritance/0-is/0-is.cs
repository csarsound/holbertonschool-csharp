using System;

///<summary>Class that represents an object</summary>
class Obj
{
    /// <summary>Checks if an obj is an int</summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj.GetType() == typeof(int))
            return (true);
        else
            return (false);
    }
}
