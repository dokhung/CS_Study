using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region 오브젝트풀
//public class Bullet : MonoBehaviour
//{
//    public void Die()
//    {
//        //Destroy(this.gameObject);
//        BulletManager.Instance.ReturnQueue(this);
//    }
//}

//public class BulletManager : MonoBehaviour
//{
//    public static BulletManager Instance = null;
//    public GameObject BulletPrefab; //총알의 원형 데이터..
//                                    //이 게임오브젝트 에는 반드시 Bullet 스크립트와 총알 하나로써 일할 준비가 되어있어야함..
    
//    Queue<Bullet> pool = new Queue<Bullet>();
//    //Queue<GameObject> objpool = new Queue<GameObject>();

//    void Awake()
//    {
//        if (Instance == null)
//        {
//            Instance = this;
//            DontDestroyOnLoad(this.gameObject);
//        }
//        else
//        {
//            if (Instance != this)
//            {
//                Destroy(this.gameObject);
//            }
//        }
//    }
//    void Start()
//    {
//        GameObject _obj;
//        for (int i = 0; i < 20; i++)
//        {
//             _obj = Instantiate(BulletPrefab, this.transform);
//            pool.Enqueue(_obj.GetComponent<Bullet>());
//            //objpool.Enqueue(_obj);
//        }
//    }

//    public Bullet GetObject() //bullet가져오기
//    {
//        if (pool.Count > 0)
//        {
//            return pool.Dequeue();
//        }
//        else
//        {
//            GameObject obj = Instantiate(BulletPrefab, this.transform);
//            return obj.GetComponent<Bullet>();
//        }
//    }

//    public void ReturnQueue(Bullet bullet) //bullet의 등록
//    {
//        pool.Enqueue(bullet);
//        bullet.gameObject.SetActive(false);
//    }
//}

#endregion //생성 관련

public class DesignPattern : MonoBehaviour
{
    #region 실습    
    //옷가게 입니다. 옷을 팝니다.
    //옷은 상의, 하의, 모자, 악세사리. 가 있습니다.

    //악세사리는 착용 불가.
    //모든 옷은 착용을 요청할 수 있습니다. //착용하다 라는 함수 존재. 
    //가격은 주인만 설정 가능하며, 손님은 가격을 물어보는 것 밖에 안됩니다. 
    //가격 변수가 있고, 가격변수 세팅은 그 옷이 처음 만들어질때 만 가능.

    //해당 옷들을 클래스로 만들어보기.

    //인터페이스와 추상클래스 둘다 사용하기.

    #endregion

    public interface INaming1
    {
        void AA(); //public 
        int BB();
    }
    public interface INaming2
    {
        void AA(); //public 
        int BB();
        protected void CC();
        //private void DD(); //private안됨
    }
    public abstract class AbstractClass1
    {
        public int abstractclass1Variable = 0;
        public abstract string A();
        //하나라도 abstract
        public/*protected*/ abstract void B();

        protected void C()
        { 
        }
        void D()
        { 
        }
    }
    public abstract class AbstractClass2
    {
        public abstract string A();
        //하나라도 abstract
        public/*protected*/ abstract void B();
    }

    public class Class1 : AbstractClass1, INaming1, INaming2
    {
        public override string A()
        {
            return "";
        }

        public void AA()
        {
            abstractclass1Variable = 10;
        }

        public override void B()
        {
            //D();
            C();
        }

        public int BB()
        {
            return 0;
        }

        void INaming2.AA()
        {
            
        }

        int INaming2.BB()
        {
            return 0;
        }

        void INaming2.CC()
        {
            
        }
    }

        
    // ====== 인터페이스와 추상클래스 차이..======= 

    // 공통점 : 반드시 그 함수가 존재함...
    // 차이점 : 인터페이스 == 함수만 존재함/여러개 붙일 수 있음/프라이빗 선언이 아예 안됨
    //          추상클래스 == 변수도 함수도 존재함. 일부 함수는 없을 수도 있음(프라이빗 선언 가능.). /타 클래스 상속을 붙일 수 없음...


    #region  데코레이터 패턴

    //public struct Point
    //{ 
    //    public int x { get; set; }
    //    public int y { get; set; }
    //    public Point(int x, int y)
    //    {
    //        this.x = x;
    //        this.y = y;
    //    }
    //}

    //public abstract class Shape //
    //{
    //    public abstract void Draw(string a);
    //    public Point point { get; set; }
    //    public int width { get; set; }
    //    public int height { get; set; }
    //}

