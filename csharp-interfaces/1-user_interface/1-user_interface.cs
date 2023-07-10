using System;

/// Abstract class named Base
public abstract class Base
{
    /// String Member of the class
    public string name = null;

    /// <summary>
    /// ToString method overrided
    /// </summary>
    public override string ToString()
    {
        return name + " is a " + this.GetType();
    }    
}