using System;
using System.Collections.Generic;
//using System.Text;
//using ExtensionMethods; //확장메서드 사용용...

namespace NCS_Start_202310
{
    //플레이어 존재. => 플레이어 이름, 공격력, HP, 

    //간이 인벤토리 실습... 

    //플레이어가 아이템을 들고 있는데, 랜덤개수만큼 랜덤하게 들고있고... 

    //=> 보유 아이템 종류/ 개수 먼저 보여주기...

    //아이템클래스 == 아이템 종류 , 아이템 사용하기...(사용하면 사용했다고 출력으로 알려주기)

    //무슨아이템을 사용하겠다 하면 이제 아이템 사용하고 (플레이어 보유 아이템에서 삭제 )  //
    //뭔가 사용했다는 표시 출력도하고..

    //부모클래스 Item이 있겠죠...
    //Item클래스를 상속받는 자식클래스 아이템 3종이상 만들고
    //아이템 사용하기..

    //공격력 증가포션 (공격력을 올림) / 방어구(최대 HP를 올림) / 포션 (현재 HP를 올림...) / 
    //enum 내가 지정한 데이터 형식...
    public enum ItemType
    {
        Sword,
        Armor,
        Potion,
        //후에 아이템이 추가된다면 End앞에 추가할 것. 그래야 ItemType.End는 항상 마지막, 타입의 총 개수를 표현할 수 있다        

        End
    }
    struct Info
    {
        public int att; //선언과 동시에 초기화가 불가능
        public int hp /*= 0*/;
        public int maxhp /*= 0*/;
        public Info(int att, int hp)
        {
            this.att = att;
            this.hp = hp;
            maxhp = hp;
        }
        public Info(Info _info)
        {
            this.att = _info.att;
            this.hp = _info.hp;
            maxhp = _info.hp;
        }
    }
    class Player
    {
        string name = "";
        public Info info;

        List<Item> itemList = new List<Item>();

        public Player(string name, Info _info)
        {
            this.name = name;
            info = _info;
        }

        public void ShowPlayerInfo() //플레이어 정보 출력..
        {
            Console.WriteLine($"플레이어의 이름은 {name}이고,\n" +
                $"공격력은 {info.att}이고,\n체력은 {info.hp} / {info.maxhp} 상태 입니다\n");
        }
        public void ShowItemList()
        {
            for (int i = 0; i < itemList.Count; i++)
            {
                itemList[i].ShowItemInfo();
            }
        }
        public void AddItem(Item item)
        {
            if (item != null)
                itemList.Add(item);
        }

        public void UseItem()
        {
            if (itemList.Count == 0)
            {
                Console.WriteLine("소지한 아이템이 없습니다");
                return;
            }
            //1번방법
            //info = itemList[0].UseItem(info);

            //2번방법  ==> 차라리 1번방법 사용할것          
            //itemList[0].UseItem(info, out Info _info);
            //info = _info;
            //3번방법
            itemList[0].UseItem(this);
        }
    }

    abstract class Item //아이템의 부모..
    {
        public ItemType itemtype = ItemType.End;
        protected Info info = new Info(); // 전부 디폴트 내용으로 세팅해줌.. 

        //public Item(Info info)
        //{
        //    this.info = info;
        //}

        public void ShowItemInfo()
        {
            switch (itemtype)
            {
                case ItemType.Sword:
                    Console.WriteLine("이 아이템은 검으로, " + info.att + "의 공격력을 높여줍니다");
                    break;
                case ItemType.Armor:
                    Console.WriteLine("이 아이템은 방어구로, " + info.maxhp + "의 최대체력을 높여줍니다");
                    break;
                case ItemType.Potion:
                    Console.WriteLine("이 아이템은 물약으로, " + info.hp + "의 체력을 회복시킵니다");
                    break;
            }
        }

        public abstract Info UseItem(Info Playerinfo); //구조체를 받아서 구조체를 넘기는 방식
        public abstract void UseItem(Info Playerinfo, out Info afterInfo); //구조체를 받아서 구조체를 넘기는 방식
        public abstract void UseItem(Player Playerinfo); //클래스를 매개변수로 받는 형식
    }
    class Sword : Item
    {
        public Sword()
        {
            itemtype = ItemType.Sword;
        }
        public Sword(int att)
        {
            itemtype = ItemType.Sword;
            info.att = att;
        }

