using System.Collections.Generic;

namespace _20231017
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // //데이터형식
            // string[] a = new string[3]; // 3칸짜리 배열을 쓸 줄비가 됐음...
            // // a[2] // 배열의 마지막요소
            //
            // List<string> b = new List<string>();
            //
            // List<int> c = new List<int>();
            // c.Add(1);
            // c.Add(2);
            // c.Add(3);
            // c.Remove(1); // remove 1을 찾아서 지우고
            // c.RemoveAt(1); // 1번쨰 .. 0,1 > 1반쩨 지워라
            //
            // b.Remove("1");
            // b.RemoveAt(1);

            // CCC c = new CCC(); // CCC 붕어빵기계, c 붕어빵
            // CCC d = new CCC();
            // c.VAL3  // 값넣는거 안됨  예) c.VAL3 = 'a'  // 읽는것만 가능
        }

        // class CCC // 클래스 // 끝... // 한글 되긴 한데 위험함
        // {
        //     public int val;
        //     protected string val2;
        //     /*private*/ char val3;
        //
        //     public char VAL3 => val3; // private으로 선언한 나의 char val3을 보여는 주겠으나, 값을 바꾸는건 허락하지 않겠음...
        //     public float val4 { /*public*/ get; /*남이 읽는것*/ set; /*값을 세팅 하는것*/ } // 캡슐화(깔끔한정리)를 잘해야된다.
        //     // private set == 내 클래스 안에서 나만 값을 세팅할것임..
        //     void AA()
        //     {
        //         // val4 = 10.2f;
        //     }
        //
        //     public void SetVal4(float _val4)
        //     {
        //         val4 = _val4;
        //     }
        // }
    }

    // class A
    // {
    //     private /*옵션*/ void B(/*매개변수도 없어서 비워놨음*/)
    //     {
    //         // 암묵적으로 B 함수는 private입니다.
    //     }
    //
    //     public int c(int _a, int _b)
    //     {
    //         return _a + _b;
    //     }
    //
    //     public string D(char _a, char _b) // 매개변수가 반환값이랑 같을 필요가 없다.
    //     {
    //         string str = "abcde";
    //         str += _a;
    //         str += _b;
    //         // return _a.ToString() + _b.ToString();
    //         return str;
    //     }
    // }
    // class BB
    // {
    //     private int val;
    //
    //     public BB(int val) // 매개변수는 내 맘대로 가능...
    //     {
    //         this.val = val;
    //     }
    // }
}