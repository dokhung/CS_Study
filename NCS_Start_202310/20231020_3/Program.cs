using System;

 class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("이 버스는 최대 10명을 태울 수 있는 버스입니다");
            int count = 0;            
            int[] priceArr = new int[(int)PassengerType.End] { (int)(2000 * 0.3f), (int)(2000 * 0.7f), 2000, 0};

            int mytotalmoney = 0;
            int price = 0;
            Passenger passenger;
            while (count < 10 )
            {
                Console.WriteLine("승객이 탑승을 시도합니다");
                passenger = new Passenger();
                price = priceArr[(int)passenger.PassengerType];
                
                if (passenger.money < price)
                {
                    passenger.ShowPassengerInfo();
                    Console.WriteLine("탑승객의 소지금이 부족하여 탑승하지 못하였습니다");
                    //해당 탑승객 정보 원한다면 출력하는것도 괜찮을거같긴해요...
                    continue;
                }
                else
                {
                    //탑승한 승객의 정보 보여주기...
                    passenger.ShowPassengerInfo();
                    Console.WriteLine("승객이 낸 돈은 " + price + "원 입니다");

                    //탑승시 내 금액을 증가시키고, 승객도 증가
                    mytotalmoney += price;
                    count++;                                                            
                }                 
                
                Console.WriteLine("현재 탑승객은 "+count + "명입니다\n");
            }                        
        }
    }

    public enum PassengerType
    { 
        Child,
        Teen,
        Adult,
        Old,

        End
    }
    class Passenger //하나만 선언해서 쓰는방법
    {
        //public PassengerType PassengerType => GetPassengerType(); //함수를 사용하는 프로퍼티의 경우...
        public PassengerType PassengerType { get; private set; } = PassengerType.End;
        int age = 0; //나이
        public int money { get; private set; } = 0; //소지금

        public Passenger()
        {
            Random random = new Random();
            age = random.Next(1, 91);
            money = random.Next(0, 501) * 10;
            PassengerType = GetPassengerType();
        }

        PassengerType GetPassengerType()
        {
            if (age <= 10)
            {
                return PassengerType.Child;
            }
            else if ( age < 20)
            {
                return PassengerType.Teen;
            }
            else if (age < 60)
            {
                return PassengerType.Adult;
            }
            else
            {
                return PassengerType.Old;
            }
        }

        public void ShowPassengerInfo()
        {
            switch (PassengerType)
            {
                case PassengerType.Child:
                    Console.Write("어린이 승객입니다.");
                    break;
                case PassengerType.Teen:
                    Console.Write("청소년 승객입니다.");
                    break;
                case PassengerType.Adult:
                    Console.Write("성인 승객입니다.");
                    break;
                case PassengerType.Old:
                    Console.Write("노인 승객입니다.");
                    break;                
                default:
                    break;
            }
            Console.WriteLine("\t"+money + "원을 소지중입니다");
        }
        //돈내는 함수 (내야할금액) { money -= 내야할금액;}
    }