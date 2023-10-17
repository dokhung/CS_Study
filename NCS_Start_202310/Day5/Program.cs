using System;
using System.Collections.Generic;
//using System.Text;
//using ExtensionMethods; //확장메서드 사용용...

namespace NCS_Start_202310
{
    class Program
    {
        static void Main(string[] args)
        {
            //각 클래스 생성해서 불러서 확인 해보시면 더 좋겠죠...
        }
    }
    #region 상속 이해 체크 실습

    //가장 상위 부모 클래스로      탈것  클래스 만들기
    public abstract class Ride //내가 내부에 하나라도 추상적인게 있다면 나는 추상클래스다..
    {
        //이 탈것 클래스는 추상적인 Move()함수를 가지고 있습니다
        public abstract void Move(); //추상 메서드는 추상 == 실체가 없기 때문에 {} 요 구현이 없고 선언 ; 만 있음
    }

    //탈것   클래스를 상속받은      하늘 탈것 / 땅 탈것    두가지 클래스 존재

    public class FlyRide  : Ride
    {
        public override void Move()//하늘 탈것의 Move함수를 부르면  "날고 있습니다" 출력
        {
            Console.WriteLine("날고 있습니다");
        }
    }

    public class GroundRide : Ride
    {
        public override void Move() //땅 탈것의 Move함수를 부르면 "달리고 있습니다" 출력
        {
            Console.WriteLine("달리고 있습니다");
        }
    }

    //땅탈것 클래스를 상속받은        자동차 / 자전거      두가지 클래스 존재
    public class Car : GroundRide
    {
        public override void Move()//자동차 의 Move함수를 부르면 "빠르게 달리고 있습니다" 출력
        {
            Console.Write("빠르게 ");
            base.Move();            
        }
    }
    public class Bycicle : GroundRide
    {
        protected int wheelcount = 2;
        public override void Move()//자전거의 Move 함수를 부르면 "사람이 직접 페달을 밟고 있습니다"  만  출력하기
        {
            Console.WriteLine("사람이 직접 페달을 밟고 있습니다");  
        }
        public virtual void GetWheelCount()
        {
            Console.WriteLine("바퀴의 개수는 "+ wheelcount + "개입니다");
        }
    }
    // 자전거 클래스를 상속받은      외발자전거     클래스 존재
    public class OneBycicle : Bycicle
    {
        public OneBycicle()
        {
            wheelcount = 1; //생성자에서 세팅하거나
        }

        //override는 재정의. 즉 내가 부모의 함수를 바로 쓰지 않을때 인데, base.GetWheelCount만 한다면
        //굳이 부를필요는 없을것. 그것도 virtual 선언을 했기때문에 재정의 해도되고 안해도 됨.
        public override void GetWheelCount()
        {
            wheelcount = 1; //그냥 이 함수를 부르기 직전에 세팅하거나..
            base.GetWheelCount();
        }
    }            
   
   

    // 자전거에만,    상속을 허락한 - GetWheelCount 라는 함수 추가
    // 이 함수는 바퀴의 개수는 2개입니다 를 출력함

    // 자전거를 상속받은 외발자전거에서 "GetWheelCount" 함수를 부르면
    // "바퀴의 개수는 1개입니다" 를 출력
    // 외발자전거에서의 Move함수는 자전거의 Move함수와 동일함...

    #endregion
    #region 인터페이스 예시2
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Player player = new Player();
    //        Monster monster = new Monster();
    //        Objects objects = new Objects();

    //        //as 키워드랑 is 키워드가 있어요
    //        if (monster is IShoot )
    //        {                
    //            monster.Attacked(2.2f);
    //        }

    //        IShoot shoot = objects as IShoot;
    //        if (shoot !=null)
    //        {
    //            shoot.Attacked(3f);
    //        }

    //        if (player is IShoot)
    //        {
    //            //player.Attacked(2.2f);
    //        }
    //        else
    //        {
    //            Console.WriteLine("player 는 IShoot형식을 포함하고 있지않음");
    //        }

    //        IShoot shoot2 = player as IShoot;
    //        if (shoot2 != null)
    //        {
    //            shoot2.Attacked(3f);
    //        }
    //        else
    //        {
    //            Console.WriteLine("player 는 IShoot형식을 포함하고 있지않음");
    //        }
    //    }
    //}

    //interface IShoot
    //{
    //    void Attacked(float damage);
    //}

    //class Player
    //{      
    //}
    //class Monster : IShoot
    //{
    //    float hp = 0;
    //    public void Attacked(float damage)
    //    {
    //        hp -= damage;
    //        Console.WriteLine(damage + "의 피해를 입었습니다");

