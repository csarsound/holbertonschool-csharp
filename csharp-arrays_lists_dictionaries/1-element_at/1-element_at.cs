

using System;

class Array
{
    public static int elementAt(int[] array, int index)
    {
        int element = 0;

        if (index > array.Length - 1 || index < 0)
        {
            Console.WriteLine("Index out of range");
            return (-1);
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (index == i)
            {
                element = array[i];
                break;
            }
        }

        return (element);
    }
}
