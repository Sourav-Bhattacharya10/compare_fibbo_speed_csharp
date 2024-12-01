using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        long limit = 1_000_000_000; // 1 billion
        Console.WriteLine("C# Performance Test: Summing Numbers");

        Stopwatch stopwatch = Stopwatch.StartNew();
        long sum = CalculateSum(limit);
        stopwatch.Stop();

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Elapsed Time: {stopwatch.ElapsedMilliseconds} ms");
    }

    static long CalculateSum(long limit)
    {
        long sum = 0;
        for (long i = 1; i <= limit; i++)
        {
            sum += i;
        }
        return sum;
    }
}
