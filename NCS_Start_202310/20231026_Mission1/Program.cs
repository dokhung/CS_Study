using System;
using System.Collections.Generic;

namespace _20231026_Mission1
{
    /*
     * 겹치지 않게 랜덤수 7개 뽑기... 트리랑은 상관없음... 이런거 꽤 자주 할 확률이 커서 지금 해봅시다.
     */
    internal class Program
    {
        public static void Main(string[] args)
        {
            // int[] intarr = new int[20] { 1, 2, 3, 4, 5, 6, 7,8,9,10,11,12,13,14,15,16,17,18,19,20 };
            // List<int> intListArr = new List<int>()
            //     { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            // Random random = new Random();
            //
            // for (int i = 0; i < intListArr.Count - 13; i++)
            // {
            //     intListArr.Remove(1);
            //     if (random.Next(1,intListArr[i]) == 1)
            //     {
            //         
            //         Console.Write(random.Next(1,intarr[i]));
            //     }
            // }

            // {
            //     for (int i = 0; i < intarr.Length - 13; i++)
            //     {
            //         Console.Write(random.Next(1,intarr[i]));
            //     }
            // }
            Random random = new Random();
            // List<int> list = new List<int>();
            // int a = 0;
            // for (int i = 0; i < 7; )
            // {
            //     a = random.Next(1, 21);
            //     if (list.Contains(a) == false)
            //     {
            //         list.Add(a);
            //         Console.WriteLine(a);
            //         i++
            //     }
            //     else
            //     {
            //         continue;
            //     }
            // }
            List<int> list = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                list.Add(i);
            }

            int rand = 0;
            for (int i = 0; i < 7; i++)
            {
                rand = random.Next(0, list.Count);
                Console.WriteLine(list[rand]);
                list.RemoveAt(rand);
            }
        }
    }
}