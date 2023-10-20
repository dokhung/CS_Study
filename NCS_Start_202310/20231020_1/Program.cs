using System;
using System.Collections.Generic;
using System.Text;

namespace NCS_Start_20231020
{
    #region 실습3
    ////애플 제품은, 해당 제품이 애플사 제품일 때에만 가능한 서비스들이 있음

    ////아이폰  == string 애플계정, 애플로그인이 가능, 인터넷사용, 통화, IOS 앱을 사용
    ////맥      == string 애플계정, 애플로그인이 가능, 인터넷사용, 데스크탑 앱 사용
    ////아이패드 == string 애플계정, 애플로그인이 가능, 인터넷사용, IOS 앱을 사용하고, 펜슬 가능..

    ////이 개념들을 구현하기....
    ////====================    
    //// 공통점을.. 애플이라는 상위 클래스로 묶거나 /  ==>>>>  인터페이스를 사용하기..
    ////=================
    ////갤럭시의 경우..
    ////갤럭시     == string 삼성계정, 삼성로그인이 가능하며, 인터넷 사용 , 통화하고  안드로이드 앱을사용..
    ////삼성노트북 ==
    ////갤럭시탭   ==
    ////======================================================================
    //enum Company
    //{
    //    Apple,
    //    Samsung,
    //    //Shaomi,

    //    End
    //}

    //struct ForLoginInfo
    //{
    //    public Company companyType;
    //    public string ID;
    //}
    //interface IAllLoginFunc //인터페이스의 목적을 좀 명시적으로.. 표현하는 용..
    //{
    //    void Login(ForLoginInfo _info); //해당 회사에 관련된 로그인임...        
    //    void UseApp();
    //    void UseInternet();
    //}

    //interface IPhone
    //{
    //    void Call();
    //}
    //interface IPad
    //{
    //    void UsePencil();
    //}

    //class Samsung : IAllLoginFunc
    //{
    //    public ForLoginInfo info;

    //    public void Login(ForLoginInfo _info)
    //    {
    //        //info.~
    //    }

    //    public void UseApp()
    //    {            
    //    }

    //    public void UseInternet()
    //    {            
    //    }
    //}

    //class SamsungPhone : Samsung, IPhone
    //{
    //    public void Call()
    //    {            
    //    }
    //}

    //class Apple
    //{
    //    public ForLoginInfo info;
    //}

    #endregion

    #region 실습문제2. 승객들이 버스타기.
    ////당신은 버스기사입니다. 버스에 승객이 탑니다. 
    ////승객은 나이 (랜덤) 1 ~ 90 살 이고, 돈(랜덤 == 0  ~ 최대 5000원. 10원단위 )  을 가지고 있습니다.

    ////아동의 나이 기준은 10세 이하 이고 어른 이용가의 30퍼를 지불합니다
    ////청소년의 나이기준은 11세 이상 20세 미만 이고, 어른 이용가의 70퍼를 지불합니다
    ////성인의 나이 기준은 60세 미만입니다
    ////그 이상은 노인이며, 비용을 지불하지 않습니다.

    ////버스 요금은 2000원입니다.

    ////승객이 랜덤으로 10명 탑승했을때, 각각의 승객이 아동인지, 청소년인지, 성인인지 노인인지 여부를 출력하고
    ////버스기사가 받을 총 금액을 출력합니다

    ////단, 승객이 지불할 돈이 없다면, 못타고 다음 승객이 탑니다. => 총 탑승해야 하는 인원은 10명이고,
    ////만약 중간에 돈이 부족했다면, 10명보다 많은 사람이 타려고 했던 것이 됨...    

    //class Program
    //{ 
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("이 버스는 최대 10명을 태울 수 있는 버스입니다");
    //        Bus bus = new Bus();  //존재
    //        Passenger passenger; //임시변수
    //        while (bus.passengerCount < 10)
    //        {
    //            Console.WriteLine("\n승객이 탑승을 시도합니다\n");
    //            passenger = Passenger.GetPassenger(); //승객 생성
    //            if (bus.AddPassenger(passenger.passengerType, passenger.money, out int change)  == false)
    //            {
    //                passenger.ShowPassengerInfo(); 
    //                Console.WriteLine("탑승객의 소지금이 부족하여 탑승하지 못하였습니다");
    //                continue;
    //            }

