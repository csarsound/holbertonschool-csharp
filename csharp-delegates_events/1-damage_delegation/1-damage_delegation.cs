using System;


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

    // ***** Damage section *****
    // delegate
    public delegate void  CalculateHealth(float property);

    /// <sumary>Method to print the Player damage </sumary>
    public void TakeDamage(float damage)
    {
        damage = (damage < 0) ? 0 : damage ;
        Console.WriteLine($"{name} takes {damage} damage!");
    }

    /// <sumary>Method to print the Player heals </sumary>
    public void HealDamage(float heal)
    {
        heal = (heal < 0) ? 0 : heal ;
        Console.WriteLine($"{name} heals {heal} HP!");
    }
}
