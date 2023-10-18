using System;

namespace _20231018_6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            char a = '1';
            int.TryParse(a.ToString(), out int b);
            Console.WriteLine(b);

            a = '9';
            int c = a - '0';
            Console.WriteLine(c);
        }
    }
}