    //            passenger.SetChange(change); //승객의 돈을 거스름돈으로 바꿔줌. 전체돈을 가져갔었고, 전체돈- 내야할돈 해서 change로 돌려받았음

    //            //그렇게 탑승하게된 탑승객의 정보 보여줌
    //            passenger.ShowPassengerInfo();

    //            Console.WriteLine("현재 탑승객은 " + bus.passengerCount + "명입니다\n");
    //        }
    //    }
    //}

    //class Bus
    //{
    //    int[] priceArr = new int[(int)PassengerType.End] { (int)(2000 * 0.3f), (int)(2000 * 0.7f), 2000, 0 };
    //    public int passengerCount { get; private set; } = 0;
    //    int money = 0;                

    //    public int GetPrice(PassengerType _type) //해당 타입의 승객이 내야할 돈 반환
    //    {
    //        return priceArr[(int)_type]; 
    //    }

    //    public bool AddPassenger(PassengerType _type, int money, out int change )
    //    {
    //        change = money; /*승객 돈의 전부*/
    //        if (money < priceArr[(int)_type])
    //        {
    //            return false;
    //        }
    //        else
    //        {
    //            this.money += priceArr[(int)_type];
    //            passengerCount++;
    //            change -= priceArr[(int)_type]; //승객에게 돌려줄돈

    //            return true;
    //        }
    //    }
    //}

    //public enum PassengerType
    //{ 
    //    Child,
    //    Teen,
    //    Adult,
    //    Old,

    //    End
    //}
    //class Passenger //하나만 선언해서 쓰는방법
    //{
    //    public PassengerType passengerType { get; protected set; } = PassengerType.End;
    //    protected int age = 0;
    //    public int money { get; protected set; } = 0;

    //    public static Passenger GetPassenger()
    //    {
    //        Random random = new Random();
    //        PassengerType _type = (PassengerType)random.Next(0, (int)PassengerType.End);
    //        switch (_type)
    //        {
    //            case PassengerType.Child:
    //                return new Child();                    
    //            case PassengerType.Teen:
    //                return new Teen();
    //            case PassengerType.Adult:
    //                return new Adult();
    //            case PassengerType.Old:
    //                return new Old();
    //            default:
    //                return null; //new Passenger()
    //        }
    //    }
    //    public void ShowPassengerInfo()
    //    {
    //        switch (passengerType)
    //        {
    //            case PassengerType.Child:
    //                Console.Write("어린이 승객입니다.");
    //                break;
    //            case PassengerType.Teen:
    //                Console.Write("청소년 승객입니다.");
    //                break;
    //            case PassengerType.Adult:
    //                Console.Write("성인 승객입니다.");
    //                break;
    //            case PassengerType.Old:
    //                Console.Write("노인 승객입니다.");
    //                break;
    //            default:
    //                break;
    //        }
    //        Console.WriteLine("\t" + money + "원을 소지중입니다");
    //    }

    //    public void SetChange(int change)
    //    {
    //        money = change;
    //    }
    //}

    //class Child : Passenger
    //{
    //    public Child()
    //    {
    //        Random random = new Random();
    //        passengerType = PassengerType.Child;
    //        this.age = random.Next(1, 11);
    //        this.money = random.Next(0, 500) * 10;
    //    }
    //}
    //class Teen : Passenger
    //{
    //    public Teen()
    //    {
    //        Random random = new Random();
    //        passengerType = PassengerType.Teen;
    //        this.age = random.Next(11, 20);
    //        this.money = random.Next(0, 500) * 10;
    //    }
    //}
    //class Adult : Passenger
    //{
    //    public Adult()
    //    {
    //        Random random = new Random();
    //        passengerType = PassengerType.Adult;
    //        this.age = random.Next(20, 60);
    //        this.money = random.Next(0, 500) * 10;
    //    }
    //}
    //class Old : Passenger
    //{
    //    public Old()
    //    {
    //        Random random = new Random();
    //        passengerType = PassengerType.Old;
    //        this.age = random.Next(60, 91);
    //        this.money = random.Next(0, 500) * 10;
    //    }
    //}
    #endregion

