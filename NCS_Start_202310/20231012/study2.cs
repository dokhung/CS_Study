using System;

namespace _20231012
{
    public class study2
    {
        /*
         * 배열(Array)
         * student 0 1 2 3 4 5
         * 0       ㅁㅁㅁㅁㅁㅁ
         * 1       ㅁㅁㅁㅁㅁㅁ
         * 2       ㅁㅁㅁㅁㅁㅁ
         * 3       ㅁㅁㅁㅁㅁㅁ
         */

        public void Start()
        {
            // 1차원 배열
            // int[] intarr = new int[5]; // 속이 비어있는 5칸짜리 int 배열
            // int[] intarr2 = new int[] { 0, 0, 0, 0, 0 }; // 5칸짜리 0으로 채워진 int 배열
            // int[] intarr3 = new int[5] { 0, 0, 0, 0, 0 }; // 5칸짜리 0으로 채워진 int 배열
            // int[] intarr4;// = new int[] {};
            //
            // intarr4 = new int[5]; // 이 경우 혹은
            // intarr4 = new[] { 0, 0, 0, 0, 0 }; // 이 경우 혹은
            // intarr4 = new int[5] { 0, 0, 0, 0, 0 }; // 이 경우

            int[] intarr = new int[3];
            try
            {
                // for (int i = 0; i < 3; i++)
                // {
                //     intarr[i] = i + 1;
                //     Console.WriteLine(intarr[i]);
                // }
                //
                // for (int i = 0; i < 4; i++)
                // {
                //     Console.WriteLine(intarr[i]);
                // }
                //
                // for (int i = 0; i < intarr.Length; i++)
                // {
                //     Console.WriteLine(intarr[i]); // 주의 배열의 크기는 변하지 않는것이 좋다.
                // }
                //
                // Array.Resize(ref intarr, 5);
                // Console.WriteLine("intarr 배열의 길이 : " + intarr.Length);
                // Console.WriteLine("(Array.IndexOf(intarr, 2)"+ Array.IndexOf(intarr, 2));
                string[] strarr = new string[4] { "가", "나", "다", "라" };
                Console.WriteLine("index 2번째 요소" + strarr[2]);
                Console.WriteLine("라 의 index 찾기 : " +  Array.IndexOf(strarr, "라"));
                /*
                 * string str = "가나다라마바사아자차";
                 * strubg == char의 집합이다.
                 * char[] != string
                 * 
                 */
                for (int i = 0; i < strarr.Length; i++)
                {
                    Console.WriteLine(strarr[i]);
                }
                //strarr의 요소 출력하기
                for (int i = 0; i < strarr.Length; i++)
                {
                    Console.WriteLine(i + "번쨰 요소 : " + strarr[i]);
                }

            }
            catch (Exception e)
            {
                
                throw e;
            }
            
        }
        
    }
}