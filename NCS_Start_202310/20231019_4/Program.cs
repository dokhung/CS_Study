using System;
using System.Collections.Generic;

 // 가챠뽑기
    // 장난감 가챠를 n회 진행합니다 (n회는 입력받기)
    // n회의 장난감 뽑기를 진행한 후,
    // 해당 장난감들의 모든 가격을 더해 얼마인지 알아야하고, 장난감을 하나씩 오픈하여 뭔지 확인하고 싶습니다

    //=> 각 장난감은 고유기능을 알려주는 함수가 있고,
    //   어떤 이름의 얼마짜리 장난감인지 알려주는 함수가 있습니다. 

    //ex) 장난감1 클래스에는 BallPop(){ "공이 통통 튑니다" } 라는 함수가 있다면
    //      장난감2클래스에는 CarRun(){"차가달립니다"}같은 함수가 존재
    //      공통 함수에는 GetInfo() {" 이 장난감의 이름은 ~~ 이고, ~~원입니다 "}


    //장난감 (가장 상위 부모 클래스)
    // 장난감의 이름, 가격 요소가 반드시 있어야함

    //장난감 부모클래스를 상속받은 장난감 자식클래스가 최소 3개이상 있어야하고 클래스이름이나 장난감 이름, 가격은 자율입니다.

    enum ToyType
    { 
        Ball,
        Doll,
        Car,
        Robot,

        End
    }
    class Toy
    {
        public ToyType toyType = ToyType.End;
        protected string name;
        protected int price;
        public int Price => price; //프로퍼티 //밖에서 불러오는건 되지만, 가격세팅은 안됨
        public Toy()
        {
            Random random = new Random();
            price = random.Next(10, 100) * 100;
        }
        public Toy(int val)
        { 
        }
        public Toy(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"이 장난감의 이름은 {name}이고, 가격은 {price}입니다");
        }
    }
    class Ball : Toy 
    {
        public Ball() :base()
        {
            name = "공";
            toyType = ToyType.Ball;
        }
        public Ball(string name, int price) : base(  name, price )
        {
            toyType = ToyType.Ball;
        }
        public void BallPop()
        {
            Console.WriteLine("공이 통통튑니다");
        }
    }
    class Doll : Toy
    {
        public Doll():base()
        {
            name = "인형";
            toyType = ToyType.Doll;
        }
        public Doll(string name, int price) : base(name, price)
        {
            toyType = ToyType.Doll;
        }
        public void Speak()
        {
            Console.WriteLine("소리나는 인형입니다");
        }
    }
    class Car : Toy
    {
        public Car() :base()
        {
            name = "차";
            toyType = ToyType.Car;
        }
        public Car(string name, int price) : base(name, price)
        {
            toyType = ToyType.Car;
        }
        public void CarRun()
        {
            Console.WriteLine("차가 달립니다");
        }
    }
    class Robot : Toy
    {
        public Robot( ) :base()
        {
            toyType = ToyType.Robot;
            name = "로봇";
        }
        public Robot(string name, int price) : base(name, price)
        {
            toyType = ToyType.Robot;
        }
        public void Transforming()
        {
            Console.WriteLine("로봇이 변신합니다");
        }
    }

    class Program
    {
        static Toy GetRandomNewToy() //업캐스팅 해서 돌려줌
        {
            Random random = new Random();
            ToyType toytype = (ToyType)random.Next(0, (int)ToyType.End);
            //Toytype은 (int)로 명시적 형변환이 가능함...
            //random.Next() ==> 정수를 반환함. 정수에 (ToyType)으로 명시적 형변환이 가능함

            switch (toytype)
            {
                case ToyType.Ball:
                    //Toy toy = new Ball(); //이것과 같음
                    //Parent child_p = new Child(); //요 샘플과 같음

                    return new Ball();
                    
                case ToyType.Doll:
                    return new Doll();
                case ToyType.Car:
                    return new Car();
                case ToyType.Robot:
                    return new Robot();                       
               
                default:                     
                    return null;//new Toy();
            }
        }
        static void Main(string[] args)
        {
            int totalPrice = 0;
            while (true) //무한 반복하여 시행가능..
            {
                Console.WriteLine("가챠를 뽑을 횟수를 입력해주세요");
                if (int.TryParse(Console.ReadLine(), out int count))
                {
                    totalPrice = 0;
                    Toy[] toy = new Toy[count]; //내가 가챠 뽑은 모든 장난감 가지고 있을 준비 완료
                    //정상적인 횟수입력
                    for (int i = 0; i < count; i++)
                    {
                        toy[i] = GetRandomNewToy(); //랜덤으로 생성한 장난감, 업캐스팅하여 Toy상태인 클래스
                        totalPrice += toy[i].Price; //가격불러오기
                        Console.Write((i+1) +"번째 장난감 : ");
                        toy[i].ShowInfo(); //정보 보여주기
                    }

                    Console.WriteLine("내용물을 확인하여, 각 장난감의 고유능력을 실행합니다");

                    for (int i = 0; i < count; i++)
                    {
                        switch (toy[i].toyType)
                        {
                            case ToyType.Ball:
                                (toy[i] as Ball).BallPop();
                                break;
                            case ToyType.Doll:
                                (toy[i] as Doll).Speak();
                                break;
                            case ToyType.Car:
                                (toy[i] as Car).CarRun();
                                break;
                            case ToyType.Robot:
                                (toy[i] as Robot).Transforming();
                                break;
                            
                            default:
                                Console.WriteLine("잘못된 형식의 토이타입 입니다");
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 프로그램을 종료합니다");
                    return;
                }
            }            
        }
    }