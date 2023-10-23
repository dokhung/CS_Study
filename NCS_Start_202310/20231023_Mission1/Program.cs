using System;
using System.Collections;
using System.Collections.Generic;

namespace _20231023_Mission1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * 입력 받은 문자열들을 역순으로 출력하기
             * 예 ) abcde를 입력한다면 edcba로 출력하기...
             */
            Console.Write("입력하면 거꾸로 출력함 : ");
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            foreach (char item in input)
            {
                stack.Push(item);
            }

            for (int i = 0; i < input.Length; i++)
            {
                char poppedChar = stack.Pop();
                Console.Write(poppedChar);
            }



        }
    }
}