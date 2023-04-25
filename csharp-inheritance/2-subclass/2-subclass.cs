using System;

/// <summary>Provides some methods to work with Obj</summary>
class Obj
{
    /// <summary>Write a method that print true Only subclass
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubcclassof(baseType);
    }
}
