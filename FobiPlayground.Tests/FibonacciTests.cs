﻿using FiboPlaygroud;
using FluentAssertions;
using NUnit.Framework;

namespace FobiPlayground.Tests
{
    [TestFixture]
    public class FibonacciTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(5, 5)]
        [TestCase(10, 55)]
        [TestCase(14, 377)]
        public void CalculateFibonacciNumber(int given, int shouldReturn)
        {
            var fibonacci = GetFibonacci();

            var result = fibonacci.CalculateFibonacciNumber(given);

            result.Should().Be(shouldReturn);
        }

        [Test]
        public void CalculateFibonacciNumbers()
        {
            var fibonacci = GetFibonacci();
            var expectedResult = new[] { 0, 1, 1, 2, 3, 5 };

            var result = fibonacci.CalculateFibonacciNumbers(6);

            result.Should().BeEquivalentTo(expectedResult);
        }

        [Test]
        public void ArrayFormatterTest()
        {
            var objects = new[] {1234, 567, 2345, 1111, 2, 3, 4, 65, 23578765, 46787654, 35677, 55687765};
            var sut = new ArrayFormatter(objects, 27);

            var result = sut.ToString();

            result.Should().Be("");
        }

        private Fibonacci GetFibonacci()
        {
            return new Fibonacci();
        }



    }
}
