using System;

/// <summary>
/// Declare the generic class
/// </summary>
class Queue<T>
{
    /// <summary>
    /// Returns the Queue’s type
    /// </summary>
    public Type CheckType()
    {
        return typeof(T);
    }
}
