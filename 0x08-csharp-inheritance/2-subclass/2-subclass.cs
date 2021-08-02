using System;

/// <summary>
/// Obj class contains one function IsOnlyASubclass().
/// </summary>
class Obj
{
    /// <summary>
    /// Determine  if the object is an instance of a class that inherits from the specified class.
    /// </summary>
    /// <param name="derivedType">The type of the derived class.</param>
    /// <param name="baseType">The type of the base class.</param>
    /// <returns>
    /// True if the object is an instance of a class that inherits from the specified class,
    /// otherwise return False.
    /// </returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
            return true;
        return false;
    }
}