    //        //몬스터의 광폭화
    //    }
    //}
    //class Objects : IShoot //부숴지는 물건이라면...
    //{
    //    float hp = 0;
    //    public void Attacked(float damage)
    //    {
    //        hp -= damage;
    //        Console.WriteLine("물건이 " + damage + "의 피해를 입었습니다");

    //        //물건이 빠그라짐 어딘가 부숴진 이미지를 출력함
    //    }
    //}
    #endregion
    #region 인터페이스

    //public interface IInterface //계약..  //목차
    //{
    //    //멤버변수 이런거 못씀
    //    void A();
    //    int B();
    //    string C(string val1, string val2);
    //}
    //public interface ISomething
    //{
    //    void DD();
    //    void E();
    //}


    //public class ExampleInterface : IInterface, ISomething
    //{
    //    public void A()
    //    {

    //    }

    //    public int B()
    //    {
    //        return 0;  
    //    }

    //    public string C(string val1, string val2)
    //    {
    //        return "";
    //    }

    //    public void DD()
    //    {            
    //    }

    //    public void E()
    //    {        
    //    }
    //}



    //public abstract class AA
    //{
    //    int a = 0;
    //    public abstract void A();

    //    public virtual void B()
    //    {

    //    }
    //    void C()
    //    {
    //    }
    //}

    //public class CD
    //{
    //}

    //public class ABC : AA, IInterface, ISomething
    //{
    //    public override void A()
    //    {

    //    }
    //    public string C(string val1, string val2)
    //    {
    //        return "";
    //    }
    //    public override void B()
    //    {
    //        base.B();
    //    }

    //    int IInterface.B()
    //    {
    //        return 0;
    //    }

    //    public void DD()
    //    {            
    //    }

    //    public void E()
    //    {        
    //    }
    //}
    #endregion

    #region 상속 예시 2
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Animal animal = new Animal(); //추상클래스는 인스턴스 생성이 안됨
    //        FlyAnimal bird = new FlyAnimal();

    //        Console.WriteLine("FlyAnimal 클래스 부르기 시작");
    //        Console.WriteLine("FlyAnimal 클래스의 기본 다리 개수 : " + bird.GetLegCount());
    //        bird.Eat();
    //        bird.Fly();
    //        bird.Speak();
    //        bird.Call();

    //        GroundAnimal fourleg = new GroundAnimal();

    //        Console.WriteLine("GroundAnimal 클래스 부르기 시작");
    //        Console.WriteLine("GroundAnimal 클래스의 기본 다리 개수 : " + fourleg.GetLegCount());
    //        fourleg.Eat();
    //        //fourleg.Fly(); // FlyAnimal에만 Fly함수가 있기때문에..            
    //        fourleg.Speak();
    //        fourleg.Call();

    //        Tiger tiger = new Tiger();
    //        Console.WriteLine("Tiger 클래스 부르기 시작");
    //        Console.WriteLine("Tiger 클래스의 기본 다리 개수 : " + tiger.GetLegCount());
    //        //tiger.Eat();            
    //        tiger.Speak();
    //        //tiger.Call();
    //        //tiger.Roar();

    //        Fox fox = new Fox();
    //        Console.WriteLine("Fox 클래스 부르기 시작");
    //        Console.WriteLine("Fox 클래스의 기본 다리 개수 : " + fox.GetLegCount());
    //        fox.Speak();

    //    }
    //}        

    //public abstract class Animal
    //{
    //    public string name="";
    //    public int lifeTime = 0;
    //    protected int legCount = 0;

    //    public void Eat()
    //    {
    //        Console.WriteLine("동물클래스_밥먹는다");
    //    }
    //    protected abstract void Move(); //abstract == 추상적 선언이므로, 자식클래스라면 반드시 구현 해야함.
    //    //{
    //    //    Console.WriteLine("동물클래스 _ 움직인다");
    //    //}
    //    public virtual void Speak() //virtual == 밑에 자식클래스들이 재정의 가능하도록 허락해줌
    //    {
    //        Console.WriteLine("동물이 울음소리를 냄");
    //    }

    //    public int GetLegCount()
    //    {
    //        return legCount;
    //    }
    //    public void Call()
    //    {
    //        Move();
    //    }
    //}

    //public class FlyAnimal :Animal //날짐승
    //{
    //    public FlyAnimal()
    //    {
    //        legCount = 2;
    //    }
    //    protected override void Move()
    //    {
    //        Console.WriteLine("날짐승클래스 _ 움직인다");
    //    }
    //    public void Fly() //flyanimal의 고유 함수
    //    {
    //        Console.WriteLine("날았다");
    //    }
    //}

