using System;

/// <summary>Create a method that calculates the cross product of two 3D vectors and returns the resulting vector</summary>
class VectorMath
{
    /// <summary>Create a method that calculates the cross product of two 3D vectors and returns the resulting vector</summary>
    /// <returns>f either vector is not a 3D vector, return a vector containing -1</returns>
    /// <param name="vector1">: Vector1 to calculate cross product </param>
    /// <param name="vector2">: Vector2 to calculate cross product </param>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1 is double[] && vector1 is double[] &&
            vector1.Length == 3 && vector1.Length == vector2.Length)
        {
            double[] crossProduct = new double[]
            {
                vector1[1]*vector2[2] - vector1[2]*vector2[1],
                vector1[2]*vector2[0] - vector1[0]*vector2[2],
                vector1[0]*vector2[1] - vector1[1]*vector2[0]
            };
            return crossProduct;
        }
        return new double[] {-1};
    }
}
