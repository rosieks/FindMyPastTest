using System;
using System.Collections.Generic;

namespace FindMyPastTest
{
    public class PrimeNumberGenerator
    {
        public PrimeNumberGenerator()
        {
        }

        public IEnumerable<int> Generate()
        {
            int i = 1;
            while (true)
            {
                i++;
                if (IsPrime(i))
                {
                    yield return i;
                }
            }
        }

        private bool IsPrime(int n)
        {
            if (n == 2)
            {
                return true;
            }

            if (n == 1 || n % 2 == 0)
            {
                return false;
            }

            int sqrt = (int)Math.Sqrt(n);
            for (int i = 3; i <= sqrt; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}