using System;
using System.Collections;
    
/// <summary>Create a method to transpose a matrix and return the resulting matrix</summary>
class MatrixMath
{
    /// <summary>Create a method to transpose a matrix and return the resulting matrix</summary>
    /// <returns>If the matrix is empty, return an empty matrix</returns>
    /// <param name="matrix">: Matrix to transpose. </param>
    public static double[,] Transpose(double[,] matrix)
    {
        if (matrix.Length == 0)
            return new double[,] {};

        double[,] transposeMatrix = new double[matrix.GetLength(1), matrix.GetLength(0)];
        
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                transposeMatrix[col, row] = Math.Round(matrix[row, col], 2);
            }
        }
        return transposeMatrix;
    }
}
