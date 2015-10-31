using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FindMyPastTest.Tests
{
    public class PrimeNumberGeneratorTest
    {
        [Fact]
        public void ShouldGenerateFirst10PrimeNumbers()
        {
            var expected = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
            var target = new PrimeNumberGenerator();

            var actual = target.Generate().Take(10).ToArray();

            Assert.Equal(expected.Length, actual.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }
    }
}
