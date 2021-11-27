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
/// A derived class used for test.
/// </summary>
class TestObject : Base, ICollectable, IBreakable, IInteractive
{
    public int durability { get; set; }
    public bool isCollected { get; set; }

    public void Break()
    {
        // To be implemented.
    }

    public void Collect()
    {
        // To be implemented.
    }

    public void Interact()
    {
        // To be implemented.
    }
}
