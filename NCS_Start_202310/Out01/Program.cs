using System;

namespace out01
{
    internal class Program
    {
        
        public static void test(int a, out int b, ref int c)
        {
            Console.WriteLine(a);
            // Console.WriteLine(b);
            Console.WriteLine(c);
            b = 42; // out 매개변수에 값을 할당
            c = 99; // ref 매개변수에 값을 할당
        }
        
        public static void Main(string[] args)
        {
            int a = 10;
            int b;
            int c = 20;
        
            test(a, out b, ref c);
        
            Console.WriteLine("After method call:");
            Console.WriteLine(a); // a는 그대로 10
            Console.WriteLine(b); // b는 메서드 내에서 값이 할당될 것 (42)
            Console.WriteLine(c); // c는 메서드 내에서 값이 할당될 것 (99)
        }
    }
}