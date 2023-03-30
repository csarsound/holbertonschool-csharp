using System;

class Program
{
    static void Main(string[] args)
    {
        int[] sizeArray = new int[] {4, 7, 2}; // Our single array columns
        
        // Initialized jagged Array size of each array in
        int[][] _jaggedArray = new int[sizeArray.Length][];
        for (int i = 0; i < sizeArray.Length; i++)
        {
            _jaggedArray[i]= new int[sizeArray[i]];
        }
        // Initialize jagged Array elements and print
        for (int row = 0; row < sizeArray.Length; row++)
        {
            for (int col = 0; col < sizeArray[row]; col++)
            {
                _jaggedArray[row][col] = col;
                if (col != 0) {Console.Write(" ");}
                Console.Write(_jaggedArray[row][col]);
            }
            Console.WriteLine("");
        }
    }
}
