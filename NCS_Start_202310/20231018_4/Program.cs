using System;

namespace _20231018_4
{
    internal class Program
    {
        static void Swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void SwapRef(ref int x,int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void SwapRef(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        
        
        
        public static void Main(string[] args)
        {
            int x = 1;
            int y = 2;
            Swap(x, y);
            Console.WriteLine($"x = {x}, y = {y}"); 
            
            x = 1;
            y = 2;
            SwapRef(ref x, y);
            Console.WriteLine($"x = {x}, y = {y}"); 
            
            x = 1;
            y = 2;
            SwapRef(ref x, ref y);
            Console.WriteLine($"x = {x}, y = {y}"); 
        }
    }
}