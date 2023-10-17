using System;

namespace Goto
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1");
            goto JUMP;
            Console.WriteLine("2");
            Console.WriteLine("3");
            JUMP:
            Console.WriteLine("4");
            
        }
    }
}