    //public class GroundAnimal : Animal //땅짐승
    //{
    //    public GroundAnimal()
    //    {
    //        legCount = 4;
    //    }
    //    protected override void Move()
    //    {
    //        Console.WriteLine("땅짐승 친구들 _ 달린다");
    //    }

    //    public virtual void Roar() //상속의 허락
    //    {
    //        Console.WriteLine("GroundAnimal의  Roar~~~~");
    //    }

    //    //public override void Speak()
    //    //{
    //    //    base.Speak();
    //    //    Console.WriteLine("GroundAnimal 의 울음~~");
    //    //}
    //}

    //public class Tiger : GroundAnimal
    //{
    //    public override void Speak()
    //    {
    //        Console.WriteLine("어흥");
    //    }

    //    public void Fly() //flyanimal의 고유 함수
    //    {
    //        Console.WriteLine("날았다");
    //    }
    //    public override void Roar() //상속이 허락되었기때문에 재정의 가능.
    //    {
    //        Console.WriteLine("Tiger의 Roar~~~~");
    //    }
    //}

    //public class Fox : GroundAnimal
    //{
    //    public override void Speak()
    //    {
    //        base.Speak();
    //        Console.WriteLine("뭔가 하여튼 여우가 울음");
    //    }
    //}

    #endregion

    #region 상속
    //public /*abstract*/ class Parent
    //{
    //    public int a;
    //    protected string b;
    //    bool c;

    //    public virtual void A()
    //    {
    //       //parent에서의 A함수~
    //    }

    //    protected /*abstract*/ void B()//;
    //    {
    //    }

    //    /*private*/void C()
    //    { }
    //}
    //public class Child : Parent
    //{                
    //    public int aa;
    //    protected string bb;
    //    bool cc;

    //    public sealed override void A()//sealed 는 더이상 상속 및 재정의를 허락하지않겠다
    //    {
    //        //Child안에서의 A작용..
    //        //this.=> 나 내것
    //        //base. => 부모의 것~
    //        //base.A();
    //    }
    //    //protected override void B()//B가 구현되어야 함(반드시)
    //    //{
    //    //    //실제 내용 구현...
    //    //}      


    //    void AA()
    //    {
    //        a = 10;
    //        b = "스트링";

    //        A();
    //        B();

    //    }
    //}
    //class GrandChild : Child
    //{
    //    //public override void A()
    //    //{
    //    //    base.A();
    //    //}
    //}

    #endregion

    #region 자판기 이용 실습
    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        Console.WriteLine("음료를 구매합시다~");
    //        Console.Write("현재 나의 소지금 : ");

    //        Random random = new Random(); //난수 생성을 쓸 준비
    //        //나의 소지금 랜덤으로 선언하고
    //        int myMoney = random.Next(20, 61) * 100;

    //        Console.WriteLine(myMoney);

    //        Console.WriteLine("자판기 음료 목록");
    //        VendingMachine vendingMachine = new VendingMachine(); //생성자가 불리므로 음료 리스트가 세팅되었음...
    //        vendingMachine.ShowDrinkList(); //음료목록 보여주는 함수 만들어뒀었음..

    //        string choose = "";
    //        int choosenum = 0; //내가 원하는 음료를 번호로 선택함
    //        int price = 0;
    //        while (true) //무한반복
    //        {
    //            if (myMoney <= 0)
    //            {
    //                Console.WriteLine("소지금이 없습니다");
    //                return;
    //            }

    //            Console.WriteLine("구매하실 음료를 선택해주세요");
    //            choose = Console.ReadLine();

    //            if (int.TryParse(choose, out choosenum)) //숫자를 입력하였음
    //            {
    //                price = vendingMachine.GetDrinkPrice(choosenum);
    //            }
    //            else
    //            {
    //                //음료 이름을 입력하였음
    //                price = vendingMachine.GetDrinkPrice(choose);
    //            }

    //            Console.WriteLine(); //엔터

    //            if (price == -1)//요게 음료의 가격을 보여주는 함수...
    //            {
    //                //존재하지않는 음료
    //                Console.WriteLine("잘못된 선택입니다.");
    //                continue;
    //            }

    //            //존재하는 음료
    //            Console.WriteLine("선택한 음료의 가격은 " + price + "원 입니다");

    //            //예외처리.
    //            //음료의 금액이 내 소지금보다 작을때 일을 수행하고, 내가 살수 없는 상태라면 돌려보내기
    //            if (myMoney < price)
    //            {
    //                Console.WriteLine("선택한 음료를 구매하기엔, 소지금이 " + (price - myMoney) + "원 부족합니다");
    //                continue;
    //            }

