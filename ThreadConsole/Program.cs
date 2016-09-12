using System;
using System.Diagnostics;
using FiboPlaygroud;

namespace ThreadConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacci = new Fibonacci();
            var sw = new Stopwatch();
            sw.Start();
            Console.WriteLine(fibonacci.CalculateFibonacciNumber(100));
            sw.Stop();
            Console.WriteLine($"Elapsed: {sw.Elapsed}");
            Console.ReadLine();
        }
    }
}
