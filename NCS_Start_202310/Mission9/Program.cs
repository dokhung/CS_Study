using System;

namespace Mission9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            #region 1차원 배열 역행연습
            
            /*
             * 1차원 배열선언과 랜덤 값 넣어서 다 채워보기 // float int char
             * 채운걸 역행하여 출력해보기 ( 감소형 반복문 => 증감식이 i-- 이런 형태를 말하는 것 )
             *
             */
            int[] arr1 = new [] { 0, 1, 2, 3, 4 };
            Random random = new Random();
            Console.WriteLine("위 에서 아래로");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i] = random.Next(0,4));
            }

            {
                Console.WriteLine("아래에서 위로");
                for (int i = 0; i < arr1.Length; i--)
                {
                    Console.WriteLine(arr1[i] = random.Next(0,4));
                }
            }
            {
                // 정답
                int[] intarr = new int[10];
                Random random1 = new Random();
                int value2 = 0;

                int value = random1.Next( /*최소값이상,최대값미나*/);
                for (int i = 0; i < intarr.Length; i++)
                {
                    // 1번 방법
                    intarr[i] = random.Next( /*최소값이상,최대값미만*/);
                    // 2번 방법
                    // value2 = random.Next( /*최소값이상, 최대값미만*/);
                    // intarr[i] = value;
                }

                for (int i = intarr.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(i+"번째 배열 출력"+intarr[i]);
                }
            }
            

            #endregion
            
        }
    }
}