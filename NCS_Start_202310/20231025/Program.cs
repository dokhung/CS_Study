using System;
using System.Collections.Generic;

namespace _20231025
{
    delegate string DelegateSample1(int a); // 매개변수로 int를 받고, string으로 반환하는 메서드를 담을 준비가 된 델리게이트
    internal class Program
    {
        static string AAA(int _a)
        {
            Console.WriteLine("이건 AAA 함수 입니다.");
            return _a.ToString();
        }
        public static void Main(string[] args)
        {
            /*
             * Delegate ( 델리게이트 )
             *대리자. 메소드 참조를 포함하는 영역
             * C/C++의 함수 포인터와 비슷한 개념
             *
             * 
             */
            DelegateSample1 delsample = AAA;
            int a = 10;
            List<string> bb = new List<string>();
            AAA(10);
            Console.WriteLine("delsample 호출 : " + delsample(999));


        }
    }
}