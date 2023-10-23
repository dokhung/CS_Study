using System.Collections.Generic;
using System.Linq;

namespace _20231023_3
{
    class SolveProb
    {
        // public int[] RemoveRepeats(int[] arr)
        // {
        //     Stack<int> stack = new Stack<int>();
        //     Queue<int> queue = new Queue<int>();
        //
        //     for (int i = 0; i < arr.Length; i++)
        //     {
        //         if (stack.TryPeek(out int val))
        //         {
        //             if (val != arr[i])
        //             {
        //                 stack.Push(arr[i]);
        //                 queue.Enqueue(arr[i]);
        //             }
        //         }
        //         else
        //         {
        //             stack.Push(arr[i]);
        //             queue.Enqueue(arr[i]);
        //         }
        //     }
        //     
        //     return
        // }

        public int[] RemoveRepeats(int[] arr)
        {
            Stack<int> stack = new Stack<int>();

            for (int i = arr.Length - 1; i >= 0; i++)
            {
                if (stack.TryPeek(out int val))
                {
                    if (arr[i] != val)
                    {
                        stack.Push(arr[i]);
                    }
                }
                else
                {
                    stack.Push(arr[i]);
                }
            }

            return stack.ToArray();
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}