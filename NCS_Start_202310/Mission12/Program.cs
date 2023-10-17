using System;
using System.Collections.Generic;

namespace Mission12
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * 7개의 리스트 생성
             * 한번 내용을 쫙 보여준 후에
             * 짝수의 index마다 요소를 삭제할것
             * 잘 삭제되었는지 또 보여줄것
             */

            List<int> intList = new List<int>();
            // intList.Add(0);
            // intList.Add(1);
            // intList.Add(2);
            // intList.Add(3);
            // intList.Add(4);
            // intList.Add(5);
            // intList.Add(6);
            // intList.Add(7);
            // for (int i = 0; i < intList.Count; i++)
            // {
            //     Console.WriteLine("intList[i] => "+ intList[i]);
            // }
            //
            // Console.WriteLine("짝수 삭제");
            // for (int i = 0; i < intList.Count - 1; i++)
            // {
            //     Console.WriteLine("intList.Remove(i) => " + intList.Remove(i));
            // }

            {
                Random random = new Random();
                List<int> intList2 = new List<int>();
                for (int i = 0; i < 7; i++)
                {
                    intList2.Add(random.Next(-20, 20));
                    Console.WriteLine(i+"번째 리스트 내용 : " + intList2[i]);
                }
                
                // 짝수의 index마다 요소를 삭제할것...
                for (int i = intList2.Count - 1; i >=0; i--)
                {
                    //1번방법
                    if (i % 2 == 0) // 짝수의 인덱스
                    {
                        intList2.RemoveAt(i);
                    }
                    //2번방법
                    if (i % 2 == 1) // 홀수의 인덱스
                    {
                        continue;
                    }
                    // 잘 삭제가 되었는지 또 보여줄것
                    for (int j = 0; j < intList2.Count; j++)
                    {
                        Console.WriteLine(intList2[i]);
                    }
                }
            }
        }
    }
}