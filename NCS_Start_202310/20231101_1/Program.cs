using System;
using System.Collections.Generic;

  public enum ClothesType
    {
        Top,
        Bottom,
        Cap,
        Accessories,

        End
    }

    interface IWear
    {
        void Wearing();
    }

    public abstract class Clothes
    {
        public ClothesType type { get; protected set; } = ClothesType.End;
        protected int price = 0;
        public int Price => price; //밖에서 내 변수 price를 가져오는건 안되고 price의 값을 가져오는 것은 됨.

        //public int price { get; protected set; } = 0;

        protected string name = ""; //옷의 이름.

        public Clothes(string name)
        {
            this.name = name;
        }

        public int GetPrice()
        {
            return price;
        }
        public abstract void GetInfo();     //abstract 반드시 너가 구현해야할 함수.
        public virtual void Tips()          //자식단에서 재정의를 허락함...
        {
            Console.WriteLine("유행상품입니다");
        }
    }
    public class Top : Clothes, IWear
    {
        public Top(int price, string name) : base(name)
        {
            type = ClothesType.Top;
            this.price = price;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"이 상의는 {name}으로, {price}원 입니다");
        }

        public void Wearing()
        {
            Console.WriteLine("이 상의는 착용 가능합니다");
        }
    }
    public class Bottom : Clothes, IWear
    {
        public Bottom(int price, string name) : base(name)
        {
            type = ClothesType.Bottom;
            this.price = price;
        }
        public override void GetInfo()
        {
            Console.WriteLine($"이 하의는 {name}으로, {price}원 입니다");
        }
        public void Wearing()
        {
            Console.WriteLine("이 하의는 착용 가능합니다");
        }
    }
    public class Cap : Clothes, IWear
    {
        public Cap(int price, string name) : base(name)
        {
            type = ClothesType.Cap;
            this.price = price;
        }
        public override void GetInfo()
        {
            Console.WriteLine($"이 모자는 {name}으로, {price}원 입니다");
        }
        public void Wearing()
        {
            Console.WriteLine("이 모자는 착용 가능합니다");
        }
    }
    public class Accessories : Clothes
    {
        public Accessories(int price, string name) : base(name)
        {
            type = ClothesType.Accessories;
            this.price = price;
        }
        public override void GetInfo()
        {
            Console.WriteLine($"이 악세사리는 {name}으로, {price}원 입니다");
        }
    }

    public class Owner
    {
        Dictionary<ClothesType, List<Clothes>> AllMyClothes = new Dictionary<ClothesType, List<Clothes>>();

        Clothes CreateClothes(int num)
        {
            Random random = new Random();
            Clothes clothes;
            ClothesType type = (ClothesType)random.Next(0, (int)ClothesType.End);

            switch (type)
            {
                case ClothesType.Top:
                    clothes = new Top(random.Next(10, 51) * 100, type.ToString() + num);
                    break;
                case ClothesType.Bottom:
                    clothes = new Bottom(random.Next(10, 51) * 100, type.ToString() + num);
                    break;
                case ClothesType.Cap:
                    clothes = new Cap(random.Next(10, 51) * 100, type.ToString() + num);
                    break;
                case ClothesType.Accessories:
                    clothes = new Accessories(random.Next(10, 51) * 100, type.ToString() + num);
                    break;
                default:
                    clothes = null;
                    break;
            }
            return clothes;
        }

        public void SetMyAllClothes()
        {
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(2);
            list.Add(2);
            list.Add(2);

            Clothes clothes;
            for (int i = 0; i < 10; i++)
            {
                clothes = CreateClothes(i + 1);
                if (AllMyClothes.ContainsKey(clothes.type))
                {
                    AllMyClothes[clothes.type].Add(clothes); //딕셔너리의 특정키 의 값 == 해당 리스트 == 해당타입의 리스트에 내용을 더함.
                }
                else
                    AllMyClothes.Add(clothes.type, new List<Clothes>() { clothes });     //딕셔너리에 키와 값을 더함.   
            }
        }

        public void ShowAllMyClothes()
        {
            Console.WriteLine("내가 가진 모든 옷 정보 보여주기.");
            foreach (var item in AllMyClothes)
            {
                for (int i = 0; i < item.Value.Count; i++)
                {
                    item.Value[i].GetInfo();
                }
            }
        }

        public bool AskIsEnableWearing(Clothes cloth) //cloth를 입어도 되는지 여부를 손님이 물었다고 쳤을때 
        {
            if (cloth is IWear)
            {
                IWear wear = cloth as IWear;
                wear.Wearing();
                return true;
            }
            else
            {
                //Iwear 요소가 없다면... 
                //일단 우리는 악세사리인걸 알수있고
                //악세사리거나 말거나
                Console.WriteLine("착용하실 수 없습니다");
                return false;
            }
        }

        public Clothes PickOneClothes(ClothesType type) //상의인지 하의인지... 타입만 매개변수로 주면 뭔가 랜덤한 옷을 들려줌.
        {
            if (AllMyClothes.ContainsKey(type))
            {
                Random random = new Random();
                return AllMyClothes[type][random.Next(0, AllMyClothes[type].Count)];
            }
            else
            {
                Console.WriteLine("죄송합니다. 해당 타입 옷은 품절입니다.");
                return null;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner(); //오너생성
            owner.SetMyAllClothes(); //주인의 가진 옷들 세팅

            Console.WriteLine("주인이 가진 옷 출력");

            owner.ShowAllMyClothes(); //주인이 가진 옷들 전부 한번 보기

            Clothes cloth = null;
            ClothesType type = ClothesType.Top;
            while (cloth == null)
            {
                Console.WriteLine(type + "타입의 옷 랜덤으로 하나 고르기");
                cloth = owner.PickOneClothes(type);
                type++;
            }

            if (owner.AskIsEnableWearing(cloth))
            {
                Console.WriteLine("착용 가능하다니 입어보겠습니다");
            }
            else
            {
                Console.WriteLine("착용이 불가능 하군요... ");
            }
        }
    }