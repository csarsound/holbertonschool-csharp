using System;

class Program
{
    static void Main(string[] args)
    {
        for (int number = 0; number <= 99; number++)
        {
            if (number != 99)
            Console.Write($"{number:00}, ");
            
            else
                Console.Write("{0}\n",number);
        }

    }
}
