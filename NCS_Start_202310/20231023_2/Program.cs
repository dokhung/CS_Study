using System;
using System.Collections.Generic;

namespace _20231023_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 큐

            Queue<int> queue = new Queue<int>();

            // for (int i = 0; i < 5; i++)
            // {
            //     queue.Enqueue(i); // 더하기
            // }
            //
            // queue.Dequeue(); // 빼기
            
            /*
             * 큐 10개 정도 요소를 채우고
             * 3개 삭제...
             * 중간 삭제 안됨
             * 큐 전체 내용 출력하기
             */
            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(i);
            }

            Console.WriteLine("10개우기 : "+queue);
            Console.WriteLine("3개 지우기 ");
            for (int i = 0; i <= 3; i++)
            {
                queue.Dequeue();
            }
            Console.WriteLine("최종 출력");
            foreach (var VARIABLE in queue)
            {
                
                Console.WriteLine(VARIABLE);
            }

        }
    }
}