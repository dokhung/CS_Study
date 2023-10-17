using System;

namespace Mission3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            {
                for (int i = 0; i < 10; i = i+2)
                {
                    // 2씩 증가해야됨
                    Console.WriteLine(i);
                
                    /*
                     * 이런 방법도 있음
                        Console.WriteLine(i + 2);
                        Console.WriteLine(i * 2);
                     *
                     */
                }
            }

            {
                for (int i = 0; i < 10; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i + "번째 입니다");
                    }
                }
            }
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Console.WriteLine($"{i} x {j} = { i * j}" );
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}