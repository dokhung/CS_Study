using System;

namespace Calculator
{
    internal class Program
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        class MainApp
        {
            public static void Main(string[] args)
            {
                int result = Calculator.Program.Plus(3, 4);
                Console.WriteLine(result);

                result = Calculator.Program.Minus(5, 2);
                Console.WriteLine(result);
            }
        }
    }
}