using System;

/// <summary>
/// Obj class contains one function IsOfTypeInt().
/// </summary>
class Obj
{
    /// <summary>
    /// Determine if the object is an int.
    /// </summary>
    /// <param name="obj">object to check</param>
    /// <returns>True if the object is an int, otherwise return False.</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return Object.ReferenceEquals(obj.GetType(), typeof(int));
    }
}
