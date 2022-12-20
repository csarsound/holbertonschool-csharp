using System;

class Line
{
    public static void PrintLine(int length)
    {
        if (length > 0)
        {
            Console.WriteLine("{0}", new string('_', length));
        }
        else
        {
            Console.WriteLine();
        }
    }
}
