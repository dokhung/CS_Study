using System;

namespace Fibonacci01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int Fibonacci(int n)
            {
                if (n < 2)
                    return n;
                else
                    return Fibonacci(n - 1) + Fibonacci(n - 2);
            
            
            }
        }

        void PrintProfile(string name, string phone)
        {
            if (name == "")
            {
                Console.WriteLine("이름을 입력해주세요");
                return;
            }
            Console.WriteLine("Name:{0}, Phone:{1}",name,phone);
        }

        
    }
}