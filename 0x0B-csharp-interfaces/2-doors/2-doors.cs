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
    public Door(string _name="Door")
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
