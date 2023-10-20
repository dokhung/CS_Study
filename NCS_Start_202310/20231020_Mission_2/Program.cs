/*
 *당신은 버스기사 입니다. 버스에 승객이 탑니다.
 * 승객은 나이 ( 랜덤 ) 1 ~90살 이고 , 돈 ( 랜덤 == 최대 5000원) 을 가지고 있습니다,
 * 금액 10원 단위 1원 단위 없음
 *
 * 아동의 나이 기준은 10세 이하 이고 어른 이용가의 30퍼를 지불합니다.
 * 청소년의 나이기준은 11세 이상 20세 미만이고, 어른 이용가의 70퍼를 지불합니다.
 * 성인의 나이 기준은 60세 미만입니다.
 * 그 이상은 노인이며, 비용을 지불하지 않습니다.
 *
 * 버스 요금은 2000원 입니다.
 *
 * 승객이 랜덤으로 10명 탑승했을떄, 각각의 승객이 아동인지, 청소년인지, 성인인지 노인인지 여부를 출력하고
 * 버스기사가 받을 총 금액을 출력합니다.
 *
 * 단, 승객이 지불할 돈이 없다면, 못타고 다음 생각이 탑니다. => 총 탑승해야 하는 인원은 10명이고,
 * 만약 중간에 돈이 부족했다면, 10명보다 많은 사람이 타려고 했던 것이 됨.
 * 
 */

