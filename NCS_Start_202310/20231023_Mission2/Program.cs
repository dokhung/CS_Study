/*
 * 배열  arr가 주어집니다. 배열 arr의 각 원소는 숫자 0부터 9까지로 이루어져 있습니다.
 * 이때 배열  arr에서 연속적으로 나타나는 숫자는 하나만 남기고 전부 제거하려고 합니다.
 * 단, 제거된 후 남은 수들을 반환할 떄는 배열 arr의 원소들의 순서를 유지해야 합니다. 예를 들면
 * arr = 1 1 3 3 0 1 1 이면 1 3 0 1 을 리턴 합니다.
 * arr = 4 4 4 3 3 이면 4 3 을 리턴 합니다.
 * 배열 arr 에서 연속적으로 나타나는 숫자는 제거하고 남은 수들을 리턴 하는 solution 함수를 완성해 주세요
 */

using System;
using System.Collections.Generic;

namespace _20231023_Mission2
{
    public class SolveProb
    {
        private Queue<int[]> queue = new Queue<int[]>();
        private Stack<int[]> stack = new Stack<int[]>();
        public int[] RemoveRepeats(int[] arr)
        {
            return arr;
        }


    }
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            int[] arr = new int[7] { 1, 1, 3, 3, 0, 1, 1 };
            int[] arr2 = new int[5] { 4, 4, 4, 3, 3 };

            SolveProb prob = new SolveProb();
            int[] ans = prob.RemoveRepeats(arr);



        }
    }
}