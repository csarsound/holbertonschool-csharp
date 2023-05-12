using System;
using System.Collections;
    
/// <summary>Create a method that multiplies two matrices and returns the resulting matrix</summary>
class MatrixMath
{
    /// <summary>Create a method that multiplies two matrices and returns the resulting matrix</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1 is double[,] && matrix2 is double[,] &&
            matrix2.GetLength(0) == matrix1.GetLength(1))
        {
            int rowM1 = matrix1.GetLength(0);
            int colM1 = matrix1.GetLength(1);
            int colM2 = matrix2.GetLength(1);
            int rowM2 = matrix2.GetLength(0);

            double[,] mulMatrix = new double[rowM1, colM2];

            for (int col = 0; col < colM1; col++)
            {
                for (int row = 0; row < rowM1; row++)
                {
                    for (int ixj = 0; ixj < colM2; ixj++)
                    {
                        mulMatrix[row, ixj] += matrix1[row, col] * matrix2[col, ixj] ;
                    }
                }
            }
            return mulMatrix;
        }
        else  { return new double[,]{{-1}}; }
    }
}
