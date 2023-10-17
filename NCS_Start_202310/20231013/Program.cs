using System;
using System.Collections.Generic;
using System.Linq;

namespace _20231013
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * 배열은 3개를 채우면 3개만 함
             * ㅁㅁㅁ
             * List는 계속 채울순 있음
             * ㅁㅁㅁㅁ
             */
            
            // List
            // System.Collections.Generic;
            // List<string> strList = new List<string>();  // 쓸준비
            // // strList.Add("값");
            // Console.WriteLine("리스트의 개수" + strList.Count);
            // strList.Add("가");
            // // strList.Add("나");
            // // strList.Add("다");
            // // strList.Add("라");
            //
            // Console.WriteLine("리스트의 개수" + strList.Count);
            //
            // // strList[0] = "가";
            // for (int i = 0; i < strList.Count; i++)
            // {
            //     Console.WriteLine(i + "번째 리스트 내용" + strList[i]);
            // }
            //
            // strList.Remove(/*리스트안의 값을 검색해서 해당 값을 지움*/"다");
            // strList.RemoveAt(2); // 해당 인덱스를 지움
            // Console.WriteLine("\n '다' 를 삭제한 리스트의 개수 : " + strList.Count + "\n");
            // Console.WriteLine("리스트의 개수 : " + strList.Count);

            {
                Console.WriteLine("다른거");
                List<int> intList = new List<int>() { 1, 2, 3, 4, 5, 6 };
                Console.WriteLine("리스트안에 3이 있는가? : " + intList.Contains(3)); // 나의 리스트.Contains(내가 찾고자 하는 대상 )
                // 있다면 True 반환 없다면 Faluse 반환
                Console.WriteLine("3이 리스트 안에 어디에 있는가 ? :" + intList.IndexOf(3));
                Console.WriteLine("7이 리스트 안에 어디에 있는가 ? : " + intList.IndexOf(7));

                int[] intarr = intList.ToArray();  // ToArray()함수는 배열로 바꾸는것임
                for (int i = 0; i < intarr.Length; i++)
                {
                    Console.WriteLine("배열에 리스트가 잘 들어갔는지 확인 " + intarr[i]);
                }

                Console.WriteLine(); // 보기 좋으라고 엔터 넣음

                List<int> newList = new List<int>();
                newList.AddRange(intarr); // 배열을 리스트에 넣음

                for (int i = 0; i < intarr.Length; i++)
                {
                    Console.WriteLine("배열에 리스트가 잘 들어갔는지 확인" + intarr[i]);
                }
                
                newList.Sort(); //오름차순
                Console.WriteLine("\n오른차순 실행함");
                for (int i = 0; i < newList.Count; i++)
                {
                    Console.WriteLine("리스트 확인" + newList[i]);
                }
                newList.Reverse(); //내림차순
                for (int i = 0; i < newList.Count; i++)
                {
                    Console.WriteLine("리스트 확인" + newList[i]);
                }
                // 물론 배열도 리스트로 만들수는 있지만
            }
        }
    }
}