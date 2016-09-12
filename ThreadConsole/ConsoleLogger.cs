using System;
using FiboPlaygroud;

namespace ThreadConsole
{
    public class ConsoleLogger : ILogger
    {
        public void WriteLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}