using System;

namespace TextGame1
{
    internal class Program
    {
        private static int youScore = 0; // You의 점수를 저장하는 변수
        private static int notYouScore = 0; // 상대의 점수를 저장하는 변수

        public static void Main(string[] args)
        {
            Console.WriteLine("가위 바위 보 게임");
            Console.WriteLine();
            OnPlay();
        }

        static void OnPlay()
        {
            Console.WriteLine($"You : {youScore}");
            Console.WriteLine($"상대 : {notYouScore}");
            Console.WriteLine();
            Console.WriteLine("가위 바위 보 중 하나를 선택하시오");
            Console.WriteLine("1번 가위 2번 바위 3번 보");
            int youNum;
            
            while (true)
            {
                try
                {
                    youNum = int.Parse(Console.ReadLine());
                    if (youNum >= 1 && youNum <= 3)
                    {
                        break; // 유효한 숫자가 입력되었을 때 루프 종료
                    }
                    else
                    {
                        Console.WriteLine("1에서 3 사이의 숫자를 입력하세요.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("숫자를 입력하세요.");
                }
            }
            Console.Clear();
            if (youNum == 1)
            {
                Console.WriteLine("가위");
            }
            else if (youNum == 2)
            {
                Console.WriteLine("바위");
            }
            else if (youNum == 3)
            {
                Console.WriteLine("보");
            }
            Console.WriteLine("를 냈습니다");
            Console.WriteLine("상대가 이제 냅니다.");
            Random random = new Random();
            int resultNum = random.Next(1, 4);
            Console.WriteLine("상대가 낸 것은 다음과 같습니다.");

            if (resultNum == 1)
            {
                Console.WriteLine("가위");
                Console.WriteLine("입니다");
                OnResult(resultNum, youNum);
            }
            else if (resultNum == 2)
            {
                Console.WriteLine("바위");
                Console.WriteLine("입니다");
                OnResult(resultNum, youNum);
            }
            else if (resultNum == 3)
            {
                Console.WriteLine("보");
                Console.WriteLine("입니다");
                OnResult(resultNum, youNum);
            }
        }

        static void OnResult(int resultNum, int youNum)
        {
            Console.WriteLine($"You : {youScore}");
            Console.WriteLine($"상대 : {notYouScore}");
            Console.WriteLine();
            Console.WriteLine("----------------------------------");

            if (youNum == 1)
            {
                Console.WriteLine("You 가위");
            }
            else if (youNum == 2)
            {
                Console.WriteLine("You 바위");
            }
            else if (youNum == 3)
            {
                Console.WriteLine("You 보");
            }
            Console.WriteLine("입니다");
            Console.WriteLine("-------------");
            if (resultNum == 1)
            {
                Console.WriteLine("상대 가위");
            }
            else if (resultNum == 2)
            {
                Console.WriteLine("상대 바위");
            }
            else if (resultNum == 3)
            {
                Console.WriteLine("상대 보");
            }
            Console.WriteLine("입니다");
            Console.WriteLine("---------------");

            if (youNum == resultNum)
            {
                Console.WriteLine("비김");
            }
            else if ((youNum == 1 && resultNum == 3) || (youNum == 2 && resultNum == 1) || (youNum == 3 && resultNum == 2))
            {
                Console.WriteLine("이겼음");
                youScore++;
            }
            else
            {
                Console.WriteLine("졌음");
                notYouScore++;
            }

            Console.WriteLine("계속하려면 선택하세요");
            OnPlay();
        }
    }
}