using System;
using System.Collections.Generic;
using System.Linq;

namespace Mission11
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * 리스트 선언. 최소 5개이상 더하기
             * 반복문을 이용하여 하나씩 다 지워내기
             * List도 List<int> intList = new List<int>() {0,1,2,3,4} 이런식으로 생성시 초기화 가능
             */
            List<int> intList = new List<int>();
            intList.Add(0);
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
            Console.WriteLine(intList.Count);
            for (int i = 0; i < intList.Count; i++)
            {
                intList.Remove(i);
                Console.WriteLine(intList.Count);
            }

            {
                List<int> intList2 = new List<int>();
                Random random2 = new Random();
                int val = random2.Next(5, 8);
                for (int i = 0; i < val; i++)
                {
                    intList2.Add(random2.Next(-10,11));
                    Console.WriteLine(i+"번째 리스트의 값 : " + intList2[i]);
                }

                Console.WriteLine("=삭제 작업=");
                for (int i = 0; i < intList.Count(); i++)
                {
                    intList.RemoveAt(i);
                }

                Console.WriteLine("삭제 작업 후의 리스트의 개수 : " + intList.Count);
                for (int i = 0; i < intList.Count; i++)
                {
                    Console.WriteLine(i+"번째 리스트의 값 : "+ intList[i]);
                }

                int cut = intList.Count;
                // count는 이 밑으로 항상~ 숫자 5임...
                for (int i = 0; i < cut; i++)
                {
                    Console.WriteLine("i의 수 : " + i + " / 리스트의 개수 체크 : " + intList.Count);
                    intList.RemoveAt(i);
                }
                Console.WriteLine("삭제 작업 후의 리스트의 개수 : " + intList.Count);
                for (int i = 0; i < intList.Count; i++)
                {
                    Console.WriteLine(i + "번째 리스트의 값 : " + intList[i]);
                }

                for (int i = intList.Count() - 1; i >= 0; i--)
                {
                    intList.RemoveAt(i);
                }

                Console.WriteLine();
            }
        }
    }
}