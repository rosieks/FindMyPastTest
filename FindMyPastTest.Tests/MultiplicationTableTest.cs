using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FindMyPastTest.Tests
{
    public class MultiplicationTableTest
    {
        [Fact]
        public void ShouldGenerateMultiplicationTable()
        {
            var expected = new[]
            {
                new { Row = 0, Column = 0, Result = 4 },
                new { Row = 0, Column = 1, Result = 6 },
                new { Row = 0, Column = 2, Result = 10 },
                new { Row = 1, Column = 0, Result = 6 },
                new { Row = 1, Column = 1, Result = 9 },
                new { Row = 1, Column = 2, Result = 15 },
                new { Row = 2, Column = 0, Result = 10 },
                new { Row = 2, Column = 1, Result = 15 },
                new { Row = 2, Column = 2, Result = 25 },
            };

            var target = new MultiplicationTable(new[] { 2, 3, 5 });
            foreach (var item in expected)
            {
                Assert.Equal(item.Result, target[item.Column, item.Row]);
            }
        }

        [Fact]
        public void ShouldReturnHeaders()
        {
            var target = new MultiplicationTable(new[] { 2, 3, 5 });

            Assert.Equal(2, target.Header[0]);
            Assert.Equal(3, target.Header[1]);
            Assert.Equal(5, target.Header[2]);
        }
    }
}
