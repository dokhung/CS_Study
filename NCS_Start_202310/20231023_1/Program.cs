using System;
using System.Collections.Generic;

namespace _20231023_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * 입력받은 문자열들을 역순으로 출력하기
             */
            Console.WriteLine("역순으로 출력할 문자를 입력해주세요");
            string val = Console.ReadLine();
            Stack<char> charstack = new Stack<char>();
            for (int i = 0; i < val.Length; i++) // string 문자열의 길이만큼
            {
                charstack.Push(val[i]);
            }

            int count = charstack.Count;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(charstack.Pop());
            }
        }
    }
}