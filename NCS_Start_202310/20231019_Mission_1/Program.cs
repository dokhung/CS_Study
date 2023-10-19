/*
 * 가챠뽑기
 * 장난감 가챠를 n회 진행횝니다. n회는 입력받기
 * n회의 장난감 뽑기를 진행한 후,
 * 해당 장난감들의 모든 가격을 더해 얼망니지 알아야하고, 장난감을 하나씩 오픈하여 뭔지 확인하고 싶습니다.
 * => 각 장난감은 고유기능을 알려주는 함수가 있고, 어떤 이름의 얼마짜리 장난감인지 알려주ㅡ는 함수가 있습니다.
 *
 * 장난감 ( 가장 상위 부모 클래스)
 * 장난감의 이름, 가격 욧소가 반드시 있어야함
 * 장난감 부모 클래스를 상속받은 장난감 자식 클래스가 최소 3개이상 있어야 하고 클래스이름이나 장난감 이름, 가격은 자율 입니다.
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _20231019_Mission_1
{
    enum ToyType
    {
        /*
         * 3 types of toys
         */
        ToyDoll,
        ToyCar,
        ToyGun,
        ToyBoll,
        End
    }
    class Toy
    {
        public ToyType toyType = ToyType.End;  // Local 
        protected string name;
        protected int price;

        public int Price => price;  // 프로퍼티 // 밖에서 불러오는건 되지만, 가격세팅은 안됨 

        public Toy()
        {
            Random random = new Random();
            price = random.Next(10, 100) * 100;
        }

        public Toy(int val)
        {
            // ?
        }
        
        public Toy(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public void GetInfo()
        {
            Console.WriteLine($"이 장난감의 이름은{name}이고 가격은 {Price} 입니다.");
        }
    }

    class ToyDoll : Toy
    {
        public ToyDoll() : base()
        {
            name = "인형";
            toyType = ToyType.ToyDoll;
        }

        public ToyDoll(string name, int price) : base(name, price)
        {
            toyType = ToyType.ToyDoll;
        }

        public void OnSpeak()
        {
            Console.WriteLine("소리");
        }
    }

    class ToyCar : Toy
    {
        public ToyCar() : base()
        {
            name = "차";
            toyType = ToyType.ToyCar;
        }
        public ToyCar(string name, int price) : base(name, price)
        {
            toyType = ToyType.ToyCar;
        }

        public void OnDash()
        {
            Console.WriteLine("차가 달립니다.");
        } 
    }
    
    class ToyGun : Toy
    {
        public ToyGun() : base()
        {
            name = "총";
            toyType = ToyType.ToyGun;
        }

        public ToyGun(string Name, int Price) : base(Name, Price)
        {
            toyType = ToyType.ToyGun;
        }

        public void OnShot()
        {
            Console.WriteLine("비비탄이 나갑니다.");
        } 
    }
    
     class ToyBoll : Toy
    {
        public ToyBoll() : base()
        {
            name = "공";
            toyType = ToyType.ToyBoll;
        }
       

        public ToyBoll(string Name, int Price) : base(Name, Price)
        {
            toyType = ToyType.ToyBoll;
        }

        public void OnRoll()
        {
            Console.WriteLine("공이 굴러갑니다.");
        } 
    }
    internal class Program
    {
        public static Toy GetRandomGhcha()
        {
            Random random = new Random();
            ToyType toyType = (ToyType)random.Next(0, (int)ToyType.End);

            switch (toyType)
            {
                case ToyType.ToyDoll:
                    return new ToyDoll();
                    break;
                case ToyType.ToyCar:
                    return new ToyCar();
                    break;
                case ToyType.ToyGun:
                    return new ToyGun();
                    break;
                case ToyType.ToyBoll:
                    return new ToyBoll();
                    break;
                default:
                    return null;
            }
        }
        
        public static void Main(string[] args)
        {
            int total = 0;
            
            while (true)
            {
                Console.WriteLine("장난감 뽑기");
                Console.Write("몇회를 진행 하실래요?");
                int num = 0;
                ToyBoll toyBoll = new ToyBoll("Boll",5000);
                ToyGun toyGun = new ToyGun("Gun", 20000);
                ToyCar toyCar = new ToyCar("Car", 10000);
                if (num == int.Parse(Console.ReadLine()))
                {
                    total = 0;
                    Toy[] toys = new Toy[num];
                    for (int i = 0; i < num; i++)
                    {
                        toys[i] = GetRandomGhcha();
                        total += toys[i].Price;
                        Console.Write((i+1));
                        toys[i].GetInfo();
                    }

                    Console.WriteLine("내용물 확인후, 장난감의 고유 함수 실행");

                    for (int i = 0; i < num; i++)
                    {
                        switch (toys[i].toyType)
                        {
                            
                        }
                    }
                }
                
            }
        }
    }
}