        public override Info UseItem(Info Playerinfo)
        {
            Playerinfo.att += info.att;
            return Playerinfo;
        }
        public override void UseItem(Info Playerinfo, out Info afterInfo)
        {
            //1번방법
            //afterInfo = new Info(Playerinfo);
            //afterInfo.att += info.att;

            //2번방법
            afterInfo = new Info();
            afterInfo.att = Playerinfo.att + info.att;
            afterInfo.hp = Playerinfo.hp;
            afterInfo.maxhp = Playerinfo.maxhp;
        }
        public override void UseItem(Player Playerinfo)
        {
            Playerinfo.info.att += info.att;
        }
    }
    //class Armor : Item
    //{
    //    public Armor(int hp)
    //    {
    //        info.maxhp = hp;
    //    }
    //    public override Info UseItem(Info Playerinfo)
    //    {
    //    }
    //    public override void UseItem(Info Playerinfo, out Info afterInfo)
    //    { }
    //    public override void UseItem(Player Playerinfo)
    //    {
    //    }
    //}
    //class Potion : Item
    //{
    //    public Potion(int hp)
    //    {
    //        info.hp = hp;
    //    }
    //    public override Info UseItem(Info Playerinfo)
    //    {
    //    }
    //    public override void UseItem(Info Playerinfo, out Info afterInfo)
    //    { }
    //    public override void UseItem(Player Playerinfo)
    //    {
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("용사", new Info(7, 100));

            Item item = new Sword(10);

            player.AddItem(item);
            player.ShowPlayerInfo();
            player.ShowItemList();
            player.UseItem();

