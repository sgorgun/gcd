using System;

namespace GcdTask
{
    public static class IntegerExtensions
    {
        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue]  by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int FindGcd(int a, int b)
        {
            int z = 0;
            int x = 0;
            int y = 0;
            if (a == 0 && b == 0)
            {
                throw new System.ArgumentException("Two numbers cannot be 0 at the same time.");
            }

            if (a is int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"{nameof(a)} can't be int.MinValue.");
            }

            if (b is <= int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b), $"{nameof(b)} can't be int.MinValue.");
            }

            if (a > b)
            {
                x = a;
                y = b;
            }
            else
            {
                x = b;
                y = a;
            }

            while (y != 0)
            {
                z = x % y;
                x = y;
                y = z;
            }

            if (x > 0)
            {
                return x;
            }
            else
            {
                return -x;
            }
        }
    }
}
