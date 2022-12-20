using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length > 0)
        {
            for (int n = 0; n < length; n++)
            {
                Console.WriteLine("{0}\\", new string(' ', n));
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine();
        }
    }
}