    //public class Circle : Shape
    //{
    //    public Circle(Point pos, int radius)
    //    {
    //        point = pos;
    //        width = radius * 2;
    //        height = radius * 2;
    //    }
    //    public override void Draw(string a)
    //    {
    //        Debug.Log("원 Draw : " + a);
    //    }
    //}
    //public class Square : Shape
    //{
    //    public Square(Point pos, int width, int height)
    //    {
    //        point = pos;
    //        this.width = width;
    //        this.height = height;
    //    }
    //    public override void Draw(string a)
    //    {
    //        Debug.Log("t네모 Draw : " + a);
    //    }
    //}
    ////=====================
    //public abstract class ShapeDecorator : Shape
    //{
    //    protected Shape component;
    //    public ShapeDecorator(Shape _shape)
    //    {
    //        component = _shape;
    //    }
    //}
    //public class FillShapeDecorator : ShapeDecorator
    //{
    //    public string color = "빨강";
    //    public FillShapeDecorator(Shape shape) :base(shape)
    //    { 
    //    }
    //    public override void Draw(string a)
    //    {
    //        Debug.Log(color);
    //        component.Draw(a);
    //        Debug.Log("데코레이터입니다");
    //    }
    //}

    //void Start()
    //{
    //    Shape shape = new Circle(new Point(10,10), 5 );
    //    var deco = new FillShapeDecorator(shape);
    //    deco.Draw("첫 원");

    //    Shape shape2 = new Square(new Point(5, 5), 10,20);
    //    deco = new FillShapeDecorator(shape2);
    //    deco.color = "파랑";
    //    deco.Draw("네모");
    //}
    #endregion

    #region 복합체 패턴
    //public abstract class Node
    //{ 
    //    public string Name { get; protected set; }        
    //    public abstract void Display();
    //}

    //public class File : Node
    //{
    //    public File(string name)
    //    {
    //        this.Name = name;
    //    }
    //    public override void Display()
    //    {
    //        Debug.Log("파일 이름 : " + Name);
    //    }
    //}

    //public class Directory : Node
    //{
    //    List<Node> list = new List<Node>();
    //    public Directory(string name)
    //    {
    //        this.Name = name;
    //    }
    //    public void AddChild(Node child)
    //    {
    //        if (child !=null)
    //        {
    //            list.Add(child);
    //        }
    //    }
    //    public override void Display()
    //    {
    //        Debug.Log("===========================================");
    //        Debug.Log("디렉토리 이름 : " + Name  + "안에 든 파일 출력");
    //        Debug.Log("--------------------------------------------");
    //        for (int i = 0; i < list.Count; i++)
    //        {                
    //            list[i].Display();
    //        }
    //        Debug.Log("===========================================");
    //    }
    //}

    //void Start()
    //{
    //    Directory dir = new Directory("첫폴더");
    //    File file1 = new File("파일1");
    //    File file2 = new File("파일2");
    //    File file3 = new File("파일3");

    //    Directory dir2 = new Directory("두번째폴더");
    //    File file4 = new File("파일4");
    //    File file5 = new File("파일5");

    //    dir.AddChild(file1);
    //    dir.AddChild(file2);
    //    dir.AddChild(file3);
    //    dir.AddChild(dir2);
    //    dir2.AddChild(file4);
    //    dir2.AddChild(file5);

    //    dir.Display();
    //}
    #endregion

    #region 브릿지 패턴

    //public interface IImplementor //구현체
    //{
    //    void ImplementorOperation();
    //}

    //public abstract class Abstraction  //추상층
    //{  
    //    public IImplementor Implementor { get; set; }
    //    public abstract void Operation();
    //}
    //public class RefinedAbstraction : Abstraction //추상층 구현부분
    //{
    //    public override void Operation()
    //    {
    //        Implementor.ImplementorOperation(); //함수1과 함께
    //        //다른 하고싶은작업 구현 또 가능....
    //    }
    //}

    //public class ConcreteImplementor : IImplementor //구현체의 구현부분
    //{
    //    public void ImplementorOperation()
    //    {
    //        //내용 구현...
    //        Debug.Log("1번내용~~~~~");
    //    }
    //}
    //public class ConcreteImplementor2 : IImplementor //구현체의 구현부분
    //{
    //    public void ImplementorOperation()
    //    {
    //        //내용 구현...
    //        Debug.Log("2번내용~~~~~");
    //    }
    //}

    //void Start()
    //{
    //    Abstraction abstraction = new RefinedAbstraction(); //구체화한 추상층..
    //    abstraction.Implementor = new ConcreteImplementor();
    //    abstraction.Operation(); //이걸로 실행

    //    abstraction.Implementor = new ConcreteImplementor2();
    //    abstraction.Operation(); //이걸로 실행
    //}
    #endregion

    #region 어댑터 패턴
    //public interface IConverting
    //{
    //    void DoConvert();
    //}
    //public class Adaptee //기존에 있던 친구...
    //{
    //    public void AdapteeRequest()
    //    {
    //        Debug.Log("이미 여기저기서 쓰고 있고 잘되고있었음. 더이상 굳이 원본이 늘어날 필요는 없음...");
    //    }
    //}

