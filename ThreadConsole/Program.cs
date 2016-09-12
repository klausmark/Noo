using System;
using FiboPlaygroud;

namespace ThreadConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadedFibonacciExample.RunThreadedFibonacciExample(2, 30, new ConsoleLogger());
            Console.ReadLine();
        }
    }
}
