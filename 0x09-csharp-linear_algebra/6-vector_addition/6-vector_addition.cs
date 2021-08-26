using System;

/// <summary>VectorMath class contains methode Add().</summary>
class VectorMath
{
    ///<summary> Adds two vectors and returns the resulting vector.</summary>
    ///<param name="vector1"> The first vector.</param>
    ///<param name="vector2"> The second vector.</param>
    ///<return> The vectors' addition.</return>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        int l1, l2;
        
        l1 = vector1.Length;
        l2 = vector2.Length;

        if(l1 < 2 || l2 < 2 || l1 > 3 || l2 > 3 || l1 != l2)
            return new double[] {-1};
        double[] resultingVector = new double[l1];
        for (int i = 0; i < l1; i++)
            resultingVector[i] = vector1[i] + vector2[i];
        
        return resultingVector;
    }
}
