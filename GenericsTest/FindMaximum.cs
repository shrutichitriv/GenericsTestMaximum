using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTest
{
    internal class FindMaximum<T> where T : IComparable
    {
        public T[] values;
        public FindMaximum(T[] values)
        {
            this.values = values;
        }
        public T[] Sort(T[] value)
        {
            Array.Sort(values);
            return value;
        }
        public T MaxValue(params T[] values)
        {
            var maxVal = Sort(values);
            return maxVal[maxVal.Length - 1];
        }
        public T GetMax()
        {
            var max = MaxValue(values);
            return max;
        }
        public void ToPrint()
        {
            var maximum = MaxValue(this.values);
            Console.WriteLine($"The Maximum value is {maximum}");


        }

    }
}

