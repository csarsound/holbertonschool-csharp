using System;
using System.Diagnostics;
using System.IO;

class Program
{
  static void Main(string[] args)
  {
    string[] filenames = Directory.GetFiles("images/", "*.jpg");

    if (filenames.Length <= 10)
    {
      foreach (string file in filenames)
      {
        for (int i = 1; i <=5; i++)
          File.Copy(file, $"{file.Split('.')[0]}_{i}.jpg");
      }
    }

    filenames = Directory.GetFiles("images/", "*.jpg");

    TimeSpan timespan;
    TimeSpan limit = new TimeSpan(0, 0, 0, 40, 0);
    Stopwatch timer = Stopwatch.StartNew();

    ImageProcessor.Inverse(filenames);

    timer.Stop();
    timespan = timer.Elapsed;

    if (timespan < limit)
      Console.WriteLine("OK");
    else
      Console.WriteLine($"Runtime too long: {timespan}");

    foreach (string file in Directory.GetFiles(".", "*.jpg"))
      File.Delete(file);
  }
}
