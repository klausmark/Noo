using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace FiboPlaygroud
{
    public class ThreadedFibonacciExample
    {
        private readonly ILogger _logger;

        public ThreadedFibonacciExample(ILogger logger)
        {
            _logger = logger;
        }

        public void Go(string name, int numberOfFibonacciNumbers)
        {
            var fibonacci = new Fibonacci();
            var fibonacciNumbers = fibonacci.CalculateFibonacciNumbers(numberOfFibonacciNumbers);
            var smartArrayPrinter = new ArrayFormatter(fibonacciNumbers, 80);
            _logger.WriteLine($"{name}:{Environment.NewLine}{smartArrayPrinter}");
        }

        public static void RunThreadedFibonacciExample(int numberOfThreads, int numberOfFibonacciNumbers, ILogger logger)
        {
            var sw = new Stopwatch();
            sw.Start();
            var tasks = new Task[numberOfThreads];
            for (var i = 0; i < numberOfThreads; i++)
            {
                var threadNumber = i;
                tasks[i] = Task.Run(() => new ThreadedFibonacciExample(logger).Go($"Thread{threadNumber}", numberOfFibonacciNumbers));
            }
            Task.WaitAll(tasks);
            sw.Stop();
            logger.WriteLine($"Elapsed: {sw.Elapsed}");
        }
    }
}