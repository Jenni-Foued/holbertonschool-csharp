using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Player class contains player's informations.
/// </summary>
public class Player
{
    /// Player's name.
    private string name;
    /// Player's maximum health points.
    private float maxHp;
    /// Player's current health points.
    private float hp;

    /// <summary>
    /// Player's class constructor.
    /// </summary>
    /// <param name="name">Player's name.</param>
    /// <param name="maxHp">Player's maximum health.</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        else
            this.maxHp = maxHp;
        hp = this.maxHp;
    }

    /// <summary>
    /// Print's player's current health.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}