            player.ShowPlayerInfo();
        }
    }

    #region enum형식과 변수와 보호수준 
    //public enum ItemType
    //{
    //    Potion1,
    //    Potion2
    //}
    //class A
    //{
    //    public enum OtherType
    //    {
    //        Potion3,
    //        Potion4
    //    }
    //    protected enum AnotherProt //비추
    //    {
    //        Potion55,
    //        Potion66
    //    }
    //    private enum AnotherPriv //완전 비추
    //    {
    //        Potion111,
    //        Potion222
    //    }
    //    protected ItemType _type; //밖에 선언되어 어느 클래스든 동일하게 접근가능
    //    public OtherType _type2; //내 클래스안에서만 쓰이는 enum
    //    protected OtherType _type3; //내 클래스안에서만 쓰이는 enum

    //    public AnotherProt anotherprot_pub; //밖에서 anotherprot_pub 를 접근하고 싶어하는데, 막상 실제 그 형식은 접근 불가능함..
    //    protected AnotherProt anotherprot_prot;
    //    AnotherProt anotherprot_priv;

    //    public AnotherPriv anotherpriv_pub;
    //    protected AnotherPriv anotherpriv_prot;
    //    AnotherPriv anotherpriv_priv;
    //}

    //class AA: A 
    //{
    //    public AA()
    //    {
    //        _type2 = OtherType.Potion3;
    //        _type3 = OtherType.Potion4;

    //        anotherprot_pub = AnotherProt.Potion55;
    //        anotherprot_prot = AnotherProt.Potion66;
    //        anotherprot_priv = 접근불가
    //    }
    //}
    //class B
    //{
    //    ItemType _type; //밖에 선언되어 어느 클래스든 동일하게 접근가능
    //    OtherType _type2; //A클래스와 연관이없기 때문에 쓸수없음. 
    //    public B()
    //    {
    //        A a = new A();
    //        a._type2 = A.OtherType.Potion3; //

    //        a.anotherprot_pub = A.AnotherProt.접근불가..
    //    }
    //}

    #endregion

    #region 박싱과 언박싱. 대표적 데이터형식인 object. object 있지만, 최대한 안쓰는 것이 좋음...
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //object //참조타입.. 아무거나 다 담을 수 있음...
    //        int a = 5;
    //        object obj = a;

    //        A aa = new A();
    //        int b = 10;
    //        b += (int)obj;

    //        b += aa.a;


    //        List<object> AddListAnything = new List<object>();
    //        AddListAnything.Add(1);
    //        AddListAnything.Add("a");
    //        AddListAnything.Add('b');
    //        AddListAnything.Add(0.45f);

    //        object obje = 10;
    //        obje = 'a';

    //        var anything = 1;
    //        var bbb = 'd';
    //        anything = 2f;
    //        bbb = "a";

    //        double ccc = 0;
    //        var ccc2 = 0.000000000000;
    //        ccc2 = 10.5461321351;

    //    }
    //}
    #endregion

    #region 업캐스팅 다운캐스팅 실습
    //// 가챠뽑기
    //// 장난감 가챠를 n회 진행합니다 (n회는 입력받기)
    //// n회의 장난감 뽑기를 진행한 후,
    //// 해당 장난감들의 모든 가격을 더해 얼마인지 알아야하고, 장난감을 하나씩 오픈하여 뭔지 확인하고 싶습니다

    ////=> 각 장난감은 고유기능을 알려주는 함수가 있고,
    ////   어떤 이름의 얼마짜리 장난감인지 알려주는 함수가 있습니다. 

    ////ex) 장난감1 클래스에는 BallPop(){ "공이 통통 튑니다" } 라는 함수가 있다면
    ////      장난감2클래스에는 CarRun(){"차가달립니다"}같은 함수가 존재
    ////      공통 함수에는 GetInfo() {" 이 장난감의 이름은 ~~ 이고, ~~원입니다 "}


    ////장난감 (가장 상위 부모 클래스)
    //// 장난감의 이름, 가격 요소가 반드시 있어야함

    ////장난감 부모클래스를 상속받은 장난감 자식클래스가 최소 3개이상 있어야하고 클래스이름이나 장난감 이름, 가격은 자율입니다.

    //enum ToyType
    //{ 
    //    Ball,
    //    Doll,
    //    Car,
    //    Robot,

    //    End
    //}
    //class Toy
    //{
    //    public ToyType toyType = ToyType.End;
    //    protected string name;
    //    protected int price;
    //    public int Price => price; //프로퍼티 //밖에서 불러오는건 되지만, 가격세팅은 안됨
    //    public Toy()
    //    {
    //        Random random = new Random();
    //        price = random.Next(10, 100) * 100;
    //    }
    //    public Toy(int val)
    //    { 
    //    }
    //    public Toy(string name, int price)
    //    {
    //        this.name = name;
    //        this.price = price;
    //    }
    //    public void ShowInfo()
    //    {
    //        Console.WriteLine($"이 장난감의 이름은 {name}이고, 가격은 {price}입니다");
    //    }
    //}
    //class Ball : Toy 
    //{
    //    public Ball() :base()
    //    {
    //        name = "공";
    //        toyType = ToyType.Ball;
    //    }
    //    public Ball(string name, int price) : base(  name, price )
    //    {
    //        toyType = ToyType.Ball;
    //    }
    //    public void BallPop()
    //    {
    //        Console.WriteLine("공이 통통튑니다");
    //    }
    //}
    //class Doll : Toy
    //{
    //    public Doll():base()
    //    {
    //        name = "인형";
    //        toyType = ToyType.Doll;
    //    }
    //    public Doll(string name, int price) : base(name, price)
    //    {
    //        toyType = ToyType.Doll;
    //    }
    //    public void Speak()
    //    {
    //        Console.WriteLine("소리나는 인형입니다");
    //    }
    //}
    //class Car : Toy
    //{
    //    public Car() :base()
    //    {
    //        name = "차";
    //        toyType = ToyType.Car;
    //    }
    //    public Car(string name, int price) : base(name, price)
    //    {
    //        toyType = ToyType.Car;
    //    }
    //    public void CarRun()
    //    {
    //        Console.WriteLine("차가 달립니다");
    //    }
    //}
    //class Robot : Toy
    //{
    //    public Robot( ) :base()
    //    {
    //        toyType = ToyType.Robot;
    //        name = "로봇";
    //    }
    //    public Robot(string name, int price) : base(name, price)
    //    {
    //        toyType = ToyType.Robot;
    //    }
    //    public void Transforming()
    //    {
    //        Console.WriteLine("로봇이 변신합니다");
    //    }
    //}

    //class Program
    //{
    //    static Toy GetRandomNewToy() //업캐스팅 해서 돌려줌
    //    {
    //        Random random = new Random();
    //        ToyType toytype = (ToyType)random.Next(0, (int)ToyType.End);
    //        //Toytype은 (int)로 명시적 형변환이 가능함...
    //        //random.Next() ==> 정수를 반환함. 정수에 (ToyType)으로 명시적 형변환이 가능함

    //        switch (toytype)
    //        {
    //            case ToyType.Ball:
    //                //Toy toy = new Ball(); //이것과 같음
    //                //Parent child_p = new Child(); //요 샘플과 같음

    //                return new Ball();

    //            case ToyType.Doll:
    //                return new Doll();
    //            case ToyType.Car:
    //                return new Car();
    //            case ToyType.Robot:
    //                return new Robot();                       

    //            default:                     
    //                return null;//new Toy();
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        int totalPrice = 0;
    //        while (true) //무한 반복하여 시행가능..
    //        {
    //            Console.WriteLine("가챠를 뽑을 횟수를 입력해주세요");
    //            if (int.TryParse(Console.ReadLine(), out int count))
    //            {
    //                totalPrice = 0;
    //                Toy[] toy = new Toy[count]; //내가 가챠 뽑은 모든 장난감 가지고 있을 준비 완료
    //                //정상적인 횟수입력
    //                for (int i = 0; i < count; i++)
    //                {
    //                    toy[i] = GetRandomNewToy(); //랜덤으로 생성한 장난감, 업캐스팅하여 Toy상태인 클래스
    //                    totalPrice += toy[i].Price; //가격불러오기
    //                    Console.Write((i+1) +"번째 장난감 : ");
    //                    toy[i].ShowInfo(); //정보 보여주기
    //                }

    //                Console.WriteLine("내용물을 확인하여, 각 장난감의 고유능력을 실행합니다");

    //                for (int i = 0; i < count; i++)
    //                {
    //                    switch (toy[i].toyType)
    //                    {
    //                        case ToyType.Ball:
    //                            (toy[i] as Ball).BallPop();
    //                            break;
    //                        case ToyType.Doll:
    //                            (toy[i] as Doll).Speak();
    //                            break;
    //                        case ToyType.Car:
    //                            (toy[i] as Car).CarRun();
    //                            break;
    //                        case ToyType.Robot:
    //                            (toy[i] as Robot).Transforming();
    //                            break;

    //                        default:
    //                            Console.WriteLine("잘못된 형식의 토이타입 입니다");
    //                            break;
    //                    }
    //                }
    //            }
    //            else
    //            {
    //                Console.WriteLine("잘못된 입력입니다. 프로그램을 종료합니다");
    //                return;
    //            }
    //        }            
    //    }
    //}

    #endregion

    #region 형변환 관련 수업내용
    //class Program
    //{
    //    enum ItemType
    //    { 
    //        WEAPON, //==0
    //        ARMOR, //==1
    //        POTION, //==2

    //        END //==3
    //    }
    //    static void Main(string[] args)
    //    {
    //        #region 클래스의 형변환
    //        Parent parent = new Parent(); //Parent 형식을 담는 내용물도 Parent...

    //        Child child = new Child();
    //        Child2 child2 = new Child2();

    //        Parent child_p = new Child(); //업캐스팅... Parent .. 형식을 Parent로 활용하긴할건데... 실제 내용물은 Child

    //        //parent.parentInt = 1;
    //        //parent.ParentFunc();
    //        ////parent.childfunc(); //접근 불가

    //        ////상속받았고, 해당 기능이 public이기 때문에 밖에서도 접근 가능..
    //        //child.parentInt = 1;
    //        //child.ParentFunc();
    //        //child.childStr = "dd";
    //        //child.ChildFunc();

    //        ////Parent tmpParent;
    //        ////tmpParent = child;

    //        ////Child tmpChild; //큰쪽에다가 
    //        ////tmpChild = parent; //작은걸 넣을 수 없다...

    //        //====================== as와 다운캐스팅의 재확인
    //        //Child childTmp;
    //        //childTmp = parent as Child; //as키워드는 형변환 실패시 null을 반환하고, 성공시 바꾼 클래스를 반환한다.
    //        //if (childTmp == null)
    //        //{
    //        //    Console.WriteLine("Parent형식의 parent는 Child로 다운캐스팅 불가능 합니다");
    //        //}
    //        //else
    //        //{
    //        //    Console.WriteLine("Parent형식의 parent는 Child로 다운캐스팅 가능 합니다");
    //        //}

    //        //childTmp = child_p as Child;
    //        //if (childTmp == null)
    //        //{
    //        //    Console.WriteLine("Parent형식의 child_p는 Child로 다운캐스팅 불가능 합니다");
    //        //}
    //        //else
    //        //{
    //        //    Console.WriteLine("Parent형식의 child_p는 Child로 다운캐스팅 가능 합니다");
    //        //}

    //        //========================== as와 is의 사용

    //        //Console.WriteLine("child_p는 Parent형식의 Child 입니다.");

    //        //Console.WriteLine("child_p 를 Child 본래 형식으로 다운캐스팅을 시도합니다.");
    //        //(child_p as Child).ChildFunc(); //에러는 안남.. 빨간줄은 안남                        

    //        //Console.WriteLine("child_p 를 Child2 형식으로 다운캐스팅을 시도합니다.");
    //        //if (child_p is Child2)
    //        //{
    //        //    (child_p as Child2).Child2Func(); //에러는 안남.. 빨간줄은 안남
    //        //}
    //        //else
    //        //{
    //        //    Console.WriteLine("child_p는 Child2 형식으로 바꿀 수 없습니다");
    //        //}

    //        //==========================
    //        //switch (child_p.familyType) //family type으로 판별해서 문제없이 업캐스팅 / 다운캐스팅이 가능...
    //        //{
    //        //    case FamilyType.Parent:
    //        //        (child_p as Parent).하고싶은거 함  //가능
    //        //        break;
    //        //    case FamilyType.Child:
    //        //        (child_p as Child).하고싶은거~  //가능
    //        //        break;
    //        //    case FamilyType.Child2:
    //        //        (child_p as Child2)  //가능
    //        //        break;

    //        //    default:
    //        //        break;
    //        //}


    //        #endregion

    //        #region 명시적형변환
    //        ////자료형.parse()
    //        ////자료형.TryParse()
    //        ////Convert.데이터형식 바꾸기 가능

    //        ////enum은 숫자로도 쓸수있고, 문자열로 바로 바꿀수도있음.. 그렇게 쓰려면 명시적 변환 필요

    //        //ItemType itemtype = ItemType.END;
    //        //Console.WriteLine("itemtype.ToString() : " + itemtype.ToString());
    //        //Console.WriteLine("(int)itemtype : " + (int)itemtype);

    //        //itemtype = ItemType.WEAPON;
    //        //Console.WriteLine("itemtype.ToString() : " + itemtype.ToString());
    //        //Console.WriteLine("(int)itemtype : " + (int)itemtype);
    //        #endregion
    //        #region 묵시적형변환
    //        //int intvalue = 0;
    //        //float floatvalue = 0f;

    //        //floatvalue = intvalue;

    //        //intvalue = floatvalue; //int 보다 float범위가 크기 떄문에 float을 작은 int안에 넣을 수는 없음

    //        //double doublevalue = 0;

    //        //doublevalue = floatvalue;
    //        //floatvalue = doublevalue; //float 보다 double의 범위가 크기 때문에 double을 float안에 넣을 수 없음

    //        //doublevalue = intvalue; //int는 float보다 작고, float은 double보다 작기때문에 int는 충분히 double안에 들어감

    //        //Console.WriteLine("문자열에 정수더하기, 실수더하기 등등 다 가능 " + 5 + 1.354f);

    //        #endregion
    //    }

    //    static Parent GetParentsClass(FamilyType type)
    //    {
    //        switch (type)
    //        {
    //            case FamilyType.Parent:
    //                return new Parent();                    

    //            case FamilyType.Child:
    //                return new Child();

    //            case FamilyType.Child2:
    //                return new Child2();

    //            default:
    //                return new Parent();                    
    //        }
    //    }
    //}

    //enum FamilyType
    //{ 
    //    Parent,
    //    Child,
    //    Child2,

    //    End
    //}

    //class Parent //자식과는 사실 상관없어요..
    //{
    //    public FamilyType familyType = FamilyType.Parent;
    //    public int parentInt;
    //    public void ParentFunc()
    //    { }
    //}

    //class Child : Parent
    //{        
    //    public string childStr;
    //    public Child()
    //    {
    //        familyType = FamilyType.Child;
    //    }
    //    public void ChildFunc()
    //    {
    //        Console.WriteLine("Child의 고유 기능입니다");
    //    }
    //}
    //class Child2 : Parent
    //{
    //    public float child2Float;
    //    public Child2()
    //    {
    //        familyType = FamilyType.Child2;
    //    }
    //    public void Child2Func()
    //    {
    //        Console.WriteLine("Child22222의 고유 기능입니다");
    //    }
    //}
    #endregion
}