    #region 어제 실습 다시 살펴보기
    //public enum ItemType
    //{
    //    Sword,
    //    Armor,
    //    Potion,

    //    End
    //}

    //struct Info
    //{
    //   public string name ; //이름
    //    public int att; //공격력
    //    public int hp;
    //    public int maxhp;//HP / MaxHP
    //    //구조체도 생성자 가능.. 단 기본생성자 내가 지정하는건 안됨       
    //    //public Info(string name) //만약 다른데서도 info생성자로 랜덤요소 채워서 바로 갖고싶다면 여기 만들면 될것...
    //    //{
    //    //    Random random = new Random();
    //    //    this.name = name;
    //    //    att = random.Next(1, 10);
    //    //    hp = random.Next(10, 20) * 100;
    //    //    maxhp = hp;
    //    //}
    //    public void ShowInfo()
    //    {
    //        StringBuilder strbuilder = new StringBuilder();
    //        strbuilder.Append($"========================\n이름 : {name}\n");
    //        if (att > 0)
    //        {
    //            strbuilder.Append($"공격력 : {att}\n");
    //        }
    //        if (hp > 0)
    //        {
    //            strbuilder.Append($"현재체력 : {hp}\n");
    //        }
    //        if (maxhp > 0)
    //        {
    //            strbuilder.Append($"최대체력 : {maxhp}\n");
    //        }
    //        strbuilder.Append("========================\n");

    //        Console.WriteLine(strbuilder.ToString());
    //    }
    //}

    //class Player
    //{
    //    //string name = ""; //이름
    //    //int att; //공격력
    //    //int hp;
    //    //int maxhp;//HP / MaxHP
    //    public Info info; 
    //    List<Item> itemlist = new List<Item>(); //플레이어의 가방인셈. 플레이어가 가진 아이템의 목록을 변수로 선언함...
    //    //Item[] itemArr = new Item[(int)ItemType.End]; //아이템 종류별로 들어갈 배열 선언..아이템 개수는 아이템 클래스에서 관리함..


    //    ////플레이어의 아이템 목록 선언하는 방법
    //    //각각의 아이템이 특이성이있다면,
    //    //예를 들어 같은 Sword 라고 해도, 내부 특이성이 있어서( + 1강, +3강 같은) 그 데이터 자체로 존재해야할때는
    //    //Item 각각의 클래스로 들고있는것이 맞고

    //    //그게 아니라면 == Sword 클래스 하나로 다 같은 데이터 형태를 지닌다면.. 
    //    //아이템 타입만 들고있고 해당 클래스를 직접 뭘 사용해야할때 그때 생성해서 돌려주거나 뭘 해도될것...
    //    //==> 또는 아이템 원본타입 배열 하나, 해당 아이템의 개수 담은 배열하나 해서 총 두개의 배열들고있는것도 빠른 검색에 도움됨.


    //    //아이템 취급하는 방법
    //    //1 List로 아이템들을 그냥 다 계속 추가한다.. => 검아이템, 검아이템, 방어구아이템, 포션 더하게된다면, 4개의 리스트가 존재하게됨
    //    //2 배열로 아이템 종류만큼만 선언하여 아이템 클래스 내부에 개수를 더하여 들고 있도록한다.
    //    //3 그외에 딕셔너리로 아이템클래스와 아이템 개수 / 혹은 아이템 타입과 아이템클래스 로 들고 있도록 한다.

    //    public Player(string name) //이름만 주고 생성자로 생성한다면, 나머지 요소가 랜덤이었으면 좋겠음
    //    {
    //        Random random = new Random();
    //        info.name = name;
    //        info.att = random.Next(1, 10);
    //        info.hp = random.Next(10, 21) * 10;
    //        info.maxhp = info.hp;
    //    }

    //    public void AddItem(/*ItemType _type*/Item item)
    //    {            
    //        itemlist.Add(item);                        
    //    }

    //    //아이템 사용하기
    //    public void UseItem(int slotnum = 0) 
    //    {
    //        if (itemlist.Count <= slotnum) //슬롯넘버가 itemlist count 이상이면.. 아이템에 접근할 수 없는 상태
    //        {
    //            Console.WriteLine("잘못된 슬롯번호");
    //            return;
    //        }

