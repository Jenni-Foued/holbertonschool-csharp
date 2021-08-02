using System;

/// <summary>
/// Obj class contain one function IsInstanceOfArray().
/// </summary>
class Obj
{
    /// <summary>
    /// Determine if the object is an instance of,
    /// or if the object is an instance of a class that inherited from, Array.
    /// </summary>
    /// <param name="obj">The object to be checked.</param>
    /// <returns> returns True if the object is an instance of,
    /// or if the object is an instance of a class that inherited from, Array, otherwise return False.
    /// </returns>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj is Array)
            return true;
        return false;
    }
}
