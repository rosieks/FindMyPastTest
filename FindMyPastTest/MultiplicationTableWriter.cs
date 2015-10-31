using System;
using System.IO;
using System.Linq;

namespace FindMyPastTest
{
    public class MultiplicationTableWriter
    {
        public MultiplicationTableWriter()
        {
        }

        public void Write(StringWriter textWriter, MultiplicationTable multiplicationTable)
        {
            int maxNumber = multiplicationTable[multiplicationTable.Header.Length - 1, multiplicationTable.Header.Length - 1];
            int width = maxNumber.ToString().Length;

            var header = new[] { "" }.Concat(multiplicationTable.Header.Select(x => x.ToString())).Select(x => x.PadLeft(width));
            textWriter.WriteLine("| {0} |", string.Join(" | ", header));
            textWriter.WriteLine("| {0} |", string.Join(" | ", Enumerable.Range(0, multiplicationTable.Header.Length + 1).Select(i => "".PadLeft(width, '-'))));
            for (int i = 0; i < multiplicationTable.Header.Length; i++)
            {
                var rowNumber = new[] { multiplicationTable.Header[i] }.Concat(multiplicationTable.Header.Select((x, j) => multiplicationTable[i, j]));
                textWriter.WriteLine("| {0} |", string.Join(" | ", rowNumber.Select(x => x.ToString().PadLeft(width))));
            }
        }
    }
}