using System;

///<summary>Class that represents an object</summary>
class Obj
{
    /// <summary>Checks if an obj is an instance of array</summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {

        
        if (!(derivedType != baseType && derivedType.IsSubclassOf(baseType)))
            return (false);
        
        else
            return (true);
    }
}
