using System;
namespace MyMath
{
    /// <summary>Class Matrix contains one methode Divide().</summary>
    public class Matrix
    {
        /// <summar>A methode that divide a matrix by a number.</summary>
        /// <param name="matrix">A multidimensional array that contains integers.</param>
        /// <param name="num">The divider.</param>
        /// <return> The matrix after being divided by num.</return>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix != null)
            {
                int x = matrix.GetLength(0);
                int y = matrix.GetLength(1);
                int[,] resultMatrix = new int[x, y];

                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        try
                        {
                            resultMatrix[i,j] = matrix[i,j] / num;
                        }
                        catch (DivideByZeroException)
                        {
                            System.Console.WriteLine("Num cannot be 0");
                            return null;
                        }
                    }
                }
                return resultMatrix;
            }
            return null;
        }
    }
}
