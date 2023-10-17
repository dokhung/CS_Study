using System;

namespace Mission_7_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("역행 구구단");
            int num = int.Parse(Console.ReadLine());
            for (int i = 9; i >= 1; i--)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }
        }
    }
}