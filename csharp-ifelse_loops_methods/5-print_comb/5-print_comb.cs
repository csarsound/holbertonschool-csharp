using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 0; i <=99; i++)
            {
                if (i == 99)
                {
                    Console.Write("{0:00}\n", i);
                }
                else
                {
                    Console.Write("{0:00}, ", i);
                }
            }
        }
    }
}
