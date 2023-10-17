using System;
using System.Linq;
namespace _20231006
{
    internal class Program
    {
        // 불규칙 배열
        // public int[][] array2 = new int[3][]
        // {
        //     // 위에가 3개라도 3개 4개 이런식도 가능은 하다.
        //     // 초기값 없이 진행을 하려면
        //     // new int[2],
        //     // new int[3],
        //     // new int[5],
        //     // new[] { 1, 2 },
        //     // new[] { 1, 2, 3, 4 },
        //     // new[] { 1, 2, 10, 29, 10 }
        //     
        // };
        // int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        
        public static void Main(string[] args)
        {
            // int sum = array.Count();
            // foreach (var item in array)
            // {
            //     
            // }
            // for (int i = 0; i < 3; i++)
            // {
            //     for (int j = 0; j < array2[i].Length; j++)
            //     {
            //         
            //     }
            // }

            /*
             *예) {} 이것이 없는 if
             * if(true)
             * return;
             * 설명 : 1줄 표햔이라고 합니다.
             * return은 예외처리 입니다.
             *선생님 말 : 내가 말하는것은 다 유니티에서 쓰임.
             *
             */
            // Console.WriteLine(Sum(1,2));
            // Console.WriteLine("{0:F5}",123.456); // 123,456,789 (자릿수 0은 소수점 이하 버림)
            // int a = int.Parse(Console.ReadLine());
            // 어쨋던 숫자를 입력하잔아 문자를 입력하면 안되는데 그래서 포맷이 틀려먹었다고 오류메시지가 날라옴 그럴때 try catch를 사용함 
            // 트라이 캐취는 예외처리인데
            // try
            // {
            //     int a = int.Parse(Console.ReadLine());
            // }
            // catch (System.FormatException e)
            // {
            //     Console.WriteLine("에러 발생");
            //     throw;
            // }
            /*
             * Console.WriteLine("몇개를 뺄거?");
             * int removeCnt = 0;
             * try{
             *removeCnt = int.Parse(Console.ReadLine());
             * }
             * catch(System.ArgumentException e){
             *Console.WriteLine("에러발생");   <- 그후 지금 에러발생한 함수를 다시 실행하도록 입력
             * 함수 재실행 영역 !
             * 
             * }
             */
            
        }
        // int Sum(int a, int b)
        // {
        //     return a + b;
        // }
        //
        // int Sum2(int a)
        // {
        //     return a;
        // }
        
        
    }

    
}