    //public class Adapter : Adaptee, IConverting //클래스 어댑터 형식
    //{
    //    public void DoConvert()
    //    {
    //        base.AdapteeRequest(); //기존 기능
    //        Debug.Log("기존 기능도 쓰고.. ");
    //        Debug.Log("내가 좀더 기능을 뭔가 ㅁ붙이고 싶엇던 작업~~~~~");
    //    }
    //}
    //public class Adapter2 : IConverting  //오브젝트 어댑터 형식
    //{
    //    Adaptee adaptee = new Adaptee();
    //    public void DoConvert()
    //    {
    //        adaptee.AdapteeRequest();
    //        Debug.Log("새로이 오브젝트 어댑터 방식으로 기존 기능을 확장시켜서 쓰고싶었던것임...");
    //    }
    //}

    //void Start()
    //{
    //    Adapter2 adapter = new Adapter2();
    //    adapter.DoConvert();

    //    IConverting converting;
    //    converting = new Adapter();
    //    converting.DoConvert();
    //}
    #endregion

    //================생성

    #region 프로토타입 패턴
    //public abstract class Prototype
    //{
    //    public abstract Prototype Clone();
    //    public string PrototypeStr { get; protected set; }
    //    public void SetPrototypeStrData(string val)
    //    {
    //        this.PrototypeStr = val; 
    //    }
    //}

    //public class InheritPrototype : Prototype
    //{
    //    public InheritPrototype(string val)
    //    {
    //        PrototypeStr = val;
    //    }
    //    public override Prototype Clone()
    //    {
    //        return (Prototype)this.MemberwiseClone(); //닷넷에서 제공하는.. 객체를 얕은 복사하는 메서드 입니다.. 
    //    }
    //}
    //public class InheritPrototype2 : Prototype
    //{
    //    public InheritPrototype2(string val)
    //    {
    //        PrototypeStr = val;
    //    }
    //    public override Prototype Clone()
    //    {
    //        return (Prototype)this.MemberwiseClone(); //닷넷에서 제공하는.. 객체를 얕은 복사하는 메서드 입니다.. 
    //    }
    //}
    //void Start()
    //{        
    //    Prototype proto = new InheritPrototype("상속받은 프로토타입1번");        
    //    var clone1 = proto.Clone(); 
    //    clone1.SetPrototypeStrData("프로토타입1번의 클론입니다");

    //    Prototype proto2 = new InheritPrototype2("상속받은 프로토타입2번");

    //    Debug.Log("InheritPrototype 의 클래스와 그 클래스의 클론이 같은지 여부" + (proto == clone1));
    //    Debug.Log("InheritPrototype 의 클래스와 proto2가 같은지 여부" + (proto == proto2));
    //    Debug.Log("클론 클래스와 proto2가 같은지 여부" + (clone1 == proto2));

    //    Debug.Log("프로토1번" +proto.PrototypeStr);
    //    Debug.Log("클론" + clone1.PrototypeStr);
    //    Debug.Log("프로토2번" + proto2.PrototypeStr);
    //}
    #endregion

    #region 추상팩토리메서드 => 생성에 큰 신경을 쓰지 않고 바로 묶음으로 생성처리 위한...
    //public class ProductA 
    //{ }
    //public class ConcreteProductA_1 : ProductA
    //{ }
    //public class ConcreteProductA_2 : ProductA
    //{ }
    //public class ProductB
    //{ }
    //public class ConcreteProductB_1 : ProductB
    //{ }
    //public class ConcreteProductB_2 : ProductB
    //{ }

    //public abstract class AbstractFactory
    //{
    //    public abstract ProductA CreateProductA();
    //    public abstract ProductB CreateProductB();
    //}

    //public class ConcreteFactory1 : AbstractFactory
    //{
    //    public override ProductA CreateProductA()
    //    {
    //        return new ConcreteProductA_1();
    //    }

    //    public override ProductB CreateProductB()
    //    {
    //        return new ConcreteProductB_1();
    //    }
    //}
    //public class ConcreteFactory2 : AbstractFactory
    //{
    //    public override ProductA CreateProductA()
    //    {
    //        return new ConcreteProductA_2();
    //    }

    //    public override ProductB CreateProductB()
    //    {
    //        return new ConcreteProductB_2();
    //    }
    //}

    //void Start()
    //{
    //    AbstractFactory factory = new ConcreteFactory1();
    //    ProductA a = factory.CreateProductA();
    //    ProductB b = factory.CreateProductB();
    //}
    #endregion

    #region 팩토리 메서드 패턴

    //public enum EFactory
    //{ 
    //    AA,
    //    BB,

    //    End
    //}
    //public class FactoryMethodClass
    //{ }

