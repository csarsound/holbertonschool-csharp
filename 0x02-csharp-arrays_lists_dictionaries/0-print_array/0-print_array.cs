using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }
        
        int[] arr = new int[size];
        
        for (int i = 0; i < size; i++)
        {
            arr[i] = i;
        }
        Console.WriteLine("{0}", string.Join(" ", arr));
        return arr;
    }
}
