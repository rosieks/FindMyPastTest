using System;

namespace FindMyPastTest
{
    public class MultiplicationTable
    {
        public MultiplicationTable(int[] numbers)
        {
            this.Header = numbers;
        }

        public int this[int column, int row]
        {
            get
            {
                return this.Header[column] * this.Header[row];
            }
        }

        public int[] Header
        {
            get;
            private set;
        }
    }
}