using System;

namespace _20231005
{
    public class SS
    {
        // private static int[][] array3 = new int[5][] { 1, 1 } ? ; // 불규칙 배열
        // int[] array = new int[] { 10, 5, 5, 41, 1,10,37,430,58 }; // 1차원 배열
        // int[,] array2 = { {10,5,5,41,1 },{10,5,5,41,1} }; // 2차원 배열
        /*
         *불규칙 배열?
         * static int[][] array2 = new int[5][];
         * ㅁㅁ
         * ㅁㅁㅁ
         * ㅁㅁ
         * ㅁㅁㅁㅁㅁ
         * ㅁㅁㅁㅁ
         */
        /*
         * 2차원 배열
         *  0 1 2 3 4
         * 0ㅁㅁㅁㅁㅁ
         * 1ㅁㅁㅁㅁㅁ
         */
        // 배열만 안쪽에 콤마 사용함

        // SS Main()
        // {
        //     array[0] = 9;
        //     array[1] = 6;
        //     array[2] = 34;
        //     array[3] = 2;
        //     array2[1, 2] = 19;
        //
        //     for (int i = 0; i < array.GetLength(0); i++)
        //     {
        //         for (int j = 0; j < array.GetLength(1); j++)
        //         {
        //             Console.Write($"{array[i,j]} - ");
        //         }
        //         Console.WriteLine();
        //     }
        //     return this;
        // }
        // public int Level { get; set; } = 1;
        // public string Name { get; set; } = "Park"; // get set 함수 이게 프로퍼티 라고 불림
        // 문제)
        // 다음 오류를 해결 하셈
        // void Main()
        // {
        //     return this;
        // }
        // 답)
        // 이유 : this 는 클래스를 가르킴 ㅋㅋㅋ
        // SS Main()
        // {
        //     return this;
        // }
        // readonly는 클래스에서만 변경이 되고 함수에서 안됨, 상수에서 변경이 된다. 수식을 넣을수 있다. , 선언만 가능하다. , 생성자에서 변경이 된다.
        // public const int a = 10; // const int a; 이건 안됨
        // public const int c = 1 + 2; // 왜 됨?
        // public const int MAX = 50; // const int는 앵간하면 대문자로 함
        // public readonly int d = 1 + 2;
        // public readonly int b = 10;
        //
        // SS()
        // {
        //     b = 20;
        // }
        // SS Main()
        // {
        //     // b = 20; b 붉은줄 나옴 => 그 이유는 b는 const라서 상수임
        //     
        //     return this;
        // }

    }

    // public class SS
    // {
    //     private int level = 0;
    //
    //     public int Level
    //     {
    //         get { return level;}
    //         set // 변경
    //         {
    //            level = value;//예약어
    //            // UI 변경
    //            // 프로퍼티
    //         }
    //     }
    //
    //     void Main()
    //     {
    //         // set
    //         level = 1; // set
    //         Level = 2;
    //         int l = Level;
    //     }
    // }

    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * 2023 10 05
             * ref 참조
             * out라는것도 있는데 이것은 값을 가지고 있으면 안된다.
             * out은 선언만 해야되고 초기화값 안됨.
             * 예를 들면 call by value ( 찾아봐 )
             * out은 결과의 의한 값을 호출 하는것
             * 클래스 안에 있는게 전역변수
             * 프라이빗 = 캡슐화( 감출수있는것은 감추고 보여줄것은 보여주고)
             * 변수처럼 사용하는 함수
             * 예) int Level{get;set;}
             * 2차원 배열
             */
            // int a = 3, b = 10, c = 0;
            // Main2(a,b,ref c);
            // Console.WriteLine(c);
            // Main3(a,b,out c);
            // Console.WriteLine(c);
            // ref가 없다면 값을 보내고 ref 가 있다면 주소를 보낸다.
            // 주소값은 0x 뭐 이런거 보냄
            
            

        }

        // static void Main2(int a, int b, ref int c)
        // {
        //     c = a + b;
        // }
        //
        // static void Main3(int a, int b, out int c)
        // {
        //     c = a + b;
        // }
    }
}