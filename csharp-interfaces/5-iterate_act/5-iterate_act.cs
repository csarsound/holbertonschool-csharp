using System;
using System.Collections.Generic;


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

/// <summary>Door class that inherits from Base, IInteractive.</summary>
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

/// <summary>Decoration class that inherits from Base, IInteractive, IBreakable interfaces.</summary>
class Decoration : Base, IInteractive, IBreakable
{
    ///<summary>durability Property</summary>
    public int durability { get; set; }
    ///<summary>isQuestItem Property</summary>
    public bool isQuestItem;

    /// <summary>Constructor </summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false) {
        this.name = name;
        this.durability = durability > 0 ? durability : throw new Exception("Durability must be greater than 0") ;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>Interact() method</summary>
    public void Interact() {
        if(durability <= 0) {
            Console.WriteLine($"The {this.name} has been broken.");
        }
        else if (isQuestItem) {
            Console.WriteLine($"You look at the {this.name}. There's a key inside.");
        }
        else { 
            Console.WriteLine($"You look at the {this.name}. Not much to see here.") ;
        }
    }

    /// <summary>Break() method</summary>
    public void Break() {
        // decrement durability
        durability--;
        if(durability > 0) {
            Console.WriteLine($"You hit the {this.name}. It cracks.");
        }
        if (durability == 0) {
            Console.WriteLine($"You smash the {this.name}. What a mess.");
        } else if (durability < 0) {
            Console.WriteLine($"The {this.name} is already broken.");
        }
    }

}

/// <summary>Key class that inherits from Base, ICollectable.</summary>
public class Key : Base, ICollectable
{
    ///<summary>isCollected Property </summary>
    public bool isCollected { get; set; }
    
    /// <summary>Constructor</summary>
    public Key(string name = "Key", bool isCollected = false ) {
        this.name = name ;
        this.isCollected = isCollected ;
    }

    /// <summary>Collect method</summary>
    public void Collect() {
        if (!isCollected){
            isCollected = true;
            Console.WriteLine( $"You pick up the {this.name}." );
        } else {
            Console.WriteLine( $"You have already picked up the {this.name}." );
        }
    }
}

/// <summary>RoomObjects class.</summary>
public class RoomObjects
{
    /// <summary>This method takes a list of all objects, iterate through it, and execute methods</summary>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {    
        foreach (var item in roomObjects)
        {
            if (type.ToString() == "IInteractive" && item is IInteractive)
            {
                // Create a Object temporal to execute methods
                IInteractive obj = item as IInteractive;
                // check if the conversion is successful.
                if (obj != null) { obj.Interact(); }
            }

            if (type.ToString() == "IBreakable" && item is IBreakable)
            {
                // Create a Object temporal to execute methods
                IBreakable obj = item as IBreakable;
                // check if the conversion is successful.
                if (obj != null) { obj.Break(); }
            }

            if (type.ToString() == "ICollectable" && item is ICollectable)
            {
                // Create a Object temporal to execute methods
                ICollectable obj = item as ICollectable;
                // check if the conversion is successful
                if (obj != null) { obj.Collect(); }
            }
        }
    }
}
