using System;
/// <summary>
/// Shape class contains one method Area().
/// </summary>
class Shape
{
    /// <summary>
    /// Throws an NotImplementedException with the message Area() is not implemented.
    /// </summary>
    /// <returns></returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
