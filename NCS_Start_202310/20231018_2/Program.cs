using System;
using System.Security.Cryptography;

namespace _20231018_2
{
    internal class Program
    {
        static void Swap(int _x, int _y)
        {
            int temp = _x;
            _x = _y;
            _y = temp;
            Console.WriteLine($"Swap 함수 안에서의 x = {_x}, y = {_y}");
        }
        public static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            Swap(x,y); // Console.WriteLine($"Swap 함수 안에서의 x = {_x}, y = {_y}");
            Console.WriteLine($"메인 함수에서의 x = {x}, y = {y}");
        }
    }
    
}