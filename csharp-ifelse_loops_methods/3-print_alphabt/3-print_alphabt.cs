using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            for (byte i = 97; i < 123; i++)
            {
                if (i != 113 && i != 101)
                {
                    Console.Write((char)i);
                }
            }
        }
    }
}
