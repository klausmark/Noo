using System.Collections.Generic;
using System.Linq;

namespace FiboPlaygroud
{
    public class Fibonacci
    {
        private readonly Dictionary<int, ulong> _cachedFibonacciNumbers = new Dictionary<int, ulong> {{0, 0}, {1, 1}};

        public ulong CalculateFibonacciNumber(int number)
        {
            if (_cachedFibonacciNumbers.ContainsKey(number)) return _cachedFibonacciNumbers[number];
            var fibonacciNumber = CalculateFibonacciNumber(number - 1) + CalculateFibonacciNumber(number - 2);
            _cachedFibonacciNumbers.Add(number, fibonacciNumber);
            return fibonacciNumber;
        }

        public ulong[] CalculateFibonacciNumbers(int count)
        {
            return CalculateFibonacci().Take(count).ToArray();
        }

        public IEnumerable<ulong> CalculateFibonacci()
        {
            var i = 0;
            while (true)
                yield return CalculateFibonacciNumber(i++);
        }
    }
}
