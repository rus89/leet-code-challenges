using System.Diagnostics;

namespace Problems;

public class SolutionsTesting
{
    private static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        
        

        stopwatch.Stop();
        Console.WriteLine("Elapsed: {0} ms", stopwatch.ElapsedMilliseconds);
    }
}