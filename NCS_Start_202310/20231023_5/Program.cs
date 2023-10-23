using System;
using System.Collections;
using System.Collections.Generic;

namespace _20231023_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            Console.WriteLine("천단위 구분기호를 넣어줄 숫자를 입력해주세요");
            string str = Console.ReadLine();
            for (int i = 1; i <= str.Length; i++)
            {
                stack.Push(str[str.Length - i]);
                if (i % 3 == 0)
                {
                    if (i != str.Length)
                    {
                        stack.Push(',');
                    }
                }
            }

            Console.WriteLine("천단위 구분기호를 넣은 결과물 : " + new string(stack.ToArray()));
        }
    }
}