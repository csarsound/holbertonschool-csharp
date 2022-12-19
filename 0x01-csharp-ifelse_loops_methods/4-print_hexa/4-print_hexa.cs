using System;

class Program
{
    static void Main(string[] args)
    {
        for (int number = 0; number <= 98; number++)
        {
            Console.Write("{0} = {1}\n", number, String.Format("0x{0:x}", number));
        }

    }
}
