using System;
using System.Collections;
    
/// <summary>Create a method that rotates a square 2D matrix by a given angle in radians and returns the resulting matrix</summary>
class MatrixMath
{
    /// <summary>Create a method that rotates a square 2D matrix by a given angle in radians and returns the resulting matrix</summary>
    /// <returns>If the matrix is of an invalid size, return a matrix containing -1</returns>
    /// <param name="matrix">: Matrix to rotate. </param>
    /// <param name="angle">: Angle to rotate the matrix. </param>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double cos = Math.Cos(angle);
        double sin = Math.Sin(angle);
        double[,] rotateMatrix = new double[,] {
            {cos, sin},
            {-sin, cos}
        };

        if (matrix is double[,] && matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            int rowM1 = matrix.GetLength(0);
            int colM1 = matrix.GetLength(1);
            int colM2 = rotateMatrix.GetLength(1);
            int rowM2 = rotateMatrix.GetLength(0);

            double[,] mulMatrix = new double[rowM1, colM2];

            for (int col = 0; col < colM1; col++)
            {
                for (int row = 0; row < rowM1; row++)
                {
                    for (int ixj = 0; ixj < colM2; ixj++)
                    {
                        mulMatrix[row, ixj] = Math.Round(mulMatrix[row, ixj] + matrix[row, col] * rotateMatrix[col, ixj], 2);
                    }
                }
            }
            return mulMatrix;
        }
        else  { return new double[,]{{-1}}; }
    }
}
