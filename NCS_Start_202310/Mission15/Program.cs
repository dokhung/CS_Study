using System;
using System.Collections.Generic;
using System.Timers;

namespace Mission15
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * 자판기 음료 구매
             *
             * 소지금 랜덤 = 랜덤함수 사용
             * 자판기 음료 정해놓고 // 배열로 자판기 음료 세팅 해둠..
             * 자판기 음료 이름과 금액 정해두기
             *
             * 숫자 입력받아서 몇번째 음료 선택
             * 음료의 이름 적기
             *
             * 해당버튼 누르면 구매 = 남은 돈  보여주기
             * 
             */
            
                
                Random random = new Random();
                int MyMoney = random.Next(2000, 5000);
                
                Console.WriteLine("소지금이 랜덤으로 생성 됩니다.");
                Console.WriteLine($"소지금 : {MyMoney} ");
                string[] drinks = { "1. 포카리스웨트", "2. 환타", "3. 코카콜라", " 4. 커피", "5. 보리차" };
                int[] prices = { 2600, 1500, 1900, 1200, 1100 };
                Console.WriteLine("음료의 가격은 다음과 같습니다.");
                for (int i = 0; i < drinks.Length; i++)
                {
                    Console.WriteLine($"{drinks[i]} : {prices[i]}");
                }

                Console.WriteLine("번호를 입력하여 원하는 음료수를 선택하세요.");
                int price = 0;
                int seletedNum = int.Parse(Console.ReadLine());
                if (seletedNum == 1)
                {
                    price = 2600;
                    Console.WriteLine("1번선택");
                }
                else if (seletedNum == 2)
                {
                    price = 1500;
                    Console.WriteLine("2번선택");
                }
                else if (seletedNum == 3)
                {
                    price = 1900;
                    Console.WriteLine("3번선택");
                }
                else if (seletedNum == 4)
                {
                    price = 1200;
                    Console.WriteLine("4번선택");
                }
                else if (seletedNum == 5)
                {
                    price = 1100;
                    Console.WriteLine("5번선택");
                }

                int YouMoney = MyMoney - price;
                Console.WriteLine($"자금이 {YouMoney} 남았습니다.");
            }
        }
    }
