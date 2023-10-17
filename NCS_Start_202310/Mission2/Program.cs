using System;

namespace Mission2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            /*
             * 난수 생성기. 무작위 수를 뽑아줌.
             * 최소 이상 ~ 최대 미만
             * 가위바위보 구현하기
             *
             *
             */
            int value = random.Next(0, 3); // 0 ~ 2 나옴
            Console.WriteLine("가위바위보 게임을 시작합니다.");
            Console.WriteLine("가위는 0, 바위는 1, 보자기는 2입니다.");
            Console.Write("플레이어의 가위, 바위, 보 선택 : ");
            /*
             *  해서 입력받기
             *
             */
            string playerChoiceOrigin = Console.ReadLine(); // 플레이어 선택
            int playerChoice;
            int.TryParse(playerChoiceOrigin, out playerChoice); // 플레이어 선택이 숫자로 바뀜

            if (playerChoice == value) // 동일하다면 비겼음
            {
                Console.WriteLine("비겼습니다.");
            }
            else if((playerChoice == 1 && value == 0 ) || (playerChoice == 2 && value == 1) || (playerChoice == 0 && value == 2))
            {
                Console.WriteLine("플레이어가 이겼습니다.");
            }
            else
            {
                Console.WriteLine("컴퓨터가 이겼습니다.");
            }


            // 난수로 컴퓨터의 가위바위보 만들어서 판별해서 결과 알려주기

        }
    }
}