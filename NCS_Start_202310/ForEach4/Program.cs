using System;

namespace ForEach4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string text = "Hello, World!";
            foreach (var character in text)
            {
                Console.WriteLine(character);
            }
        }
    }
}