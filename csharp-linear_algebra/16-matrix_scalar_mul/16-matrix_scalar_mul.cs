using System;

/// <summary>Create a method that multiplies a matrix and a scalar and returns the resulting matrix</summary>
class MatrixMath
{
    /// <summary>Create a method that multiplies a matrix and a scalar and returns the resulting matrix</summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (matrix.GetLength(0) > 3 || matrix.GetLength(0) < 2)
            return new double[,] { {-1} };

        if (matrix.GetLength(1) > 3 || matrix.GetLength(1) < 2)
            return new double[,] { {-1} };

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                matrix[i, j] *= scalar;
            }
        }

        return matrix;
    }
}
