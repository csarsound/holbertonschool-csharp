using System;

namespace _0_print_array
{
    class Array
    {
        public static int[] CreatePrint(int size)
        {
            int[] newArray;

            if (size < 0)
            {
                Console.WriteLine("Size cannot be negative");
                return (null);
            }

            newArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                newArray[i] = i;
                if (i < size -1)
                {
                    Console.Write(newArray[i] + " ");
                }
                else
                {
                    Console.Write(newArray[i]);
                }
                Console.WriteLine();
                return (newArray);
            }
        }
    }
}
