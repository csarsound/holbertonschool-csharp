using System;

class Program
{
    static void Main(string[] args)
    {        
        for (int number = 0; number <= 9; number++)
        {
            for (int number1 = number + 1; number1 <= 9; number1++)
            {
                Console.Write("{0}{1}", number, number1);

                if (!(number == 8 && number1 == 9))
                {
                    Console.Write(", ");
                }
            }                
        }
        Console.WriteLine();
    }
}
