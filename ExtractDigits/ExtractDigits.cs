using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractDigits
{
    public class ExtractDigits
    {
        const long TheNumber = long.MaxValue;

        [Benchmark]
        public long[] ExtractDigitsModulo()
        {
            long number = TheNumber;
            long divisor = 10;
            long remainer = number % divisor;
            List<long> list = new List<long>();
            while (number > divisor)
            {
                list.Add(remainer);
                number /= divisor;
                remainer = number % divisor;
            }
            list.Add(number);
            list.Reverse();
            return list.ToArray();
        }

        [Benchmark]
        public long[] ExtractDigitsString()
        {
            long[] arr = Array.ConvertAll(TheNumber.ToString().ToArray(), x => long.Parse(x.ToString()));
            return arr;
        }
    }
}
