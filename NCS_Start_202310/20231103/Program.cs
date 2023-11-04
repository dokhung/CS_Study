using System;
using System.Collections.Generic;

namespace NCS_Start_202310
{
    //1번부터 5번 문제는 주석처리 후에 입력해주시고
    //1번) 삼각함수를 이용하여 x의 길이를 구하는 식을 써주세요

    //cos b = x / a;
    // x = cos b * a; == 정답

    //2번) 사람이 목적지를 향해 간다고 할 때, 그 사람의 방향벡터를 구하는 식을 써주세요.    
    //(목적지 - 사람위치) == 정답

    //3번) 다음 문장의 괄호 안을 채우시오.
    //- 속력과 시간이 주어졌을 때, 속력 (    곱하기    ) 시간  =   (    거리     ) 를 구할 수 있다.
    //- 스택은 먼저 들어간 것이 (  나중에  ) 나오고, 큐는 먼저 들어간 것이  (  먼저   ) 나온다.

    //4번 ) 마찰이 없는 직선상에서 질량이 2kg인 물체 A는 오른쪽으로 4m/s의 속력으로 움직이고,
    //질량이 4kg인 물체 B는 왼쪽으로 3m/s의 속력으로 움직이다가 정면충돌하였다.
    //충돌 후 A가 왼쪽으로 4m/s의 속력으로 움직일때, 충돌후 B의 운동방향과 속력은 몇 m/s인가?
    // 2kg * 4m/s  + 4kg * (- 3m/s ) = 2kg * (-4m/s) + 4kg * X
    // 8+ (-12) = -8 + 4X
    // -4 = -8 + 4X
    // -4 +8 = -8 +8 +4X
    // 4 = 4X
    //X == 1 => B가 오른쪽으로 1m/s 의 속력으로 움직이게 됐음.

    //5번 ) GameManager라는 클래스를 싱글톤으로 만드려고 할 때, 싱글톤이기 위해 반드시 필요한 변수를 선언하세요
    //static GameManager instance = null;
    //public static GameManager 인스턴스=>instance; //접근가능...


    //6번문제는 코드로 구현하면 됩니다. //필수조건 == 컬렉션을 사용할 것..클래스 최소 1개이상
    //당신은 주유소 주인입니다. 기름 종류는 휘발유와 경유 두가지 입니다. (gasoline / diesel)
    //휘발유는 리터당 1800원, 경유는 1600원입니다.
    //차는 랜덤으로 들어옵니다.
    //차는 기름 종류와, 필요한 기름양의 정보(최소1.0리터~ 10.0리터 == 소수점 한자리 ),
    //결제수단 정보를 가지고 있습니다.결제 수단은 현금과 카드입니다.
    //랜덤으로 차가 10대 들어올 예정이고, 각 차의 필요한 기름만큼 풀로 채워줄 예정입니다.
    //현금으로 계산할 경우 현금계산입니다 라는 출력을 해주고, 카드일 경우 카드계산이라는 출력을 해줍니다.
    //영업이 끝나면 (10대의 차에 모든 기름을 넣어주고 나면) , 
    //현금으로 총 얼마 벌었고, 카드로는 얼마 벌었는지,
    //그리고 그 두 금액을 합한 총액과 휘발유는 얼마나 나갔고 경유는 얼마나 나갔는지 바로 알 수 있도록 구현해주세요.=>함수..
    public enum Oil
    {
        Gasoline,
        Diesel,        

        End
    }

    public enum Pay
    {
        Card,
        Cash,

        End
    }
    public class GasStation
    {
        int cardval = 0; //카드계산한 값
        int cashval =0;   //현금계산값
        float gasol = 0; //총 팔은 가솔린양
        float diesel = 0; //총 팔은 디젤양

        public Dictionary<Oil, int> oilprice = new Dictionary<Oil, int>(2) { { Oil.Gasoline, 1800}, { Oil.Diesel, 1600 } };

        //1번 모든 차의 정보들을 들고 있다가.. 

        public void AddCar(Car car)
        {
            if (car.oil == Oil.Gasoline) //가솔린일떄
            {
                gasol += car.oilValue;
            }
            else //경유일때
            {
                diesel += car.oilValue;
            }
            if (car.pay == Pay.Card)
            {
                cardval += (int)(car.oilValue * oilprice[car.oil]); //
            }
            else 
            {
                cashval += (int)(car.oilValue * oilprice[car.oil]); //
            }            
        }
        public int GetMoney(Pay pay) //pay. card 
        {
            switch (pay)
            {
                case Pay.Card:
                    return cardval; 
                    break;
                case Pay.Cash:
                    return cashval;
                    break;                
                default:
                    return cardval + cashval;
                    break;
            }
        }
    }

   
    public class Car 
    {        
        public Oil oil { get; private set; } //내가 쓰는 오일 종류
        public Pay pay { get; private set; } //결제 방식

        public float oilValue { get; private set; } = 0; //필요 기름양        

        public Car(Random random)
        {
            oil = (Oil)random.Next(0, 2);
            pay = (Pay)random.Next(0, 2);
            oilValue = random.Next(10, 101 ) * 0.1f; //
        }
    }

    class Program
    {
        static void Main(string[] a)
        {
            Random random = new Random();
            GasStation Me = new GasStation();
            Car car=null;
            for (int i = 0; i < 10; i++)
            {
                car = new Car(random);
                Me.AddCar(car);
            }
            //카드의 경우
            Console.WriteLine(Me.GetMoney(Pay.Card));

            Console.WriteLine(Me.GetMoney(Pay.Cash));

            Console.WriteLine(Me.GetMoney(Pay.End));
        }
    }
}