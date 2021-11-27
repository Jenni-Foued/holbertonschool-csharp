using System;

/// <summary>
/// Base class.
/// </summary>
abstract class Base
{
    /// <summary>
    /// Name property.
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// Overrides ToString() method.
    /// </summary>
    public override string ToString()
    {
        return name + " is a " + this.GetType();
    }
}

/// <summary>
/// IInteractive interface.
/// </summary>
interface IInteractive
{
    void Interact();
}

/// <summary>
/// IBreakable interface.
/// </summary>
interface IBreakable
{
    int durability { get; set; }

    void Break();
}

/// <summary>
/// ICollectable interface.
/// </summary>
interface ICollectable
{
    bool isCollected { get; set; }

    void Collect();
}

/// <summary>
/// A derived class Door.
/// </summary>
class Door : Base, IInteractive
{
    /// <summary>
    /// Door constructor.
    /// </summary>
    public Door(string _name = "Door")
    {
        this.name = _name;
    }

    /// <summary>
    /// Interaction method implementation.
    /// </summary>
    public void Interact()
    {
        Console.WriteLine("You try to open the " + name + ". It's locked.");
    }
}

/// <summary>
/// Derived class Decoration.
/// </summary>
class Decoration : Base, IInteractive, IBreakable
{

    public bool isQuestItem;
    public int durability { get; set; }

    /// <summary>
    /// Decoration class constructor.
    /// </summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// Break method implementation.
    /// </summary>
    public void Break()
    {
        durability -= 1;

        if (durability > 0)
            Console.WriteLine("You hit the " + name + ". It cracks.");
        else if (durability == 0)
            Console.WriteLine("You smash the " + name + ". What a mess.");
        else
            Console.WriteLine("The " + name + " is already broken.");
    }

    /// <summary>
    /// Interaction method implementation.
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
            Console.WriteLine("The " + name + " has been broken.");
        else if (isQuestItem == true)
            Console.WriteLine("You look at the " + name + ". There's a key inside.");
        else
            Console.WriteLine("You look at the " + name + ". Not much to see here.");
    }
}
