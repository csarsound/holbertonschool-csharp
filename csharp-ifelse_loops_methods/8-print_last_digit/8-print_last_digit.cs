using System;

namespace _8_print_last_digit
{
    class Program
    {
        public static int PrintLastDigit(int number)
        {
            int num = number % 10;
            if (num < 0)
            {
                num = num * -1;
            }
            Console.Write(num);
            return num;
        }
    }
}
