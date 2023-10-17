using System;

namespace Mission10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            #region 2차원배열 역행연습
            /*
             * 2차원 배열 선언, 각각 칸에 랜덤값 넣기
             * 값이 채워진 2차원 배열을 역행 출력하기
             * int[,] 이름짓기 = new int[행,열];
             * 행렬이름.GetLength(0) == 행의 크기
             * 행렬이름.GetLength(1) == 열의 크기
             */
            int[,] twoarray = new int[,] { {0,1,2,3,4,5 }, {6,7,8,9,10,11} };
            Random random = new Random();
            for (int i = 0; i < twoarray.GetLength(0); i++)
            {
                for (int j = 0; j < twoarray.GetLength(1); j++)
                {
                    Console.WriteLine(twoarray[i,j] = random.Next());
                }
            }

            {
                // 정답
                Random random2 = new Random();
                int[,] intarr = new int[3, 4];
                for (int i = 0; i < intarr.GetLength(0); i++)
                {
                    for (int j = 0; j < intarr.GetLength(0); j++)
                    {
                        intarr[i, j] = random2.Next();
                    }
                }

                for (int i = intarr.GetLength(0) - 1; i >= 0; i--)
                {
                    for (int j = 0; j < intarr.GetLength(0); j++)
                    {
                        Console.WriteLine($"[{i},{j}]의 값 : " + intarr[i,j]);
                    }
                }
            }

            #endregion

        }
    }
}