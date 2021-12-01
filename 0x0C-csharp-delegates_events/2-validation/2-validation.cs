using System;
/// <summary>
/// Player class contains player's informations.
/// </summary>
public class Player
{
    /// Player's name.
    /// Player's maximum health points.
    /// Player's current health points.
    private string name;
    private float maxHp;
    private float hp;

    /// <summary>
    /// Player's class constructor.
    /// </summary>
    /// <param name="name">Player's name</param>
    /// <param name="maxHp">Player's maximum health points.</param>
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

    /// <summary>
    /// CalculateHealth delegate.
    /// </summary>
    /// <param name="amount">Amout of heal or damage to be used.</param>
    public delegate void CalculateHealth(float amount);

    /// <summary>
    /// Prints a message when player takes damage.
    /// </summary>
    /// <param name="damage">Damage amount.</param>
    public void TakeDamage(float damage)
    {
        float newHp;

        newHp = hp;
        
        if (damage >= 0)
        {
            Console.WriteLine($"{name} takes {damage} damage!");
            newHp -= damage;
        }
        else
            Console.WriteLine($"{name} takes 0 damage!");
        ValidateHP(newHp);
    }

    /// <summary>
    /// Prints a message when player heals damage.
    /// </summary>
    /// <param name="heal">Heal amount.</param>
    public void HealDamage(float heal)
    {
        float newHp;

        newHp = hp;

        if (heal >= 0)
        {
            Console.WriteLine($"{name} heals {heal} HP!");
            newHp += heal;
        }
        else
            Console.WriteLine($"{name} heals 0 HP!");
        ValidateHP(newHp);
    }

    /// <summary>
    /// Sets the new value of the Player’s hp
    /// </summary>
    /// <param name="newHp">The new health points amount.</param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            newHp = 0;

        if (newHp > maxHp)
            newHp = maxHp;

        hp = newHp;
    }
}
