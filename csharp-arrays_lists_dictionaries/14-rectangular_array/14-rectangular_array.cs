using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int [5, 5];
        for (int row = 0; row < 5; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                if (row == 2 && col == 2) {array[2, 2] = 1;}
                else {array[row, col] = 0;}
                Console.Write(array[row, col]);
                if (col < 4) {Console.Write(" ");}
            }
            Console.WriteLine("");
        }
    }
}
