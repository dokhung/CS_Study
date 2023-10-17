using System;

namespace ForEach2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] a = new[] { 0, 1, 2, 3, 4, 5 };
            foreach (var n in a)
            {
                Console.WriteLine(n);
            }
        }
    }
}