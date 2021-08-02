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

/// <summary>
///  Class Rectangle that inherits from Shape.
/// </summary>
class Rectangle : Shape
{
    private int width;
    private int height;
    /// <summary>
    /// width setter and getter.
    /// </summary>
    public int Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            width = value;
        }
    }

    /// <summary>
    /// height setter and getter.
    /// </summary>
    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            height = value;
        }
    }

    /// <summary>
    /// returns the area of the rectangle
    /// </summary>
    /// <returns></returns>
    public new int Area()
    {
        return (this.height * this.width);
    }

    /// <summary>
    /// returns the area of the rectangle
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"[Rectangle] {this.width} / {this.height}";
    }
}