    //        //1번 . 아이템 정보를 불러와서 내게 적용
    //        Info _info = itemlist[slotnum].Info;
    //        info.att += _info.att;
    //        info.maxhp += _info.maxhp; //최대 체력을 먼저 세팅을 하고..
    //        info.hp += _info.maxhp; //최대체력이 늘어나면서 현재 HP도 동일하게 늘려주기..
    //        info.hp += _info.hp; //그다음 현재체력 세팅하기...
    //        if (info.hp > info.maxhp)
    //        {
    //            info.hp = info.maxhp;
    //        }

    //        //2번 방법. 아이템에게 내 정보를 넘겨주는것...
    //        //2-1번 아이템에게 내 정보 Info만 넘겨주기
    //        //2-1-1번 아이템에 수정된 내 정보 Info를 돌려받는 방법과 //이방법~~~~~~~
    //        info = itemlist[slotnum].UseItem(info);

    //        //2-1-2번 아이템에 애초에 매개변수로, ref 키워드 내지 out키워드로 각 요소를 넘겨서 적용 받는 방법...
    //        //==>  out키워드는 쓸 때 안전성이 확실하지만, 사실 ref가 바로 누적더해져서 편하긴함...
    //        //2-2번 아이템에게 나 자체를 넘겨주기 //이방법~~~~
    //        itemlist[slotnum].UseItem(this);


    //        itemlist.RemoveAt(slotnum); //사용한 아이템을 아이템 리스트에서 삭제... 
    //    }

    //    //아이템 목록 확인..
    //    public void ShowMyItemList()
    //    {
    //        for (int i = 0; i < itemlist.Count; i++)
    //        {
    //            itemlist[i].ShowItemInfo(); //아이템 정보 출력..
    //        }
    //    }

    //    public void ShowPlayerInfo()
    //    {
    //        info.ShowInfo();
    //    }


    //    //차라리 이렇게 일일히 하는게 좀더 안전하다. 그래도 취향상 변수를 public 해버려도 되긴함.
    //    //                                          => 문제가 생겼을때 위치를 좀 찾기 어려운정도
    //    public void SetInfo_HP(int hp) //직접세팅하도록.. 
    //    {
    //        info.hp = hp;
    //    }
    //    public void SetInfo_MaxpHP(int maxhp) //직접세팅하도록.. 
    //    {
    //        info.maxhp = maxhp;
    //    }
    //    public void SetInfo_Att(int att) //직접세팅하도록.. 
    //    {
    //        info.att = att;
    //    }
    //}

    //class Item 
    //{
    //    //아이템 이름
    //    //protected/*public*/ string name = "";
    //    protected Info info = new Info(); //선언과 동시에 초기화...
    //    public Info Info => info; //이것또한 프로퍼티.. 밖에서 읽기만 허락함..
    //    //아이템 가격
    //    protected/*public*/ int price = 0;

    //    public int Count { get; private set; } = 1; //아이템의 개수

    //public static Item GetItem() //부모클래스를 반환해줌
    //{
    //    Random random = new Random();
    //    ItemType itemtype = (ItemType)random.Next(0, (int)ItemType.End);
    //    switch (itemtype)
    //    {
    //        case ItemType.Sword:
    //            return new Sword(); 
    //        case ItemType.Armor:
    //            return new Armor();
    //        case ItemType.Potion:
    //            return new Potion();
    //        default:
    //            return new Item();//null;                    
    //    }
    //}

    //    public void ShowItemInfo()
    //    {            
    //        info.ShowInfo(); //이름 / 공격력 hp maxhp..같은거 보여줌
    //        Console.WriteLine("가격 : " + price);
    //    }

    //    public Info UseItem( Info _info) //매개변수로 들어온 플레이어의 _info 정보
    //    {
    //        _info.att += info.att; //여기의 info는 해당 아이템의 정보...
    //        _info.maxhp += info.maxhp;
    //        _info.hp += info.maxhp; //최대체력이 늘어나면서 현재 HP도 동일하게 늘려주기..
    //        _info.hp += info.hp;
    //        if (_info.hp > _info.maxhp)
    //        {
    //            _info.hp = _info.maxhp;
    //        }

