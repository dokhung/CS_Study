using System;

namespace ForEach
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new[] { 0, 1, 2, 3, 4 };
            foreach (var a in arr)
            {
                Console.WriteLine(a);
            }
        }
    }
}