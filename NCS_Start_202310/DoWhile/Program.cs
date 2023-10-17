using System;

namespace DoWhile
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 1
            int i = 10; // value 10
            do
            {
                Console.WriteLine("a) i : {0}", i --);
            } while (i > 0);
            // 2
            do
            {
                Console.WriteLine("b) i : {0}", i--);
            } while (i > 0);


        }
    }
}