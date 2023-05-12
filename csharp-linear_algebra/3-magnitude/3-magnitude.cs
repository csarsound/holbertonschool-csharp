using System;

/// <summary>Functions to work with vectors</summary>
class VectorMath
{
    /// <summary>Lenght of a vector</summary>
    public static double Magnitude(double[] vector)
    {
        double result = new double();

        if (vector.Length > 3 || vector.Length < 2)
            return -1;

        if (vector.Length == 2)
        {
            result = Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2);

            result = Math.Sqrt(result);
        }

        if (vector.Length == 3)
        {
            result = Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2);

            result = Math.Sqrt(result);
        }

        return Math.Round(result, 2);
    }
}