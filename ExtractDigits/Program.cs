using BenchmarkDotNet.Running;
using System;

namespace ExtractDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<ExtractDigits>();
            Console.ReadLine();
        }
    }
}
