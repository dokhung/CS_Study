using System;
using System.Text;

namespace _20231012
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             *for (int i = 0; i < 3; i++)
            {
                
            }
             * 
             */
            // for (int i = 0; i < 3; i++) // 리스트 의 제거..
            // {
            //     Console.WriteLine(i + "번째 입니다.");
            // }

            // StringBuilder stringBuilder = new StringBuilder();
            //
            // stringBuilder.Append("뭔가").Append("내용");
            // stringBuilder.Append("더하기");
            /*
             *for( ; ;){}
             * 위도 가능하지만 무한루프됨 ㅋㅋㅋ
             * 
             */
            // int i = 0;
            // while (i < 3)
            // {
            //     Console.WriteLine(i + "번째 입니다.");
            //     i++;
            // }

            // while (false)
            // {
            //     Console.WriteLine("while문 입니다.");
            // }
            //
            // do
            // {
            //     Console.WriteLine("while문 입니다.");
            // } while (false);
            
            // 반복문의 탈출
            // for (int i = 0; ; i++)
            // {
            //     if (i % 2 == 0)
            //     {//짝수면 스킵하고 다음조건 실행.
            //         continue;
            //     }
            //     Console.WriteLine(i+"번째 반복중");
            //     if (i == 10)
            //     {
            //         Console.WriteLine("i가 10이 되었음");
            //         break;
            //     }
            //     Console.WriteLine("if문 다음 출력"); // i가 10일때 이건 출력되지 않음. 위에서 이미 나가버렸기 떄문.
            // }
            // Console.WriteLine("return과 break 차이 위한 줄"); // break는 if문을 나가고 return는 함수를 나감

            // int a = 1;
            // int b = ++a;
            //
            // Console.WriteLine($"a의 값 = {a}, 전위증가한 a의 값 = {b}");
            //
            // a = 1;
            // b = a++;
            //
            // Console.WriteLine($"a의 값 = {a} . 전위감소한 a의 가ㅓㅄ = {b}");
            //
            // a = 1;
            // b = a--;
            //
            // Console.WriteLine($"a의값 = {a} , 후위 감소한 a의 값 = {b}");

            // try
            // {
            //     int num1, num2;
            //     while (true)
            //     {
            //         Console.WriteLine("숫자를 두개 입력해주세요. 정상적인 입력이면 나눈 결과를 알려줍니다.");
            //         Console.Write("첫번쨰 숫자 입력 : ");
            //         num1 = Convert.ToInt32(Console.ReadLine());
            //
            //         Console.Write("두번째 숫자 입력 :");
            //         num2 = int.Parse(Console.ReadLine());
            //         Console.WriteLine("처음숫자를 두번쨰 숫자로 나눈 결과 : " + (num1 / num2));
            //     }
            // }
            // catch (DivideByZeroException divideEx) // 오류캐치
            // {
            //     Console.WriteLine("0으로 나눈 문제가 발생함");
            //     throw divideEx;
            // }
            // catch (OverflowException overEx)
            // {
            //     Console.WriteLine("오버 플로우 발생");
            //     throw overEx;
            // }
            //
            // catch (Exception e)
            // {
            //     Console.WriteLine(e);
            //     throw;
            // }
            /*
             * 다음과 같이 하나로 퉁쳐도된다. 오류캐치  즉 니가 알아서 알려줘
             * catch(Exception ex)
             * {
             *  throw new Exception("오류", ex)
             * }
             */
            
            /*
             * finally // 예외발생 여부와 상관없이 마지막에 반드시 실행할 내용
             */
            // new study2().Start();
            
            /*
             * 2차원 배열
             * 
             */
            // string[,] arr = new string[2, 3];
            // string[,] arr2 = new string[2, 3]
            // {
            //  { "가", "가", "가" }, 
            //  { "가", "가", "가" }
            // };
            // Console.WriteLine("길이체크 : " + arr2.Length);
            // Console.WriteLine("arr2.GetLength(0)길이 체크 :" + arr2.GetLength(0));
            // Console.WriteLine("arr2.GetLength(1)길이 체크 :" + arr2.GetLength(1));
            // Console.WriteLine();
            //
            // for (int i = 0; i < arr2.GetLength(2); i++)
            // {
            //  for (int j = 0; j < arr2.GetLength(1); j++)
            //  {
            //   Console.WriteLine($"[{i},{j}]배열체크 : " + arr2[i,j]);
            //  }
            // }
            // \t == 탭
            // 2차원 배열
            
            // 심화를 바란다면
            /*
             *가  라
             * 나  마
             * 다  바
             * 
             */
        }
    }
}