    //public interface IFactoryMethod
    //{ }
    //public class AA : FactoryMethodClass
    //{ 
    //}
    //public class BB : FactoryMethodClass
    //{
    //}
    //public class FactoryMethodCreatorClass
    //{
    //    public static FactoryMethodClass Create(EFactory efactory)
    //    {
    //        FactoryMethodClass factory = null;
    //        switch (efactory)
    //        {
    //            case EFactory.AA:
    //                factory = new AA();
    //                break;
    //            case EFactory.BB:
    //                factory = new BB();
    //                break;
    //            case EFactory.End:
    //                break;
    //            default:
    //                break;
    //        }
    //        return factory;
    //    }
    //}
    #endregion

    #region 빌더 패턴
    //public interface Ibuilder //인터페이스 또는 추상클래스. 뭐가됐건 최상위 부모 클래스 +꼭 구현해야하는...
    //{ 
    //}

    //public class ConcreteBuilderClass : Ibuilder
    //{ 
    //}
    //public class ProductClass //실제 제품 클래스
    //{ 
    //}

    //public class DirectorClass
    //{ 
    //}

    ////=================

    //public interface IBuilder_Bed
    //{
    //    IBuilder_Bed MakeFrame(string frame);
    //    IBuilder_Bed MakeMattress(string mattress);
    //    IBuilder_Bed MakeSheet(string sheet);
    //    IBuilder_Bed MakePillow(int count);
    //    Product_Bed Build();
    //}

    //public class Product_Bed
    //{ 
    //    public string Frame { get; set; }
    //    public string Mattress { get; set; }
    //    public string Sheet { get; set; }
    //    public int Pillow { get; set; }
    //    public override string ToString()
    //    {            
    //        return $"프레임 : {Frame} ,\n 매트리스 : {Mattress} ,\n 시트 : {Sheet} ,\n 베개 : {Pillow} \n";
    //    }
    //}

    //public class ConcreteBuilder_Bed : IBuilder_Bed  //빌더 단계의 구체적 구현... 내가 구현해야할 필드들 초기화
    //{
    //    Product_Bed bed = new Product_Bed();
    //    public Product_Bed Build() //살짝 생성자...
    //    {
    //        return bed;
    //    }

    //    public IBuilder_Bed MakeFrame(string frame)
    //    {
    //        bed.Frame = frame;
    //        return this;
    //    }

    //    public IBuilder_Bed MakeMattress(string mattress)
    //    {
    //        bed.Mattress = mattress;
    //        return this;
    //    }

    //    public IBuilder_Bed MakeSheet(string sheet)
    //    {
    //        bed.Sheet = sheet;
    //        return this;
    //    }

    //    public IBuilder_Bed MakePillow(int count)
    //    {
    //        bed.Pillow = count;
    //        return this;
    //    }
    //}

    //public class Director //핵심 객체의 반환
    //{
    //    public Product_Bed CreateBed_simons(IBuilder_Bed builder)
    //    {
    //        builder.MakeFrame("시몬스 프레임");
    //        builder.MakeMattress("시몬스 매트리스");
    //        builder.MakeSheet("시몬스 시트");

    //        Product_Bed bed = builder.Build();
    //        return bed;
    //    }
    //    public Product_Bed CreateBed_ace(IBuilder_Bed builder)
    //    {
    //        builder.MakeMattress("에이스 매트리스");
    //        builder.MakeSheet("에이스 시트");
    //        builder.MakePillow(2);
    //        Product_Bed bed = builder.Build();
    //        return bed;
    //    }       
    //}

    //void Start()
    //{
    //    IBuilder_Bed builder = new ConcreteBuilder_Bed();
    //    Director director = new Director();
    //    Product_Bed simons = director.CreateBed_simons(builder);
    //    builder = new ConcreteBuilder_Bed();
    //    Product_Bed ace = director.CreateBed_ace(builder);
    //    builder = new ConcreteBuilder_Bed();
    //    Product_Bed custom = builder.MakeFrame("비싼프레임").MakeMattress("폭신한 매트리스").Build();

    //    Debug.Log($"시몬스 내용 :  {simons.ToString()}" );
    //    Debug.Log($"에이스 내용 :  {ace.ToString()}");
    //    Debug.Log($"커스텀 내용 :  {custom.ToString()}");
    //}

    #endregion

    #region 싱글톤 패턴 예제
    //public class GameManager : MonoBehaviour
    //{
    //    public static GameManager Instance = null;
    //    void Awake()
    //    {
    //        if (Instance == null)
    //        {
    //            Instance = this;
    //            DontDestroyOnLoad(this.gameObject);
    //        }
    //        else
    //        {
    //            if (Instance != this)
    //            {
    //                Destroy(this.gameObject);
    //            }
    //        }
    //    }
    //}

    #endregion
}