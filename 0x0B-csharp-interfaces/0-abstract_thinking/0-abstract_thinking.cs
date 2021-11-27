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
