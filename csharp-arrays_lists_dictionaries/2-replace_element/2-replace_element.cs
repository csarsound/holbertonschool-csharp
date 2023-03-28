using System;

namespace _2_replace_element
{
    class Array
    {
        public static int[] ReplaceElement(int[] array, int index, int n)
        {
            int[] newArray = array;

            if (index > array.Length - 1 || index < 0)
            {
                Console.WriteLine("Index out of range");
                return (array);
            }

            for (int i = 0; i < newArray.Length; i++)
            {
                if (index == i)
                {
                    newArray[i] = n;
                }
            }
            return (newArray);
        }
    }
}
