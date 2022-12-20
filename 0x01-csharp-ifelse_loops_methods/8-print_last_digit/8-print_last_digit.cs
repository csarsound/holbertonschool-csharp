using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int number1 = number % 10;
        
        if (number1 < 0)
        {
            number1 = number1 * (-1);
        }

        Console.Write(number1);
        return number1;
    }
}
