using System;

class Program
{
    static void Main(string[] args)
    {
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[4] {0, 1, 2, 3};
        jaggedArray[1] = new int[7] {0, 1, 2, 3, 4, 5, 6};
        jaggedArray[2] = new int[2] {0, 1};

        for (int a = 0; a < jaggedArray.Length; a++)
		{
			for (int b = 0; b < jaggedArray[a].Length; b++)
			{
				Console.Write("{0}{1}", jaggedArray[a][b], b == (jaggedArray[a].Length - 1) ? "" : " ");
                
			}
			Console.WriteLine();
		}
	}
}
