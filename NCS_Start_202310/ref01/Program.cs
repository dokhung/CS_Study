using System;

namespace ref01
{
    internal class Program
    {
        public static void Swap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        public static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            Console.WriteLine($"x:{x},y:{y}");
            Swap(x, y);
            Console.WriteLine($"x:{x}, y:{y}");

        }
    }
}