    //        return _info;
    //    }
    //    public void UseItem(Player _player) //요렇게 되면 Player의 안전성이 깨짐....
    //    {
    //        _player.info.att += info.att;
    //        _player.info.maxhp += info.maxhp;
    //        _player.info.hp += info.maxhp;
    //        _player.info.hp += info.hp;
    //        if (_player.info.hp > _player.info.maxhp)
    //        {
    //            _player.info.hp = _player.info.maxhp;
    //        }
    //    }        
    //    ////현재 기획상에는 가능한 코드지만, 확장성을 생각했을때 썩 좋지는 않음..
    //    //int att = 0;
    //    //int hp = 0;
    //    //int maxhp = 0;
    //    //public Item(/*string _name, int price,*/ ItemType _type) 
    //    //{
    //    //    Random random = new Random();
    //    //    switch (_type)
    //    //    {
    //    //        case ItemType.Sword:
    //    //            att = 10;
    //    //            name = "집행검";
    //    //            price = random.Next(10, 21 ) * 100; //1000원에서 2000원 사이 랜덤 추출 (단위는 100원)
    //    //            break;
    //    //        case ItemType.Armor:
    //    //            maxhp = 10;
    //    //            name = "흉갑";
    //    //            price = random.Next(15, 19) * 100; //1000원에서 2000원 사이 랜덤 추출 (단위는 100원)
    //    //            break;
    //    //        case ItemType.Potion:
    //    //            hp = 10;
    //    //            name = "회복포션";
    //    //            price = random.Next(5, 10) * 100; //1000원에서 2000원 사이 랜덤 추출 (단위는 100원)
    //    //            break;                
    //    //        default:
    //    //            break;
    //    //    }
    //    //}
    //}
    //class Sword : Item
    //{        
    //    //공격력
    //    //int att = 10;
    //    //int hp = 0;
    //    //int maxhp = 0;
    //    //얘는 공격력을 올려준다
    //    public Sword()
    //    {
    //        string[] swordname = {"1번검", "2번검", "3번검", "4번검" , "5번검" };            
    //        Random random = new Random();
    //        info.name = swordname[ random.Next(0, swordname.Length) ];
    //        price = random.Next(10, 20) * 100; //info안에 속한게 아니고, Item클래스의 protected 변수...
    //        info.att = random.Next(5, 11);
    //        info.hp = 0;
    //        info.maxhp = 0;
    //    }
    //}
    //class Armor : Item
    //{
    //    //최대체력
    //    //int maxhp = 10;
    //    //int att = 0;
    //    //int hp = 0;
    //    //최대체력을 올려준다
    //    public Armor()
    //    {
    //        string[] swordname = { "방어구1", "방어구2", "방어구3"};
    //        Random random = new Random();
    //        info.name = swordname[random.Next(0, swordname.Length)];
    //        price = random.Next(15, 25) * 100; //info안에 속한게 아니고, Item클래스의 protected 변수...
    //        info.att = 0;
    //        info.hp = 0;
    //        info.maxhp = random.Next(5, 11) * 10;
    //    }
    //}
    //class Potion : Item
    //{
    //    //현재 체력
    //    //int hp = 10;
    //    //int maxhp = 0;
    //    //int att = 0;
    //    //현재체력을 올려준다..
    //    public Potion()
    //    {            
    //        Random random = new Random();
    //        info.name = "회복 물약";
    //        price = random.Next(5, 10) * 100; //info안에 속한게 아니고, Item클래스의 protected 변수...
    //        info.att = 0;
    //        info.hp = random.Next(1, 5) * 10; 
    //        info.maxhp = 0;
    //    }
    //}

    //class Program
    //{        
    //    static void Main(string[] args)
    //    {
    //        Player player = new Player("용사1");
    //        player.ShowPlayerInfo();

    //        for (int i = 0; i < 5; i++)
    //        {
    //            player.AddItem(Item.GetItem()); //소리소문없이 아이템 생성해서 아이템 목록에 더함
    //        }

    //        player.ShowMyItemList(); //아이템 목록들도 보게될것


    //        player.UseItem(4);
    //        Console.WriteLine("인덱스 4번 아이템 == 마지막 아이템을 사용했음");

    //        player.ShowPlayerInfo(); 
    //        player.ShowMyItemList(); //아이템 목록들도 보게될것
    //    }
    //}

    #endregion
}