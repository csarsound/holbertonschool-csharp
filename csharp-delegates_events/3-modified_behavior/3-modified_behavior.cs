using System;

/// <sumary> Delegate </sumary>
public delegate void  CalculateHealth(float property);

/// <sumary> Enum modifier. This is a delegate </sumary>
public enum Modifier
{
    /// <sumary> This is a delegate </sumary>
    Weak,
    /// <sumary> This is a delegate </sumary>
    Base,
    /// <sumary> This is a delegate </sumary>
    Strong
} ;

/// <sumary> Delegate </sumary>
public delegate float CalculateModifier(float baseValue, Modifier modifier) ;

/// <sumary>Player class</sumary>
class Player
{
    // access the Player’s properties directly from the main file.
    private string name;
    private float maxHp;
    private float hp;

    /// <sumary>Constructor </sumary>
    public Player(string name= "Player", float maxHp= 100f)
    {
        this.name = name;
        if (maxHp > 0)
        {
            this.maxHp = maxHp;
        }
        else
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        this.hp = this.maxHp;
    }

    /// <sumary>Method to print the Player health </sumary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    /// <sumary>Method to print the Player damage </sumary>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            damage = 0 ;
        }
        Console.WriteLine($"{name} takes {damage} damage!");
        ValidateHP(hp - damage);
    }

    /// <sumary>Method to print the Player heals </sumary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            heal = 0 ;
        }
        Console.WriteLine($"{name} heals {heal} HP!");
        ValidateHP(hp + heal);
    }

    /// <sumary>Method to validate Player HP </sumary>
    public void ValidateHP(float newHp)
    {
        // If newHp is negative, set hp to 0
        // If newHp is larger than maxHp, set hp to the value of maxHp
        // Otherwise, set hp to the value of newHp
        this.hp = newHp < 0 ? 0f : newHp > this.maxHp ? maxHp : newHp ;
    }

    /// <sumary>Method to apply a modifier </sumary>
    public float ApplyModifier( float baseValue, Modifier modifier )
    {        
        return modifier == Modifier.Weak ? baseValue / 2 : modifier == Modifier.Strong ?  1.5f * baseValue : baseValue;
    }
}