/*
 * 로직 기획
 *
 * 이넘 클래스
 * 아이,청소년,어른,노인
 *
 *
 *  구조체
 *  타입,지불요금,나이
 * 
 * 
 * 부모 클래스 : 승객
 * 부모 클래스 전용 함수 : 탑승 하는 공통 함수
 * 
 * 자식 클래스 : 아동,청소년,성인,노인
 *  : 나이에 따른 자식 클래스 랜덤 생성
 *
 *  아동 클래스
 *  변수1 : 나이
 *  변수2 : 아동 나이의 금액
 *  함수1 : 지불 금액
 *
 * *  청소년 클래스
 *  변수1 : 나이
 *  변수2 : 청소년 나이의 금액
 *  함수1 : 지불 금액
 *
 * *  성인 클래스
 *  변수1 : 나이
 *  변수2 : 성인 나이의 금액
 *  함수1 : 지불 금액
 *
 * *  노인 클래스
 *  변수1 : 나이
 *  변수2 : 노인 나이의 금액
 *  특이사항 : 금액 안받음
 *  함수1 : 지불 금액
 *
 * 
 * 
 *
 *
 *  Main함수 프론트
 *  금액 생성 변수 int형 소지 금액 ( 1000 ~ 5000 ) 원 생성
 *  승객 생성시 나이(랜덤) 생성 후 나이에 비례하여 자식 클래스 배치
 *  탑승 함수 발생시 소지 금액에 따른 탑승o 탑승거부o 발생
 *  후 승객의 지불 한 금액 총 계산 값이 담긴 변수 생성 하여 출력
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace _20231020_Mission_2
{
    public enum PassengerType
    {
        Child,
        Teenager,
        Adult,
        OldHuman,

        End
    }

    struct Info
    {
        public string type;
        public int age;
        public int RideCost;
        public int MyMoney;

        public bool Riding;
        

        //
        public void PrintInfo() //이미 생성자에서 정보세팅이 끝난 후....
        {
            Console.WriteLine($"============================");
            Console.WriteLine($"탑승 손님의 나이 : {age}");
            Console.WriteLine($"탑승 손님의 타입 : {type}");
            Console.WriteLine($"탑승 손님의 보유 금액 : {MyMoney}");
            Console.WriteLine($"탑승 손님의 탑승에 필요한 금액 : {RideCost}");
            Console.WriteLine($"탑승유무 : {Riding}");

            // 삼항이 싫으면 
            // if (MyMoney >= RideCost )
            // {
            //     Riding = true;
            //     Console.WriteLine($"탑승유무 : {Riding}");
            // }
            // else //if(Riding == false)
            // {
            //     Console.WriteLine($"탑승유무 : {Riding}"); 
            // }

            Console.WriteLine($"============================");
        }
    }

    class Passenger
    {
        public Info info;
        private List<BoardingList> boardingLists = new List<BoardingList>();

        public Passenger(int fff =0)
        {
            Random random = new Random( fff ); //가상의 시드번호를 부여해서...
            // 시드번호도 초기화 가능
            info.age = random.Next(0, 90);
            Console.WriteLine("나이 : " + info.age);
            info.MyMoney = random.Next(0, 500) * 10;
            Console.WriteLine("금액 : " + info.MyMoney);
            if (info.age <= 10)
            {
                info.type = PassengerType.Child.ToString();
            }
            else if (info.age <= 20)
            {
                info.type = PassengerType.Teenager.ToString();
            }
            else if (info.age <= 60)
            {
                info.type = PassengerType.Adult.ToString();
            }
            else
            {
                info.type = PassengerType.OldHuman.ToString();
            }

            Console.WriteLine();

            if (info.type == PassengerType.Child.ToString())
            {
                info.RideCost = 600;
            }
            else if (info.type == PassengerType.Teenager.ToString())
            {
                info.RideCost = 1400;
            }
            else if (info.type == PassengerType.Adult.ToString())
            {
                info.RideCost = 2000;
            }
            else if (info.type == PassengerType.OldHuman.ToString())
            {
                info.RideCost = 0;
            }

            Console.WriteLine();

            if (info.MyMoney < info.RideCost)
            {
                info.Riding = false;
            }
            else
            {
                info.Riding = true;
            }

            Console.WriteLine();

        }

        public void PrintInfo()
        {
            Console.WriteLine($"============================");
            Console.WriteLine($"탑승 손님의 나이 : {info.age}");
            Console.WriteLine($"탑승 손님의 타입 : {info.type}");
            Console.WriteLine($"탑승 손님의 보유 금액 : {info.MyMoney}");
            Console.WriteLine($"탑승 손님의 탑승에 필요한 금액 : {info.RideCost}");
            Console.WriteLine($"탑승유무 : {info.Riding}");

            // 삼항이 싫으면 
            // if (MyMoney >= RideCost )
            // {
            //     Riding = true;
            //     Console.WriteLine($"탑승유무 : {Riding}");
            // }
            // else //if(Riding == false)
            // {
            //     Console.WriteLine($"탑승유무 : {Riding}"); 
            // }

            Console.WriteLine($"============================");
        }

        public void AddHumen(BoardingList list)
        {
            boardingLists.Add(list);
        }

    }

    

    class BoardingList
    {
        protected Info info = new Info();
        public Info Info => info;
        //private  Random random = new Random();
        //private  PassengerType type = (PassengerType)random.Next(0, (int)PassengerType.End);

        // public static void GetList()
        // {
        //     switch (type)
        //     {
        //         case PassengerType.Child:
        //             Console.WriteLine("Child");
        //             break;
        //         case PassengerType.Teenager:
        //             Console.WriteLine("Teenager");
        //             break;
        //         case PassengerType.Adult:
        //             Console.WriteLine("Adult");
        //             break;
        //         case PassengerType.OldHuman:
        //             Console.WriteLine("OldHuman");
        //             break;
        //         default:
        //             break;
        //     }
        // }







    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            // Random random = new Random();
            // int MyMoney = random.Next(0, 500) * 10;
            Console.WriteLine($"============================");
            int Cost = 2000;
            Console.WriteLine("기본 운임승차요금은 " + Cost + "원 입니다.");
            Console.WriteLine($"============================");
            int count = 0;
            Random random = new Random();
          

            Passenger passenger ;
            for (int i = 0; i < 10; i++)
            {
                passenger = new Passenger(i);
                    passenger.PrintInfo();
                    //passenger.info.PrintInfo();
                    Console.Write( (i+1) + "번째 출력이빈다");
            }
        }
    }
}