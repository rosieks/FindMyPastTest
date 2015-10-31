using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FindMyPastTest.Tests
{
    public class MultiplicationTableWriterTest
    {
        [Fact]
        public void ShouldWriteMultiplicationTableToConsole()
        {
            var expected =
            "|    |  2 |  3 |  5 |\r\n" +
            "| -- | -- | -- | -- |\r\n" +
            "|  2 |  4 |  6 | 10 |\r\n" +
            "|  3 |  6 |  9 | 15 |\r\n" +
            "|  5 | 10 | 15 | 25 |\r\n";

            var textWriter = new StringWriter();
            var target = new MultiplicationTableWriter();
            target.Write(textWriter, new MultiplicationTable(new[] { 2, 3, 5 }));

            Assert.Equal(expected, textWriter.ToString());
        }
    }
}
