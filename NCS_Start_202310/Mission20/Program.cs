/*
 *사용자가 수식을 입력하면 그에 따른 계산결과를 알려주는 계산기 만들기
 * 항은 두가지만 받고, 각 항은 한자리 수 여야함.
 * 연산은 사칙연산 4가지
 * 예를 들어 사용자가 1+2 를 입력하면
 * 더하기를 수행하는 함수를 불러 매개변수로 1과 2를 넣고 결과값인 3을 돌려줘야 하는것
 * 단, 모든 함수는 반환형 없이 (void) ref 키워드 혹은 out 키워드를 쓰도록 한다.
 *
 */

using System;

namespace Mission20
{
    internal class Program
    {
        public static void sum(ref int x, ref int y, out int result)
        {
            result = x + y;
        }

        public static void Minus(ref int x, ref int y, out int result)
        {
            result = x - y;
        }
        public static void Multiplication(ref int x, ref int y, out int result)
        {
            result = x * y;
        }
        public static void division(ref int x, ref int y, out int result)
        {
            result = x / y;
        }
        public static void Main(string[] args)
        {
            while (true)
            {
                string maths = "";
                int intValue1 = 0;
                int intValue2 = 0;
                int result2 = 0;

                Console.WriteLine("수식을 입력해주세요. 두 개의 항을 받으며, 항의 값은 1이상 10미만의 값입니다.");
                // Console.Write("수식 입력 : "); // 수식은 무조건 a수식b 의 형식이다. 스페이스를 치게되면 스페이스도 한글자이기 떄문에 유의할것
                Console.Write("1항 : ");
                intValue1 = int.Parse(Console.ReadLine());
                Console.Write("수식 : ");
                maths = Console.ReadLine();
                Console.Write("2항 : ");
                intValue2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"조합 : {intValue1}{maths}{intValue2}");
                if (maths == "+")
                {
                    sum(ref intValue1, ref intValue2,out result2);
                
                }
                else if (maths == "-")
                {
                    Minus(ref intValue1, ref intValue2,out result2);
                
                }
                else if (maths == "*")
                {
                    Multiplication(ref intValue1, ref intValue2,out result2);
                
                }
                else if (maths == "/")
                {
                    division(ref intValue1, ref intValue2,out result2);
                
                }
            
            
                Console.WriteLine("해당 수식의 결과 : " + result2);
            }
        }
    }
}