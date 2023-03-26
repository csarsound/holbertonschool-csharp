using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int num = 1; num <= 100; num++)
            {
                if (num % 3 == 0) {Console.Write("Fizz");}
                if (num % 5 == 0) {Console.Write("Buzz");}
                if (!(num % 3 == 0 || num % 5 == 0)) {Console.Write(num);}
                if (num < 100) {Console.Write(" ");}
            }
        }
    }
}
