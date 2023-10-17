using System;

namespace Mission4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            {
                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");   
                    }
                    Console.WriteLine();
                }
            }
            {
                Console.WriteLine("-------------------");
                for (int i = 1; i <= 4; i++)
                {
                    string star = ""; // 각 줄마다 별표 문자열 초기화
                    for (int j = 1; j <= i; j++)
                    {
                        star += "*";
                    }
                    Console.WriteLine(star);
                }

            }
        }
    }
}