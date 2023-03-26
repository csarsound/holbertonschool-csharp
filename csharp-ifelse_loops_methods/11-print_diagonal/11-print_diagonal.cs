using System;

namespace _11_print_diagonal
{
    class Line
    {
        public static void PrintDiagonal(int length)
        {
            int diagonal, diagonal2;

            if (length <= 0)
            {
                Console.WriteLine("\n");
            }
            for (diagonal = 0; diagonal < length; diagonal++)
            {
                for (diagonal2 = 0; diagonal2 < diagonal; diagonal2++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("\\");
            }
        }
    }
}
