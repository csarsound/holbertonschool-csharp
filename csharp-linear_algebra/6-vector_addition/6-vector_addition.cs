using System;

/// <summary>Create a method that adds two vectors and returns the resulting vector</summary>
class VectorMath
{
    /// <summary>Create a method that adds two vectors and returns the resulting vector</summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length > 3 || vector1.Length < 2 || vector1.Length != vector2.Length)
            return new double[1]{-1};

        if (vector2.Length > 3 || vector2.Length < 2 || vector1.Length != vector2.Length)
            return new double[1]{-1};

        double[] result = new double[vector1.Length];

        for (int i = 0; i < vector1.Length; i++)
        {
            result[i] = vector1[i] + vector2[i];
        }

        return result;
    }
}
