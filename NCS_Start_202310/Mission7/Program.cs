using System;

namespace Mission7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * 숫자 입력한 해당 구구단 출력하는 프로그램 만들기
             * 만약 좀더 어렵게 진행하고 싶으신분은 구구단 역행으로 출력하기
             * 0이하의 숫자나 숫자가 아닌 것을 입력하면 종료하도록 만들기
             */
            Console.Write("1부터 9중 하나를 입력하면 해당 숫자의 구구단이 출력됩니다.");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                   // Console.WriteLine($"{num} * {i} = {num * i}");
                   if (num == 0 || num < 0)
                   {
                       Console.WriteLine("0은 출력하지 않습니다.");
                       break;
                   }
                   else
                   {
                       
                       Console.WriteLine($"{num} * {i} = {num * i}");
                   }
            }

            {
                Console.WriteLine("-----------------------");
                int val = 0;
                while (true)
                {
                    Console.WriteLine("출력하실 구구단의 숫자를 입력해주세요. 1보다 작거나 종료 라고 입력시 종료됩니다.");
                    Console.WriteLine("출력할 구구단 :");
                    Console.WriteLine("");
                    if (int.TryParse(Console.ReadLine(), out val))
                    {
                        if (val == 0)
                        {
                            Console.WriteLine("0을 입력하여 반복입력을 중단합니다.\n");
                            // goto GOAL; // goto 안쓰는게 좋음
                        }
                        {
                            
                        }
                        if (val < 1)
                        {
                            // goto GOAL2;
                            Console.WriteLine("자연수를 입력해주세요\n"); // 역슬래쉬 : 엔터
                            continue;
                        }
                        else
                        {
                            for (int i = 9; i > 0; i--)
                            {
                                Console.WriteLine($"{val} * {i} = {val * i}");
                            }
                            Console.WriteLine();
                        }
                    }
                    else // 숫자 안쓴경우
                    {
                        GOAL2: // else 안에 있어서 if ~else로 나뉜 경우고.. 조건식 밖에 있어야함...
                        Console.WriteLine("프로그램 종료");
                        return; // 함수를 나감 현재 여기는 Main함수라서 그냥 종료로 직결됨.
                        // break 반복문을 나감
                    } 
                }
                // GOAL: // val를 0 눌렀을때 goto에서 
                
            }
        }
    }
}