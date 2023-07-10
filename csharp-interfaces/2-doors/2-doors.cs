using System;

/// Abstract class named Base
public abstract class Base
{
    /// <summary>Property</summary>
    public string name = null ;

    /// <summary>
    /// ToString method overrided
    /// </summary>
    public override string ToString() => $"{this.name} is a {this.GetType()}";
        
}
/// <summary>IInteractive interface</summary>
public interface IInteractive
{
    /// <summary>Interact method</summary>
    void Interact();
}
/// <summary>IBreakable interface</summary>
public interface IBreakable
{
    /// <summary>Property</summary>
    int durability { get; set; }
    /// <summary>Break method</summary>
    void Break();
}
/// <summary>ICollectable interface</summary>
public interface ICollectable
{
    /// <summary>Property</summary>
    bool isCollected { get; set; }
    /// <summary>Method</summary>
    void Collect();
}

/// <summary>TestObject class that inherits from Base and all three interfaces.</summary>
public class Door : Base, IInteractive
{
    /// <summary>Constructor to set name property</summary>
    public Door(string name = "Door") {
        this.name = name;
    }

    /// <summary>Interaction with door</summary>
    public void Interact() {
        Console.WriteLine( $"You try to open the {this.name}. It's locked." );
    }
    
}
