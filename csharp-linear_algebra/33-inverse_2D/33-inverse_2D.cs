using System;
using System.Collections;
    
/// <summary>Create a method that calculates the inverse of a 2D matrix and returns the resulting matrix</summary>
class MatrixMath
{
    /// <summary>Create a method that calculates the inverse of a 2D matrix and returns the resulting matrix</summary>
    /// <returns>If the matrix is not a 2D matrix, return [-1] or If the matrix is non-invertible, return [-1]</returns>
    /// <param name="matrix">: Matrix </param>
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2 &&
            (matrix[0, 0]*matrix[1, 1] - matrix[0, 1]*matrix[1, 0]) != 0)
        {
            double[,] inverseMat = new double[,] {
                {matrix[1, 1], (-1)*matrix[0, 1]},
                {(-1)*matrix[1, 0], matrix[0, 0]}
            };
            
            // Determinant of Inverse Matrix => det(A^(-1)) = 1/det(A) 
            double detInverMat = 1/(matrix[0, 0]*matrix[1, 1] - matrix[0, 1]*matrix[1, 0]);

            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    inverseMat[row, col] = Math.Round(detInverMat*inverseMat[row, col], 2);
                }
            }
            return inverseMat;
        }
        return new double[,] {{-1}};
    }
}
