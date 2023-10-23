/*
 *괄호가 바르게 짝지어졌다는 것은 '(' 문자로 열렸으면 반드시 짝지어서 ') 문자로 닫혀야 한다는 뜻입니다. 예를 들어
 * "()()" 또는 "(())()"는 올바른 괄호 입니다.
 * ")()(" 또는 "(()("는 올바르지 않은 괄호 입니다.
 * '(' 또는 ')' 로만 이루어진 문자열 s가 주어졌을 때
 * 문자열 s가 올바른 괄호이면 true를 return 하고, 올바르지 않은 괄호이면 false를 return 하는 solution 함수를 완성해 주세요
 *
 * 제한사항
 * 문자열 s의 길이 : 100,000 이하의 자연수
 * 문자열 s는 '(' 또는 ')' 로만 이루어져 있습니다.
 *
 *
 */

using System;
using System.Collections.Generic;

namespace _20231023_Mission3
{
    class SolveProb
    {
        public bool IsRight(string s)
        {
            Stack<char> charStack = new Stack<char>();
            foreach (char item in s)
            {
                if (item == '(')
                {
                    charStack.Push(item);
                }
                else if(item == ')')
                {
                    if (charStack.Count == 0)
                    {
                        return false;
                    }

                    char top = charStack.Pop(); // 스택의 가장 윗 부분을 지움
                    if (top == ')')
                    {
                        return false;
                    }
                }
            }
            return charStack.Count == 0;
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            SolveProb prob = new SolveProb();
            string s = "()()";
            Console.WriteLine(prob.IsRight(s) ? "알맞은 괄호식입니다." : "잘못된 괄호식 입니다."); // O
            s = "(())()";
            Console.WriteLine(prob.IsRight(s) ? "알맞은 괄호식입니다." : "잘못된 괄호식 입니다."); // O
            s = ")()(";
            Console.WriteLine(prob.IsRight(s) ? "알맞은 괄호식입니다." : "잘못된 괄호식 입니다."); // x
            s = "(()(";
            Console.WriteLine(prob.IsRight(s) ? "알맞은 괄호식입니다." : "잘못된 괄호식 입니다."); // x

            while (true)
            {
                Console.Write("***직접 입력 받음***     ::  ====>   ");
                string d = Console.ReadLine();
                Console.WriteLine(prob.IsRight(d) ? "알맞은 괄호식입니다." : "잘못된 괄호식 입니다.");
            }
            


        }
    }
}