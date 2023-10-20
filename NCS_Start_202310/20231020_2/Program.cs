using System;

 class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("이 버스는 최대 10명을 태울 수 있는 버스입니다");
            Bus bus = new Bus();  //존재
            Passenger passenger; //임시변수
            while (bus.passengerCount < 10)
            {
                Console.WriteLine("\n승객이 탑승을 시도합니다\n");
                passenger = Passenger.GetPassenger(); //승객 생성
                if (bus.AddPassenger(passenger.passengerType, passenger.money, out int change)  == false)
                {
                    passenger.ShowPassengerInfo(); 
                    Console.WriteLine("탑승객의 소지금이 부족하여 탑승하지 못하였습니다");
                    continue;
                }

                passenger.SetChange(change); //승객의 돈을 거스름돈으로 바꿔줌. 전체돈을 가져갔었고, 전체돈- 내야할돈 해서 change로 돌려받았음
                
                //그렇게 탑승하게된 탑승객의 정보 보여줌
                passenger.ShowPassengerInfo();

                Console.WriteLine("현재 탑승객은 " + bus.passengerCount + "명입니다\n");
            }
        }
    }

    class Bus
    {
        int[] priceArr = new int[(int)PassengerType.End] { (int)(2000 * 0.3f), (int)(2000 * 0.7f), 2000, 0 };
        public int passengerCount { get; private set; } = 0;
        int money = 0;                

        public int GetPrice(PassengerType _type) //해당 타입의 승객이 내야할 돈 반환
        {
            return priceArr[(int)_type]; 
        }

        public bool AddPassenger(PassengerType _type, int money, out int change )
        {
            change = money; /*승객 돈의 전부*/
            if (money < priceArr[(int)_type])
            {
                return false;
            }
            else
            {
                this.money += priceArr[(int)_type];
                passengerCount++;
                change -= priceArr[(int)_type]; //승객에게 돌려줄돈

                return true;
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
        public PassengerType passengerType { get; protected set; } = PassengerType.End;
        protected int age = 0;
        public int money { get; protected set; } = 0;

        public static Passenger GetPassenger()
        {
            Random random = new Random();
            PassengerType _type = (PassengerType)random.Next(0, (int)PassengerType.End);
            switch (_type)
            {
                case PassengerType.Child:
                    return new Child();                    
                case PassengerType.Teen:
                    return new Teen();
                case PassengerType.Adult:
                    return new Adult();
                case PassengerType.Old:
                    return new Old();
                default:
                    return null; //new Passenger()
            }
        }
        public void ShowPassengerInfo()
        {
            switch (passengerType)
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
            Console.WriteLine("\t" + money + "원을 소지중입니다");
        }

        public void SetChange(int change)
        {
            money = change;
        }
    }

    class Child : Passenger
    {
        public Child()
        {
            Random random = new Random();
            passengerType = PassengerType.Child;
            this.age = random.Next(1, 11);
            this.money = random.Next(0, 500) * 10;
        }
    }
    class Teen : Passenger
    {
        public Teen()
        {
            Random random = new Random();
            passengerType = PassengerType.Teen;
            this.age = random.Next(11, 20);
            this.money = random.Next(0, 500) * 10;
        }
    }
    class Adult : Passenger
    {
        public Adult()
        {
            Random random = new Random();
            passengerType = PassengerType.Adult;
            this.age = random.Next(20, 60);
            this.money = random.Next(0, 500) * 10;
        }
    }
    class Old : Passenger
    {
        public Old()
        {
            Random random = new Random();
            passengerType = PassengerType.Old;
            this.age = random.Next(60, 91);
            this.money = random.Next(0, 500) * 10;
        }
    }