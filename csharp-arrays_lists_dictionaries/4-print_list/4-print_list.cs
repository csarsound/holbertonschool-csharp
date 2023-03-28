using System;
using System.Collections.Generic;

    class List
    {
        public static List<int> CreatePrint(int size)
        {
            if (size < 0)
            {
                Console.WriteLine("Size cannot be negative");
                return null;
            }

            List<int> newList = new List<int>();
            if (size == 0)
            {
                Console.WriteLine("");
            }
            else
            {
                for ( int pos = 0; pos < size; pos++ )
                {
                    newList.Add(pos);
                    Console.Write(newList[pos]);
                    if (pos < size - 1) {Console.Write(" ");}
                }
                Console.WriteLine("");
            }
            return newList;
        }
    }
