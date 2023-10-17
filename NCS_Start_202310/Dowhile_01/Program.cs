using System;

namespace dowhile_01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = 10; // a에 10값 쳐넣음
            do
            {
                Console.WriteLine(a); // 출력 a값
                a -= 2; // 2씩 쳐뻄 
            } while (a > 0); // 0이 될때까지
        }
    }
}