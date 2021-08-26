using System;

/// <summary>VectorMath class contains methode Magnitude().</summary>
class VectorMath
{
    ///<summary> Calculates and returns the length of a given vector.</summary>
    ///<param name="vector"> The vector to calculate it's magnitude.</param>
    ///<return> Vector's magnitude.</return>
    public static double Magnitude(double[] vector)
    {
        double magnitude = 0;
        if (vector.Length > 3 || vector.Length < 2)
            return (-1);
        foreach (var coord in vector)
        {
            magnitude += (coord * coord);
        }
        return Math.Round(Math.Sqrt(magnitude), 2);
    }
}
