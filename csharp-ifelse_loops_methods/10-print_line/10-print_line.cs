using System;

namespace _10_print_line
{
    class Program
    {
        public static void PrintLine(int lenght)
        {
           if (lenght > 0)
           {
            Console.Write(new String('_', lenght));
           }
           Console.WriteLine();
        }
    }
}
