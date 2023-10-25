using System;

namespace _20231025_7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Func<string> stringFunc1 = () => "Hello World";
            Console.WriteLine(stringFunc1);

            Func<int, int> intFunc1 = (int x) => 10 * x;
            Console.WriteLine(intFunc1(10));
            
            
        }
    }
}