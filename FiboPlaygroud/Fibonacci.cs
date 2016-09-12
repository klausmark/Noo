using System.Collections.Generic;
using System.Linq;

namespace FiboPlaygroud
{
    public class Fibonacci
    {
        public int CalculateFibonacciNumber(int number)
        {
            if (number == 0) return 0;
            if (number == 1) return 1;
            return CalculateFibonacciNumber(number - 1) + CalculateFibonacciNumber(number - 2);
        }

        public int[] CalculateFibonacciNumbers(int count)
        {
            return CalculateFibonacci().Take(count).ToArray();
        }

        public IEnumerable<int> CalculateFibonacci()
        {
            var i = 0;
            while (true)
                yield return CalculateFibonacciNumber(i++);
        }
    }
}
