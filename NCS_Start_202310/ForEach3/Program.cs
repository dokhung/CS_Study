using System;
using System.Collections.Generic;

namespace ForEach3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 0, 1, 2, 3, 4 };
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}