    //            myMoney -= price;
    //            Console.WriteLine("구매완료.\n나의 소지금 : " + myMoney);
    //        }
    //        //내가 원하는 만큼 음료 구매하는 작업 진행하기..
    //    }
    //}

    ////자판기 클래스를 만들기
    //class VendingMachine
    //{
    //    List<Drink> drinklist = new List<Drink>(); //멤버변수

    //    public VendingMachine() //생성자도 결국 함수...
    //    {
    //        //####방법1번
    //        drinklist.Add(new Drink("박카스", 900)); //매개변수 받는 생성자를 이용하여 바로 new하면서 만들어서 리스트에 넣음...
    //        drinklist.Add(new Drink("비타오백", 500));

    //        //####방법2번
    //        //기본생성자라서 생성후에 데이터 세팅하고 그 세팅한 것을 넣어줌...
    //        Drink drink = new Drink();
    //        drink.DrinkName = "포카리";
    //        drink.DrinkPrice = 1200;
    //        drinklist.Add(drink);

    //        drink = new Drink();
    //        drink.DrinkName = "사이다";
    //        drink.DrinkPrice = 700;
    //        drinklist.Add(drink);
    //    }
    //    //Drink 목록 가지기...  //배열이어도 되고 리스트 여도 됩니다

    //    //음료목록 보여주기 함수
    //    public void ShowDrinkList()
    //    {
    //        Console.WriteLine("=======================");
    //        for (int i = 0; i < drinklist.Count; i++)
    //        {
    //            Console.WriteLine((i + 1) + "번째 음료 이름 : " + drinklist[i].DrinkName
    //                + ", 음료의 가격 : " + drinklist[i].DrinkPrice);
    //        }
    //        Console.WriteLine("=======================");
    //    }

    //    //음료 가격 알려주는(반환하는) 함수 (매개변수로 음료 이름)
    //    public int GetDrinkPrice(/*음료 이름*/ string _name)
    //    {
    //        for (int i = 0; i < drinklist.Count; i++) //내가 가진 음료개수만큼 뭔가를 반복함..
    //        {
    //            if (drinklist[i].DrinkName == _name)
    //            {
    //                return drinklist[i].DrinkPrice;
    //            }
    //        }

    //        return -1;
    //    }
    //    //음료 가격 알려주는(반환하는) 함수 (매개변수로 음료 번호)
    //    public int GetDrinkPrice(/*음료 번호*/ int _num)
    //    {
    //        if (_num <= 0 || _num > drinklist.Count)
    //        {
    //            return -1;
    //        }

    //        return drinklist[(_num - 1)].DrinkPrice;
    //    }
    //}

    //class Drink
    //{
    //    public string DrinkName = "";//음료 이름
    //    public int DrinkPrice = 0;//음료 가격
    //    public Drink()
    //    { }

    //    public Drink(string name, int price) //생성자
    //    {
    //        DrinkName = name;
    //        DrinkPrice = price;
    //    }
    //}
    #endregion

    #region 메서드 다시 확인
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        CCC c = new CCC();
    //        CCC d = new CCC();

    //        c.val = 1;
    //        //d.val //1이 되지는 않는다...

    //        //c.VAL3 = 'a'; //읽는것만 가능
    //    }
    //}
    //class BB
    //{
    //    int val;

    //    public BB()
    //    { }

    //    public BB(int val /*매개변수는 내맘대로 가능...*/)
    //    {
    //        this.val = val;
    //    }

    //}

    //class CCC  //클래스 //끝...
    //{
    //    public int val;
    //    protected string val2;
    //    /*private*/ char val3;

    //    public char VAL3 => val3; //private으로 선언한 나의 char val3을 보여는 주겠으나, 값을 바꾸는건 허락하지 않겠음...

    //    public float val4 { /*public*/ get;/*남이 읽는것*/ private set;/*값을 세팅하는것*/ } //private set == 내 클래스 안에서 나만 값을 세팅할것임..


    //    public CCC()
    //    {
    //    }

    //    void AA()
    //    {            
    //    }

    //    public void SetVal4(float _val4)
    //    {
    //        val4 = _val4;
    //    }
    //}

    //class A
    //{
    //    private /*옵션*/ void B(  /*매개변수도 없어서 비워놨음*/)
    //    {
    //    }
    //    public int C ( int _a, int _b) //
    //    {
    //        return _a + _b;
    //    }
    //    public string D(char _a, char _b )
    //    {
    //        string str = "abcde";            
    //        str += _a;
    //        str += _b;            
    //        return str;
    //        //return _a.ToString() + _b.ToString(); //
    //    }

    //}

    #endregion
}