using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int i, y;

        for (i = 0; i < myMatrix.GetLength(0); i++)
        {
            for (y = 0; y < myMatrix.GetLength(1); y++)
            {
                myMatrix[i, y] *= myMatrix[i, y];
            }
        }
        return myMatrix;
    }
}
