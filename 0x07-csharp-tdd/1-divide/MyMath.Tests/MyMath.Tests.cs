using NUnit.Framework;
using System;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void Divide_MatrixBy_PositiveNumber()
        {
            int[,] matrix = new int[,]  {{1,2},{2,3},{3,4}};
            int num = 2;
            int[,] resultMatrix = new int[,] {{0,1},{1,1},{1,2}};
            Assert.AreEqual(MyMath.Matrix.Divide(matrix, num), resultMatrix);
        }

        [Test]
        public void Divide_MatrixBy_Zero()
        {
            int[,] matrix = new int[,]  {{1,2},{2,3},{3,4}};
            int num = 0;
            Assert.AreEqual(MyMath.Matrix.Divide(matrix, num), null);
        }

        [Test]
        public void Divide_NullMatrixBy_Number()
        {
            int[,] matrix = null;
            int num = 2;
            Assert.AreEqual(MyMath.Matrix.Divide(matrix, num), null);
        }
    }
}
