using System;

class Program
{
	static void Main(string[] args)
	{
		int[,] ar = new int[5, 5];
		ar[2, 2] = 1;
		
		for (int a = 0; a < 5; a++)
		{
			Console.WriteLine("{0} {1} {2} {3} {4}", ar[a, 0], ar[a, 1], ar[a, 2], ar[a, 3], ar[a, 4]);
		}
	}
}
