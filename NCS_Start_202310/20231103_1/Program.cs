/*
    1번 답 :
    cos a = x/a
    2번 답 :
    /ab + /ab
    3번 답 :
    3-1 답 : 모름
    3 -2 답 : 스택은 먼저 들어간 것이 나중에 나오고, 큐는 먼저 들어간 것이 먼저 나온다
    4번 답 :
    V = 1.5
    5번 답 :
    GameManager 인스턴스
 */

using System;
using System.Collections.Generic;
using Test;

namespace Test
{
    /*
     * 6번문제 ( 필수조건 : 컬렉션사용 클래스 최소 1개이상 )
     * 당신은 주유소 주인 입니다. 기름 종류는 휘발유와 경유 두가지 입니다. (gasoline /diesel)
     * 휘발유는 리터당 1800원, 경유는 1600원 입니다.
     * 차는 랜덤으로 들어옵니다.
     * 차는 기름 종류와, 필요한 기름양의 정보(최소1리터 ~ 10.0리터), 결제수단 정보를 가지고 있습니다. 결제 수단은 현금과 카드입니다.
     * 랜덤으로 차가 10대 들어올 예정이고, 각 차의 필요한 기름만큼 풀로 채워줄 예정입니다.
     * 현금으로 계산할 경우 현금 계산입니다. 라는 출력을 해주고, 카드일 경우 카드 계산이라는 출력을 해줍니다.
     * 영업이 끝나면 (10대의 차에 모든 기름을 넣어주고 나면),
     * 현금으로 총 얼마 벌었고, 카드로는 얼마 벌었는지,
     * 그리고 그 두 금액을 합한 총액과 휘발유는 얼마나 나갔고 경유는 얼마나 나갔는지 바로 알 수 있도록 구현해주세요. => 함수
     */


    
    class OilShop
    {
        private int gasolinePrice = 1800;
        private int dieselPrice = 1600;

        private int totalCashEarnings = 0;
        private int totalCardEarnings = 0;
        private double totalGasolineSold = 0;
        private double totalDieselSold = 0;


        public class Car
        {

            public string OilType { get; set; }
            public double OilAmountNeeded { get; set; }
            public string PaymentMethod { get; set; }
        }

        public List<Car> cars = new List<Car>();

        public void Showorder()
        {
            
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Car car = new Car();
                car.OilType = random.Next(2) == 0 ? "gasoline" : "diesel"; 
                car.OilAmountNeeded = random.Next(10) + 1; 
                car.PaymentMethod = random.Next(2) == 0 ? "cash" : "card"; 
                cars.Add(car);

                
                double fuelPrice = car.OilType == "gasoline" ? gasolinePrice : dieselPrice;
                double totalPrice = car.OilAmountNeeded * fuelPrice;

                if (car.PaymentMethod == "cash")
                {
                    Console.WriteLine("현금 계산");
                    totalCashEarnings += (int)totalPrice;
                }
                else if (car.PaymentMethod == "card")
                {
                    Console.WriteLine("카드 계산");
                    totalCardEarnings += (int)totalPrice;
                }

                
                if (car.OilType == "gasoline")
                {
                    totalGasolineSold += car.OilAmountNeeded;
                }
                else if (car.OilType == "diesel")
                {
                    totalDieselSold += car.OilAmountNeeded;
                }
            }
            
            Console.WriteLine("현금으로 벌은 금액: " + totalCashEarnings + "원");
            Console.WriteLine("카드로 벌은 금액: " + totalCardEarnings + "원");
            Console.WriteLine("총 수입: " + (totalCashEarnings + totalCardEarnings) + "원");
            Console.WriteLine("휘발유 판매량: " + totalGasolineSold + "리터");
            Console.WriteLine("경유 판매량: " + totalDieselSold + "리터");
            
        }

    }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * 손님이 들어옴
             * 들어오면 손님의 차가 사용하는 기름과 구매하고 싶은 기름의 양을 손님이 알려줌
             * 그러면 사장은 그걸 채워주고 돈을 받음 받은 돈은 저장됨
             * 이걸 10번 반복
             */
                OilShop oilShop = new OilShop();
                oilShop.Showorder();
        }
    }