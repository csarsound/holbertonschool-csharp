using System;

/// Abstract class named Base
public abstract class Base
{
    /// <summary>Property</summary>
    private string name { get; set; }

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
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>Property durability</summary>
    public int durability {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
    /// <summary>Property isCollected</summary>
    public bool isCollected {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
    /// <summary>Property name</summary>
    public string name {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
    // This meethods do not need to fully implement yet.
    /// <summary>Interact method</summary>
    public void Interact() { throw new NotImplementedException(); }
    /// <summary>Break method</summary>
    public void Break() { throw new NotImplementedException(); }
    /// <summary>Method</summary>
    public void Collect() { throw new NotImplementedException(); }
}
