using System;

namespace FindMyPastTest
{
    public class MultiplicationTable
    {
        private int[] v;

        public MultiplicationTable(int[] v)
        {
            this.v = v;
        }

        public int this[int column, int row]
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int[] Header
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}