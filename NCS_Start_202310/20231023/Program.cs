using System;
using System.Collections;
using System.Collections.Generic;

namespace _20231023
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * FILO / LIFO
             * 선입후출, 후입선출. 처음 들어온 것이 가장 마지막으로 나가고, 가장 마지막으로 들어온 것이 가장 먼저 나감.
             * 제네릭형은 Stack<T> stack = new Stack<T>(); 권장
             *
             * 스택 : 처음 들어온 것이 가장 마지막으로 나가고, 가장 마지막으로 들어온 것이 가장 먼저 나감.
             * 큐 : 처음 들어온 것이 가장 먼저 나가는 형식
             */

            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < 5; i++)
            {
                stack.Push(i);
            }

            // foreach (var item in stack) // 스택이나 큐 같은거 쓸땐 쓰셈  // 해당 컬렉션을 복사해서 그 복사한 대상안에 있는 요소들을 한번씩 확인하는 기능
            // {
            //     // 내가 확인하고자 하는 이름은 stack
            //     Console.WriteLine(item);
            // }
            //
            // stack.Pop();
            // Console.WriteLine("맨위에 것을 꺼냈음");
            //
            // Console.WriteLine("맨 위의 요소 : " + stack.Peek());
            //
            // stack.Pop();
            // Console.WriteLine("맨 위에 것을 꺼냈음");
            //
            // Console.WriteLine("맨 위의 요소 : " + stack.Peek());
            //
            // for (int i = 0; i < 4; i++)
            // {
            //     Console.WriteLine("Peek() : " + stack.Peek());
            // }
            //
            // stack.Clear();
            //
            // for (int i = 0; i < stack.Count; i++)
            // {
            //     stack.Pop();
            // }

            // int[] arr = { 11, 22, 33, 44 };
            // stack.CopyTo(arr,0);
            // foreach (var item in stack)
            // {
            //     Console.WriteLine(item);
            // }
            //
            // List<int> list = new List<int>() { 111, 222, 333 }; // 리스트 선언
            // stack.CopyTo(list.ToArray(),0);
            // foreach (var VARIABLE in stack)
            // {
            //     Console.WriteLine(VARIABLE);
            // }

            int[] arr = { 11, 22, 33, 44, 55 }; // 배열 선언
            stack.CopyTo(arr,0);

            Console.WriteLine("******배열에다가 복사*****stack 확인******");
            foreach (var VARIABLE in stack)
            {
                Console.WriteLine(VARIABLE);
            }

            Console.WriteLine("**********배열에다가 복사**********arr 확인*******");
            foreach (var VARIABLE in arr)
            {
                Console.WriteLine(VARIABLE);
            }
            
        }
    }
}