using System;

namespace _20231018_5
{
    internal class Program
    {
        
        // static void AA(int a)
        // {
        //     
        // }
        //
        // public void AA(ref int a)
        // {
        //     
        // }
        //
        // public void AA(ref int a, ref int b)
        // {
        //     
        // }
        //
        // public void AA(out int b)
        // {
        //     b = 10;
        // }

        public static bool Compare(int a, int b, out int result)
        {
            /*
             * a가 b보다 크거나 같을 경우 true반환하고, result 값에다가 a-b 한 것을 넣기..
             * a가 b보다 작을 경우, false를 반환하고, result는 -1을 세팅하기.
             */
            if (a >= b)
            {
                result = a - b;
                return true;
            }
            else
            {
                result = -1;
                return false;
            }
        }
        
        
        public static void Main(string[] args)
        {
            // string a = "1234";
            // int.TryParse(a, out int b);
            // Console.WriteLine(b);
            // int c = 1;
            // AA(1);
            int a = 10;
            int b = 20;
            int result = 0;
            Compare(a, b, out result);
            Console.WriteLine($"매개변수1의 값 : {a}, 매개변수2의 값 : {b} 을 넣어서 " + $"결과값 = {result}를 획득 하였습니다.");
        }

        
    }
}