using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace _20231023_4
{
    class SolveProb
    {

        private bool IsRight(string s)
        {
            Stack<char> stack = new Stack<char>();
            if (s[0] == ')')
            {
                return false
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(s[i]);
                }
                else
                {
                    if (stack.Tr)
                    {
                        
                    }
                }

                if (s[i] == '(')
                {
                    stack.Push(s[i]);
                }
                else
                {
                    stack.Pop();
                }
            }
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }
}