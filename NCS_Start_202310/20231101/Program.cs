using System;
using System.Collections.Generic;

namespace NCS_Start_202310
{
    #region 중재자 패턴
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague coll);
    }

    public class ConcreteMediator : Mediator //소통해야할 객체들을 내가 변수로 들고 내가 연결 및 해야할 일을 연결 시켜줌...
    {
        public ConcreteColleague1 col1;
        public ConcreteColleague2 col2;

        public override void Send(string message, Colleague coll)
        {
            if (coll == col1)
            {
                col2.Notify(message);
            }
            else
                col1.Notify(message);
        }

    }
    public abstract class Colleague
    {
        protected Mediator mediator;
        public Colleague(Mediator medi)
        {
            mediator = medi;
        }
    }
    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator medi) : base(medi)
        { }
        public void Send(string msg)
        {
            mediator.Send(msg, this);
        }
        public void Notify(string mes)
        {
            Console.WriteLine("ConcreteColleague1 친구가 메세지를 받았음 " + mes );
        }
    }

    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator medi) : base(medi)
        { }
        public void Send(string msg)
        {
            mediator.Send(msg, this);
        }
        public void Notify(string mes)
        {
            Console.WriteLine("ConcreteColleague2 친구가 메세지를 받았음 " + mes);
        }
    }

    class Program
    {
        static void Main(string[] s)
        {
            ConcreteMediator m = new ConcreteMediator();
            ConcreteColleague1 c1 = new ConcreteColleague1(m);
            ConcreteColleague2 c2 = new ConcreteColleague2(m);
            m.col1 = c1;
            m.col2 = c2;

            c1.Send("안녕");
            c2.Send("Hi");
        }
    }
    #endregion

    #region 상태 패턴

    //public class Context //실행 주체..
    //{
    //    State state = null;
    //    public void Request(int val)
    //    {
    //        state.Handle(val);
    //    }
    //    public void SetState(State state)
    //    {
    //        Console.WriteLine("기존 스테이트 : " + this.state);
    //        this.state = state;
    //    }
    //}
    //public abstract class State
    //{
    //    protected Context context = null;
    //    public State(Context context)
    //    {
    //        this.context = context;
    //    }
    //    public abstract void Handle(int val);
    //}

    //public class ConcreteStateA : State
    //{
    //    public ConcreteStateA(Context context ) : base(context)
    //    { 
    //    }
    //    public override void Handle(int val)
    //    {
    //        Console.WriteLine("ConcreteStateA의 Handle : " + val);


    //        if (val > 10)
    //        {
    //            context.SetState(new ConcreteStateB(context));
    //        }
    //    }
    //}
    //public class ConcreteStateB : State
    //{
    //    public ConcreteStateB(Context context) : base(context)
    //    {
    //    }
    //    public override void Handle(int val)
    //    {
    //        Console.WriteLine("ConcreteStateB의 Handle : " + val);
    //        if (val <= 10)
    //        {
    //            context.SetState(new ConcreteStateA(context));
    //        }
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] a)
    //    {
    //        Context context = new Context();
    //        context.SetState(new ConcreteStateA(context));
    //        context.Request(11);
    //        context.Request(5);
    //        context.Request(15);
    //        context.Request(9);
    //    }
    //}

    #endregion

    #region 커맨드 패턴
    //public abstract class Command
    //{
    //    protected Receiver receiver;
    //    public Command(Receiver receiver)
    //    {
    //        this.receiver = receiver;
    //    }
    //    public abstract void Execute();
    //}

    //public class ConcreteCommand : Command
    //{
    //    public ConcreteCommand(Receiver receiver) : base(receiver)
    //    {}
    //    public override void Execute()
    //    {
    //        receiver.Action();
    //    }
    //}

    //public class Receiver
    //{
    //    public void Action()
    //    {
    //        Console.WriteLine("리ㅅㅣ버의 action ");
    //    }
    //}

    //class Invoker//요거를 유니티에서는 내부적으로 coroutine 같은거로 구현해서 일을 일단 쌓아놓고
    //{
    //    List<Command> commandlist = new List<Command>();
    //    //queue 
    //    public void SetCommand(Command command)
    //    {
    //        commandlist.Add(command);
    //    }
    //    public void ExecuteCommand()//
    //    {
    //        foreach (var item in commandlist)
    //        {
    //            item.Execute();
    //        }            
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] ar)
    //    {
    //        Receiver receiver = new Receiver();//이친구를 뭔가 일을 시킬건데
    //        Command command = new ConcreteCommand(receiver); //콘크리트 커맨드 를 통해서 시킬것임

    //        Invoker inv = new Invoker();
    //        inv.SetCommand(command);
    //        inv.ExecuteCommand();
    //    }
    //}

    #endregion

    #region 책임연쇄패턴
    //public enum CommandType
    //{ 
    //    Command1,
    //    Command2,
    //    Command3,

    //    End
    //}

    //public abstract class Handler
    //{
    //    public Handler Next { get; set; }
    //    public abstract void Process(CommandType _type, string request);        

    //}

    //public class ConcreteHandler1 : Handler
    //{
    //    public override void Process(CommandType _type, string request)
    //    {
    //        if (_type == CommandType.Command1)
    //        {
    //            Console.WriteLine($"커맨드1에서 처리할수 있는 문제입니다. {request}를 처리합니다." );
    //        }
    //        else
    //        {
    //            this.Next.Process(_type, request);
    //        }
    //    }
    //}
    //public class ConcreteHandler2 : Handler
    //{
    //    public override void Process(CommandType _type, string request)
    //    {
    //        if (_type == CommandType.Command2)
    //        {
    //            Console.WriteLine($"커맨드2에서 처리할수 있는 문제입니다. {request}를 처리합니다.");
    //        }
    //        else
    //        {
    //            this.Next.Process(_type, request);
    //        }
    //    }
    //}
    //public class ConcreteHandler3 : Handler
    //{
    //    public override void Process(CommandType _type, string request)
    //    {
    //        if (_type == CommandType.Command3)
    //        {
    //            Console.WriteLine($"커맨드3에서 처리할수 있는 문제입니다. {request}를 처리합니다.");
    //        }
    //        else
    //        {
    //            this.Next.Process(_type, request);
    //        }
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Handler h1 = new ConcreteHandler1();
    //        Handler h2 = new ConcreteHandler2();
    //        Handler h3 = new ConcreteHandler3();

    //        h1.Next = h2;
    //        h2.Next = h3;

    //        h1.Process(CommandType.Command3, "커맨드3이 뭔가 일좀 처리해주세요");
    //        h1.Process(CommandType.Command2, "커맨드2이 뭔가 일좀 처리해주세요");
    //    }
    //}

    #endregion

    #region 전략패턴

    //public interface IFly
    //{
    //    string Fly();
    //}

    //class ItFlys : IFly
    //{
    //    public string Fly()
    //    {
    //        return "날아올라";
    //    }
    //}

    //class CantFly : IFly
    //{
    //    public string Fly()
    //    {
    //        return "날 수 없어..";
    //    }
    //}

    //class FlyFast : IFly
    //{
    //    public string Fly()
    //    {
    //        return "고속비행";
    //    }
    //}
    //public class Animal
    //{
    //    public IFly flyingType;
    //    public string TryToFly()
    //    {
    //        return flyingType.Fly();
    //    }
    //    public void SetFlyingAbility(IFly newtype)
    //    {
    //        this.flyingType = newtype;
    //    }
    //}
    //public class Dog : Animal
    //{
    //    public Dog()
    //    {
    //        flyingType = new CantFly();
    //    }
    //}

    //public class Bird : Animal
    //{
    //    public Bird() 
    //    {
    //        flyingType = new ItFlys();    
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] asrg)
    //    {
    //        Animal dog = new Dog();
    //        Animal bird = new Bird();
    //        Console.WriteLine("개의 경우 : " + dog.TryToFly());
    //        Console.WriteLine("새의 경우 : " + bird.TryToFly());                        

    //        dog.SetFlyingAbility(new ItFlys()); //클래스를 매개변수로 넣어주니까

    //        Console.WriteLine("개에게 날개를 달아줌 : " + dog.TryToFly());

    //        bird.SetFlyingAbility(new FlyFast()); //클래스를 매개변수로 넣어주니까

    //        Console.WriteLine("새에게 큰 날개를 달아줌 : " + bird.TryToFly());
    //    }
    //}

    #endregion

    #region 옵저버패턴

    //public interface Observer
    //{
    //    public void OnEvent();
    //}
    //public class ConcreteObserver : Observer //내가 가진 객체에게 이벤트 알려줌.. 
    //{
    //    string eventname="";
    //    string observerState;
    //    ConcreteSubject subject; //실제 객체~~~
    //    public ConcreteObserver(ConcreteSubject subject, string name)
    //    {
    //        this.subject = subject;
    //        eventname = name;
    //    }
    //    public void OnEvent()
    //    {
    //        observerState = subject.subjectState;
    //        Console.WriteLine("옵저버 Onevent 발동 " + eventname +" / 상태 : " + observerState);
    //    }
    //}

    //public abstract class Subject //
    //{
    //    List<Observer> observerList = new List<Observer>();
    //    public void Attach(Observer observer)
    //    {
    //        observerList.Add(observer);
    //    }
    //    public void Detach(Observer observer)
    //    {
    //        observerList.Remove(observer);
    //    }
    //    public void Notify()
    //    {
    //        foreach (var item in observerList)
    //        {
    //            item.OnEvent();
    //        }
    //    }
    //}
    //public class ConcreteSubject :  Subject //
    //{
    //    public string subjectState;        
    //    //
    //}

    #endregion

    #region 방문자 패턴

    ////인터페이스 구현으로 해도됨... 변수같은게 필요없다면...
    //public abstract class Visitor //객체 구조의 구상 요소들을 인수들로 사용할 수 있는 비지터 메서들의 집합
    //{
    //    public abstract void VisitConcreteElementA(ConcreteElementA elementA);
    //    public abstract void VisitConcreteElementB(ConcreteElementB elementB);
    //}

    //public abstract class Element //실제 객체 부모
    //{
    //    public abstract void Accept(Visitor visitor); //인터페이스든 추상클래스든 방문자의 원형...을 받아들일 준비가 되었음
    //}
    //public class ConcreteElementA : Element
    //{
    //    public override void Accept(Visitor visitor) 
    //    {
    //        visitor.VisitConcreteElementA(this); //해당 방문자의 함수를 실행시키는데, 매개변수로 나를 넘김
    //    }        
    //}
    //public class ConcreteElementB : Element
    //{
    //    public override void Accept(Visitor visitor)
    //    {
    //        visitor.VisitConcreteElementB(this);
    //    }
    //}

    //public class ConcreteVisitor1 : Visitor //실질구현
    //{
    //    public override void VisitConcreteElementA(ConcreteElementA elementA)
    //    {
    //        //elementA에 무언가 무슨 영향을 끼치고 싶다면 여기서 뭘 하머ㅕㄴ 될것...
    //        //또는 가공해서 하고싶은거 하거나...
    //        Console.WriteLine("ConcreteElementA 를 매개변수로 받은 ConcreteVisitor1 의 VisitConcreteElementA 함수");
    //    }

    //    public override void VisitConcreteElementB(ConcreteElementB elementB)
    //    {
    //        Console.WriteLine("ConcreteElementB 를 매개변수로 받은 ConcreteVisitor1 의 VisitConcreteElementB 함수");
    //    }
    //}

    //public class ConcreteVisitor2 : Visitor //실질구현
    //{
    //    public override void VisitConcreteElementA(ConcreteElementA elementA)
    //    {
    //        Console.WriteLine("ConcreteElementA 를 매개변수로 받은 ConcreteVisitor2 의 VisitConcreteElementA 함수");
    //    }

    //    public override void VisitConcreteElementB(ConcreteElementB elementB)
    //    {
    //        Console.WriteLine("ConcreteElementB 를 매개변수로 받은 ConcreteVisitor2 의 VisitConcreteElementB 함수");
    //    }
    //}

    //public class ObjectStructure
    //{
    //    List<Element> list = new List<Element>();

    //    public void Attach(Element element)
    //    {
    //        list.Add(element);
    //    }
    //    public void Detach(Element element)
    //    {
    //        list.Remove(element);
    //    }
    //    public void Accept(Visitor visistor)
    //    {
    //        foreach (var item in list)
    //        {
    //            item.Accept(visistor);
    //        }
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        ObjectStructure objstr = new ObjectStructure();
    //        objstr.Attach(new ConcreteElementA());
    //        objstr.Attach(new ConcreteElementB());

    //        ConcreteVisitor1 v1 = new ConcreteVisitor1();
    //        ConcreteVisitor2 v2 = new ConcreteVisitor2();

    //        objstr.Accept(v1);

    //        Console.WriteLine("=========================");
    //        objstr.Accept(v2);
    //    }
    //}

    #endregion

    #region 반복자패턴
    ////보통 stack 내지 queue를 내 방식으로 구현하는데 쓸듯...
    //public class Item
    //{
    //    string name;
    //    public Item(string name)
    //    { this.name = name; }
    //    public string GetName()
    //    { 
    //        return name;
    //    }
    //}

    //interface IAbstractCollection
    //{
    //    Iterator CreateIterator();
    //}
    //interface IAbstractIterator
    //{
    //    Item First();
    //    Item Next();
    //    bool IsDone { get; }
    //    Item currentItem { get; }
    //}

    //public class Collection : IAbstractCollection
    //{
    //    List<Item> list = new List<Item>();
    //    public int Count => list.Count;
    //    public Iterator CreateIterator()
    //    {
    //        return new Iterator(this);  
    //    }

    //    public Item this[int index]
    //    {
    //        get { return list[index]; }
    //        set { list.Add(value); }
    //    }
    //}

    //public class Iterator : IAbstractIterator
    //{
    //    Collection collection;
    //    int current = 0; //인덱스인 셈..
    //    public int step { get; set; } = 1;
    //    public Iterator(Collection collection)
    //    {
    //        this.collection = collection;
    //    }
    //    public bool IsDone => (current >= collection.Count ); //더이상 접근 할 수 없는 상태. Isdone == true               

    //    public Item currentItem => collection[current];

    //    public Item First()
    //    {
    //        current = 0;
    //        return collection[current] as Item;
    //    }

    //    public Item Next()
    //    {
    //        current += step;
    //        if (IsDone == false)
    //        {
    //            return collection[current] as Item;
    //        }
    //        else
    //            return null;
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Collection col = new Collection();
    //        for (int i = 0; i < 7; i++)
    //        {
    //            col[i] = new Item("아이템" + (i+1));
    //        }
    //        Iterator iter = col.CreateIterator();
    //        Console.WriteLine("=============전체 콜렉션 안의 아이템 출력============");

    //        iter.step = 1;
    //        for (Item item = iter.First(); !iter.IsDone; item = iter.Next())
    //        {
    //            Console.WriteLine(item.GetName());
    //        }
    //        Console.WriteLine("=========================");

    //        iter.step = 3;

    //        for (Item item = iter.First(); !iter.IsDone ; item = iter.Next())
    //        {
    //            Console.WriteLine(item.GetName());
    //        }
    //    }
    //}

    #endregion

    #region 프록시 패턴

    //public abstract class Subject
    //{
    //    public abstract void Request();
    //}

    //public class RealSubject : Subject
    //{
    //    public override void Request()
    //    {
    //        Console.WriteLine("RealSubject 의 Request");
    //    }
    //    public void A1()
    //    { }
    //    public void A2()
    //    { }
    //    public void A3()
    //    { }
    //}
    //class Proxy : Subject
    //{
    //    RealSubject _realsubject;

    //    public void A1()
    //    {
    //        _realsubject.A1();
    //    }

    //    public override void Request()
    //    {
    //        if (_realsubject == null)                 
    //        {
    //            _realsubject = new RealSubject();
    //        }
    //        //보안 체크 해서
    //        //충분히 뭔가 진행해도 된다면~~~
    //        //아니면 그냥 return;

    //        _realsubject.Request();
    //    }
    //}

    #endregion

    #region 파사드 패턴

    //class System
    //{
    //    public void Function()
    //    {
    //        Console.WriteLine("기존 시스템의 함수");
    //    }
    //}
    //class System2
    //{
    //    public void Function2()
    //    {
    //        Console.WriteLine("시스템2의 함수2");
    //    }
    //}
    //class System3
    //{
    //    public void Function3()
    //    {
    //        Console.WriteLine("시스템3의 함수3");
    //    }
    //}

    //class Facade
    //{
    //    System system1;
    //    System2 system2;
    //    System3 system3;
    //    public Facade()
    //    {
    //        system1 = new System();
    //        system2 = new System2();
    //        system3 = new System3();
    //    }
    //    public void FunctionAll()
    //    {
    //        system1.Function();
    //        system2.Function2();
    //        system3.Function3();
    //    }
    //    public void FunctionNotOrigin()
    //    {
    //        system2.Function2();
    //        system3.Function3();
    //    }
    //}

    //====================
    //interface IAdapter
    //{
    //    void AAAA2();
    //}
    //class AA
    //{
    //    public void AAAA()
    //    {
    //        Console.WriteLine("AAAA가 하던 일..");            
    //    }
    //}
    //class BB : AA, IAdapter
    //{         
    //    public void AAAA2()
    //    {
    //        Console.WriteLine("추가로 내가 뭔가 하고싶은것 ");
    //        AAAA();
    //        Console.WriteLine("뭔가 AAAA를 고치기엔 좀 그렇고 완전히 새로 상속 시키기에도 애매하고... " +
    //            "그냥 얘만 조금 추가기능을 붙이고 싶은데 싶을때? ");
    //    }
    //}

    #endregion

    #region 인터페이스와 추상클래스의 활용 실습
    //public enum ClothesType
    //{
    //    Top,
    //    Bottom,
    //    Cap,
    //    Accessories,

    //    End
    //}

    //interface IWear
    //{
    //    void Wearing();
    //}

    //public abstract class Clothes
    //{
    //    public ClothesType type { get; protected set; } = ClothesType.End;
    //    protected int price = 0;
    //    public int Price => price; //밖에서 내 변수 price를 가져오는건 안되고 price의 값을 가져오는 것은 됨.

    //    //public int price { get; protected set; } = 0;

    //    protected string name = ""; //옷의 이름.

    //    public Clothes(string name)
    //    {
    //        this.name = name;
    //    }

    //    public int GetPrice()
    //    {
    //        return price;
    //    }
    //    public abstract void GetInfo();     //abstract 반드시 너가 구현해야할 함수.
    //    public virtual void Tips()          //자식단에서 재정의를 허락함...
    //    {
    //        Console.WriteLine("유행상품입니다");
    //    }
    //}
    //public class Top : Clothes, IWear
    //{
    //    public Top(int price, string name) : base(name)
    //    {
    //        type = ClothesType.Top;
    //        this.price = price;
    //    }

    //    public override void GetInfo()
    //    {
    //        Console.WriteLine($"이 상의는 {name}으로, {price}원 입니다");
    //    }

    //    public void Wearing()
    //    {
    //        Console.WriteLine("이 상의는 착용 가능합니다");
    //    }
    //}
    //public class Bottom : Clothes, IWear
    //{
    //    public Bottom(int price, string name) : base(name)
    //    {
    //        type = ClothesType.Bottom;
    //        this.price = price;
    //    }
    //    public override void GetInfo()
    //    {
    //        Console.WriteLine($"이 하의는 {name}으로, {price}원 입니다");
    //    }
    //    public void Wearing()
    //    {
    //        Console.WriteLine("이 하의는 착용 가능합니다");
    //    }
    //}
    //public class Cap : Clothes, IWear
    //{
    //    public Cap(int price, string name) : base(name)
    //    {
    //        type = ClothesType.Cap;
    //        this.price = price;
    //    }
    //    public override void GetInfo()
    //    {
    //        Console.WriteLine($"이 모자는 {name}으로, {price}원 입니다");
    //    }
    //    public void Wearing()
    //    {
    //        Console.WriteLine("이 모자는 착용 가능합니다");
    //    }
    //}
    //public class Accessories : Clothes
    //{
    //    public Accessories(int price, string name) : base(name)
    //    {
    //        type = ClothesType.Accessories;
    //        this.price = price;
    //    }
    //    public override void GetInfo()
    //    {
    //        Console.WriteLine($"이 악세사리는 {name}으로, {price}원 입니다");
    //    }
    //}

    //public class Owner
    //{
    //    Dictionary<ClothesType, List<Clothes>> AllMyClothes = new Dictionary<ClothesType, List<Clothes>>();

    //    Clothes CreateClothes(int num)
    //    {
    //        Random random = new Random();
    //        Clothes clothes;
    //        ClothesType type = (ClothesType)random.Next(0, (int)ClothesType.End);

    //        switch (type)
    //        {
    //            case ClothesType.Top:
    //                clothes = new Top(random.Next(10, 51) * 100, type.ToString() + num);
    //                break;
    //            case ClothesType.Bottom:
    //                clothes = new Bottom(random.Next(10, 51) * 100, type.ToString() + num);
    //                break;
    //            case ClothesType.Cap:
    //                clothes = new Cap(random.Next(10, 51) * 100, type.ToString() + num);
    //                break;
    //            case ClothesType.Accessories:
    //                clothes = new Accessories(random.Next(10, 51) * 100, type.ToString() + num);
    //                break;
    //            default:
    //                clothes = null;
    //                break;
    //        }
    //        return clothes;
    //    }

    //    public void SetMyAllClothes()
    //    {
    //        List<int> list = new List<int>();
    //        list.Add(2);
    //        list.Add(2);
    //        list.Add(2);
    //        list.Add(2);

    //        Clothes clothes;
    //        for (int i = 0; i < 10; i++)
    //        {
    //            clothes = CreateClothes(i + 1);
    //            if (AllMyClothes.ContainsKey(clothes.type))
    //            {
    //                AllMyClothes[clothes.type].Add(clothes); //딕셔너리의 특정키 의 값 == 해당 리스트 == 해당타입의 리스트에 내용을 더함.
    //            }
    //            else
    //                AllMyClothes.Add(clothes.type, new List<Clothes>() { clothes });     //딕셔너리에 키와 값을 더함.   
    //        }
    //    }

    //    public void ShowAllMyClothes()
    //    {
    //        Console.WriteLine("내가 가진 모든 옷 정보 보여주기.");
    //        foreach (var item in AllMyClothes)
    //        {
    //            for (int i = 0; i < item.Value.Count; i++)
    //            {
    //                item.Value[i].GetInfo();
    //            }
    //        }
    //    }

    //    public bool AskIsEnableWearing(Clothes cloth) //cloth를 입어도 되는지 여부를 손님이 물었다고 쳤을때 
    //    {
    //        if (cloth is IWear)
    //        {
    //            IWear wear = cloth as IWear;
    //            wear.Wearing();
    //            return true;
    //        }
    //        else
    //        {
    //            //Iwear 요소가 없다면... 
    //            //일단 우리는 악세사리인걸 알수있고
    //            //악세사리거나 말거나
    //            Console.WriteLine("착용하실 수 없습니다");
    //            return false;
    //        }
    //    }

    //    public Clothes PickOneClothes(ClothesType type) //상의인지 하의인지... 타입만 매개변수로 주면 뭔가 랜덤한 옷을 들려줌.
    //    {
    //        if (AllMyClothes.ContainsKey(type))
    //        {
    //            Random random = new Random();
    //            return AllMyClothes[type][random.Next(0, AllMyClothes[type].Count)];
    //        }
    //        else
    //        {
    //            Console.WriteLine("죄송합니다. 해당 타입 옷은 품절입니다.");
    //            return null;
    //        }
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Owner owner = new Owner(); //오너생성
    //        owner.SetMyAllClothes(); //주인의 가진 옷들 세팅

    //        Console.WriteLine("주인이 가진 옷 출력");

    //        owner.ShowAllMyClothes(); //주인이 가진 옷들 전부 한번 보기

    //        Clothes cloth = null;
    //        ClothesType type = ClothesType.Top;
    //        while (cloth == null)
    //        {
    //            Console.WriteLine(type + "타입의 옷 랜덤으로 하나 고르기");
    //            cloth = owner.PickOneClothes(type);
    //            type++;
    //        }

    //        if (owner.AskIsEnableWearing(cloth))
    //        {
    //            Console.WriteLine("착용 가능하다니 입어보겠습니다");
    //        }
    //        else
    //        {
    //            Console.WriteLine("착용이 불가능 하군요... ");
    //        }
    //    }
    //}
    #endregion
}