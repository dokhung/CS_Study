using System;
using System.Collections.Generic;
using System.Text;

namespace NCS_Start_202310
{
    #region 실습2

    //앵무새, 고양이 , 개 ... 앵무새를 반드시 포함하여 3개이상의 클래스를 만든다.
    //각 동물들은 울음소리를 내는 함수가 있다.
    //이 함수는 매개변수로 int를 받고, 해당 매개변수는 울음의 횟수가 된다. ex) 원래는 멍 이 기본이면 멍xcount횟수 출력
    //해당 매개변수의 횟수만큼 반복하여 울음 출력하기

    //앵무새는 울다라는 함수로
    //본인의 울음소리와
    //고양이, 개 같은 타 클래스의 우는 함수를 매개변수로 받아서 다른 소리도 흉내낼 수 있음.


    //delegate / Func / Action 셋중에 하나이상 활용하여 만들기

    class Animal
    {
        protected string Animsound = "";
        public Animal(string val)
        {
            Animsound = val;
        }
        public void AnimalCry(int count)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                builder.Append(Animsound);
            }

            Console.WriteLine(builder.ToString());
        }
    }
    public delegate void CryDelegate(int val); //

    class Parrot : Animal
    {
        public Parrot(string val = "") : base(val)
        {
            if (string.IsNullOrEmpty(val))
            {
                Animsound = "앵";
            }
        }
        public void AnimalCry(Action<int> crydel, int count)
        {
            if (crydel != null)
            {
                crydel(count);
            }
        }

        public void AnimalCry2(CryDelegate crydel, int count)
        {
            if (crydel != null)
            {
                crydel(count);
            }
        }
    }

    class Cat : Animal
    {
        public Cat(string val = "") : base(val)
        {
            if (string.IsNullOrEmpty(val))
            {
                Animsound = "야옹";
            }
        }
    }

    class Dog : Animal
    {
        public Dog(string val = "") : base(val)
        {
            if (string.IsNullOrEmpty(val))
            {
                Animsound = "멍";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Parrot parrot = new Parrot("안녕");
            Cat cat = new Cat();
            Dog dog = new Dog();

            Console.WriteLine("앵무새가 웁니다 : ");
            parrot.AnimalCry(3);
            Console.WriteLine("앵무새가 Cat의 울음소리를 흉내냅니다 : ");
            parrot.AnimalCry2(cat.AnimalCry, 5);
            Console.WriteLine("앵무새가 Dog의 울음소리를 흉내냅니다 : ");
            parrot.AnimalCry(dog.AnimalCry, 2);
        }
    }

    #endregion

    #region 무명메서드 익명메서드
    //public delegate string StringDelegate(string val);
    //public delegate int SquareDelegate(int val);
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        StringDelegate outfunc = delegate (string str)
    //        {
    //            return str;
    //        };

    //        Console.WriteLine( outfunc("Hello world"));

    //        SquareDelegate square = delegate (int val)
    //        {
    //            return val * val;
    //        };

    //        Console.WriteLine(square(5));

    //    }
    //}
    #endregion

    #region 람다 예제

    //class AA
    //{
    //    public void BBB(Func<float,string> func, float val) 
    //        //BBB가 매개변수로 string을 반환하고 매개변수로 float을 필요로 하는 메서드를 받을 수 있고,
    //        //그 메서드의 매개변수로 넣어줄 float val도 받기로 한 것..
    //    {
    //        Console.WriteLine(func(val)); //매개변수로 받은 val을 매개변수로 받은 함수 func에 넣어서 실행.
    //    }
    //}

    //class Program
    //{        

    //    static void Main(string[] args)
    //    {
    //        //Func<string> stringFunc1 = () => "Hello, World";

    //        //Console.WriteLine(stringFunc1());

    //        //Func<int, int> intFunc1  //매개변수로 int를 받는 int형 반환 함수
    //        //    = (int x) => 10 * x; //그 int x가 들어온다면 10* x를 반환하겠음
    //        //Console.WriteLine(intFunc1( 10 ));

    //        ////Func<float, string>
    //        //AA aa = new AA();
    //        //Action<Func<float, string>, float> actionsample = aa.BBB;

    //        //actionsample( (/*float*/ x) => x.ToString() , 10.1234f );

    //        Action<int,int> act1 = (int x, int y) => 
    //        {
    //            x *= 2;
    //            y += 2;
    //            Console.WriteLine("2x = " + x + ", y+2 = " + y );
    //        };
    //        act1(10, 10);            
    //    }
    //}

    #endregion

    #region Predicate 예제
    ////Predicate는 리턴형이 반드시 bool 이어야 하고, 입력 파라미터도 1개로 제한됨...
    //class PredicateSample
    //{
    //    //predicate로 부를 함수 만들기. 매개변수 하나... 
    //    public bool AAA(int b)
    //    {
    //        return b % 2 == 0;
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        PredicateSample sample = new PredicateSample();
    //        //PredicateSample 안의 만든 함수 두개 Predicate 이용해서 불러보기
    //        Predicate<int> aaa = sample.AAA;
    //        Console.WriteLine("Predicate<int> aaa 를 3을 넣어 부름 : " + aaa(3));
    //        Console.WriteLine("Predicate<int> aaa 를 4을 넣어 부름 : " + aaa(4));
    //    }
    //}

    #endregion

    #region Func 예제
    ////Func<T1, T2,,.... , TResult> 
    ////Func<int, int, string, 무조건 반환형이 반드시 있어야함...>

    //class FuncSample
    //{
    //    public bool GetJustBool(int x, int y)
    //    {
    //        return x > y;
    //    }
    //    public int GetJustInt(int x)
    //    {
    //        return x * 2;
    //    }
    //    public string GetJustString(string val, int val2)
    //    {
    //        return val + val2;
    //    }
    //    public void VoidFunc(float val)
    //    {
    //        Console.WriteLine(val+"이 들어온 함수" );
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        FuncSample funcsample = new FuncSample();
    //        Func<int, int, bool> returnboolFunc = funcsample.GetJustBool;
    //        Console.WriteLine("returnboolFunc(10, 5) 를 부름" + returnboolFunc(10, 5));

    //        Func<int, int> returnintFunc = funcsample.GetJustInt;
    //        Console.WriteLine("returnintFunc(6) 를 부름" + returnintFunc(6));

    //        //GetJustString 변수에 담아서 불러보기
    //        Func<string, int,string> returnStringFunc = funcsample.GetJustString;
    //        Console.WriteLine("returnStringFunc(\"문자열\",6) 를 부름" + returnStringFunc("문자열",6));

    //        //VoidFunc 변수에 담아서 불러보기
    //        Action<float> actionFunc = funcsample.VoidFunc;
    //        actionFunc(0.1f); //반환형이 없어서 이 함수 자체를 console.writeline에서 부를수없음....
    //    }
    //}

    #endregion

    #region Action 예제

    ////Action 은  void 형의 delegate와 동일하다.

    //class Program
    //{
    //    static int x = 0;
    //    static int y = 0;
    //    static void Print(string msg)
    //    {
    //        Console.WriteLine(msg);
    //    }

    //    static void Print2(int val1, int val2)
    //    {
    //        Console.WriteLine("val1의 값 : " + val1 + ", val2의값" + val2);
    //    }
    //    static void Func(Action<string> method, string _msg )
    //    {
    //        method(_msg);
    //    }
    //    static void Func2(Action<int, int> method)
    //    {
    //        method(x, y);
    //    }
    //    static void Main(string[] args)
    //    {
    //        //Func(Print, "메세지");
    //        //Func(Console.WriteLine, "동일한 효과");
    //        x = 10;
    //        y = 20;
    //        Func2(Print2);
    //    }
    //}

    #endregion

    #region 이벤트1
    ////이벤트는 보통 버튼 같은 곳에 이미 구현되어있음....

    //public delegate void ShowDelegate(string msg);    

    //class EventSample
    //{
    //    public ShowDelegate forEventDel;
    //    public event ShowDelegate eventDel;

    //    public void ShowEventSample2()
    //    {
    //        Console.WriteLine("ShowEventSample2 함수입니다 ");

    //        if (forEventDel != null)
    //        {
    //            forEventDel("변수로 가지고 있던 ShowDelegate 로 그냥 부른..");
    //        }          
    //    }
    //    public void ShowEventSample(ShowDelegate showdel = null)
    //    {
    //        Console.WriteLine("ShowEventSample 함수입니다 ");

    //        if (showdel != null)
    //        {
    //            showdel("ShowDelegate 로 그냥 부른..");
    //        }
    //        else
    //        {
    //            if (eventDel != null)
    //            {
    //                eventDel("ShowEventSample 함수에서 eventDel 실행함 ");
    //            }
    //        }                
    //    }
    //}

    //class Program
    //{
    //    static void FuncInProgram(string msg)
    //    {
    //        Console.WriteLine("FuncInProgram 이고 매개변수 메세지 출력 : " + msg);
    //    }
    //    static void Main(string[] args)
    //    {
    //        EventSample evsample = new EventSample();
    //        evsample.eventDel += FuncInProgram; //이벤트는 등록을 무조건 += 이걸루 함.. 

    //        evsample.forEventDel = FuncInProgram; // 이 변수에 얘를 담겠다 라는 뜻
    //        evsample.forEventDel += FuncInProgram; //이렇게 되면 체인 하겠다는 의미가 크고
    //        evsample.forEventDel -= FuncInProgram; //이렇게 되면 체인에서 빼겠다는 의미

    //        evsample.ShowEventSample();
    //        evsample.ShowEventSample(evsample.forEventDel);
    //        evsample.ShowEventSample(FuncInProgram);

    //        evsample.ShowEventSample2();
    //    }
    //}
    #endregion

    #region 델리게이트 제네릭됨

    //public delegate T MyDelegate<T>(T x, T y);

    //class Program
    //{
    //    static void Calculator<T>(T n1, T n2, MyDelegate<T> del )
    //    {
    //        Console.WriteLine(del(n1, n2));
    //    }
    //    static int Plus(int x, int y)
    //    { return x + y; }
    //    static float Plus(float x, float y)
    //    { return x + y; }
    //    static string Plus(string x, string y)
    //    { return x + y; }

    //    static void Main(string[] args)
    //    {
    //        MyDelegate<string> Plus_string = new MyDelegate<string>(Plus);
    //        Calculator(1,2, Plus);
    //        Calculator(10f, 20f, Plus);
    //        Calculator("스트링", "형식", Plus);
    //        Calculator("윗줄과", " 동일", Plus_string);
    //    }
    //}

    #endregion

    #region 델리게이트 실습1
    ////// 사람클래스와 개 클래스 만들어서 
    ////// 사람은 그냥 나간다는 함수이고 //그냥 출력이면됨. void여도됨.
    ////// 변수로 함수(개가 산책한다는 함수) 받을 수 있고, bool을 줘서
    ////// bool은 사람이 혼자 나갈건지, 개랑 같이 나갈건지 여부고
    ////// 함수는 개가 산책한다는 내용 => 출력하면됨. void여도 됨

    ////// 메인에서 사람 혼자 나가는 것 출력하고, 사람과 개가 같이 나가는것도 출력할 것.

    ////// 사람이 나가는걸 호출할건데 매개변수로    개 산책(함수),     bool 혼자 나가는지, 아닌지 여부를       매개변수로 넘겨서 호출

    //public delegate void TakeAwalkDelegate(); //아무것도 반환안하는, 매개변수도 없는 함수를 담을 준비가 된 변수.
    //public class Person
    //{
    //    public void GoOut(bool _alone, TakeAwalkDelegate Takeawalk)
    //    {
    //        Console.WriteLine("사람이 나간다");
    //        if (_alone == false)
    //        {
    //            Takeawalk();
    //            //Dog dog = new Dog(); //이안에서 생성하지 않고도, 다른 클래스의 함수를 사용할 수 있음.
    //            //dog.TakeAwalk();
    //        }
    //    }
    //    void SampleFunc()
    //    {
    //        Console.WriteLine("이거 가능");
    //    }
    //    public TakeAwalkDelegate AAAA(bool turnback)
    //    {
    //        Console.WriteLine("사람 클래스 안의 AAAA함수입니다. 변수로 turnback : " + turnback + "을 받았습니다");
    //        if (turnback)
    //        {
    //            Console.WriteLine("SampleFunc 부를 예정");
    //            return SampleFunc;
    //        }
    //        else
    //        {
    //            Console.WriteLine("돌려줄거없어");
    //            return null;
    //        }
    //    }
    //}

    //public class Dog
    //{
    //    public void TakeAwalk()
    //    {
    //        Console.WriteLine("개가 산책한다");
    //    }

    //    public void BBBB(TakeAwalkDelegate bbb)
    //    {
    //        Console.WriteLine("개의 BBBB함수입니다");
    //        if (bbb!=null)
    //        {
    //            Console.WriteLine("전달받은 TakeAwalkDelegate 델리게이트 실행");
    //            bbb();
    //        }
    //        else
    //        {
    //            Console.WriteLine("전달받은 함수가 없습니다.");
    //        }
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Person person = new Person();
    //        Dog dog = new Dog();

    //        //Console.WriteLine("사람이 혼자 나갈것임");
    //        //person.GoOut(true, dog.TakeAwalk);

    //        //Console.WriteLine("사람이 산책나간다");
    //        //person.GoOut(false, dog.TakeAwalk);

    //        dog.BBBB(person.AAAA(true));

    //        Console.WriteLine();
    //        dog.BBBB(person.AAAA(false));
    //    }
    //}

    #endregion

    #region 델리게이트 3

    //class Sorting
    //{
    //    public delegate int CompareDelegate(int num1, int num2);

    //    public static void Sort(int[] arr, CompareDelegate comp /*비교함수. 오름차순 또는 내림차순 에 맞게 판별해줄것임*/)
    //    {
    //        if (arr.Length < 2) //하나짜리라면 소팅할 수 없어서 돌려보냄
    //        {
    //            return;
    //        }
    //        int val;
    //        for (int i = 0; i < arr.Length-1; i++)
    //        {
    //            for (int j = i+1; j < arr.Length; j++)
    //            {
    //                val = comp(arr[i], arr[j]);
    //                if (val == -1) //
    //                {
    //                    //교환 필요
    //                    int tmp = arr[j];
    //                    arr[j] = arr[i];
    //                    arr[i] = tmp;
    //                }
    //            }
    //        }

    //        Display(arr);
    //    }

    //    static void Display(int[] arr) //배열 바뀐거 확인용
    //    {
    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            Console.Write(arr[i]);
    //            if (i< arr.Length -1)
    //            {
    //                Console.Write(",");
    //            }                
    //        }
    //        Console.WriteLine();
    //    }
    //}

    //class Program
    //{
    //   static int AscendingCompare(int num1, int num2) //오름차순. 두 수를 비교했을때, 앞의 수가 뒤의 수보다 크다면 잘못됐으므로 -1을 반환.
    //    {
    //        if (num1 == num2)
    //        {
    //            return 0;
    //        }
    //        else
    //            return num2 - num1 > 0 ? 1 : -1;
    //    }

    //    static int DescendingCompare(int num1, int num2) //내림차순. 두 수를 비교해서, 앞의 수가 뒤의 수보다 커야함.
    //    {
    //        if (num1 == num2)
    //        {
    //            return 0;
    //        }
    //        else
    //            return num2 - num1 > 0 ? -1 : 1;
    //    }

    //    static void Main(string[] args)
    //    {
    //        int[] arr = new int[6] { 7,1,5, 9, 3,8};

    //        Console.WriteLine("오름차순 정렬 시도");
    //        Sorting.CompareDelegate sortdel = AscendingCompare;
    //        Sorting.Sort(arr, sortdel);    

    //        Console.WriteLine("내림차순 정렬 시도");
    //        Sorting.Sort(arr, DescendingCompare);
    //    }
    //}
    #endregion

    #region 델리게이트2

    //public enum EOperator
    //{
    //    PLUS, 
    //    MINUS,
    //    MULTI,
    //    DIVIDE,

    //    END
    //}

    //public class Mathmatics
    //{
    //    public delegate int CalDelegate(int x, int y);

    //    CalDelegate[] delArr;
    //    Dictionary<EOperator, CalDelegate> delDic = new Dictionary<EOperator, CalDelegate>();

    //    public static void AA()
    //    { }
    //    public Mathmatics()
    //    {
    //        delArr = new CalDelegate[4] { Plus, Minus, Multiply, Divide } ;
    //        //int a=  delArr[0](1,2);  //이런식으로 Plus 사용 가능.

    //        delDic.Add(EOperator.PLUS, Plus);
    //        delDic.Add(EOperator.MINUS, Minus);
    //        delDic.Add(EOperator.MULTI, Multiply);
    //        delDic.Add(EOperator.DIVIDE, Divide);
    //    }

    //    public void Calculate(EOperator _oper, int x, int y)
    //    {
    //        Console.WriteLine("배열에 담긴 함수를 부른 결과 : " + delArr[(int)_oper](x,y));

    //        Console.WriteLine("딕셔너리로 부른 결과 : " + delDic[_oper](x, y)); //_oper를 바로 키로 쓸 수 있기때문에 switch로 굳이 판별 안해도 됨

    //    }

    //    public int Calculate(CalDelegate caldel, int x, int y)
    //    {
    //        return caldel(x,y);
    //    }

    //    public int Plus(int x, int y)
    //    {
    //        Console.WriteLine("Plus 함수 : " + (x + y));
    //        return x + y;
    //    }
    //    public int Minus(int x, int y)
    //    {
    //        Console.WriteLine("Minus 함수 : " + (x - y));
    //        return x - y;
    //    }
    //    public int Multiply(int x, int y)
    //    {
    //        Console.WriteLine("Multiply 함수 : " + (x * y));
    //        return x * y;
    //    }
    //    public int Divide(int x, int y)
    //    {
    //        Console.WriteLine("Divide 함수 : " + (x / y));
    //        return x / y;
    //    }
    //}

    //class Program
    //{
    //    delegate void MathmaticsDelegate(EOperator _oper, int x, int y);
    //    delegate int CalculDelegate(int x, int y);

    //    public static int Remain(int x, int y)
    //    {
    //        return x % y;
    //    }

    //    static void Main(string[] args)
    //    {
    //        Mathmatics mathm = new Mathmatics();
    //        MathmaticsDelegate mathdel = mathm.Calculate;
    //        Console.WriteLine("MathmaticsDelegate 형식의 mathdel을 부름. 인자로 EOperator.PLUS, 1, 2 주었음");
    //        mathdel(EOperator.PLUS, 1, 2);

    //        Console.WriteLine("MathmaticsDelegate 형식의 mathdel을 부름. 인자로 EOperator.MINUS, 10, 4 주었음");
    //        mathdel(EOperator.MINUS, 10, 4);
    //        Console.WriteLine("MathmaticsDelegate 형식의 mathdel을 부름. 인자로 EOperator.Multi, 3, 6 주었음");
    //        mathdel(EOperator.MULTI, 3, 6);
    //        Console.WriteLine("MathmaticsDelegate 형식의 mathdel을 부름. 인자로 EOperator.divide, 20, 5 주었음");
    //        mathdel(EOperator.DIVIDE, 20, 5);

    //        Console.WriteLine("Mathmatics 클래스의 Calculate를 불러 매개변수로 나의 Remain을 넣었음 " +
    //            mathm.Calculate(Remain, 10, 3));

    //        Console.WriteLine("델리게이트 체인 확인");

    //        CalculDelegate calculdel = mathm.Plus;
    //        calculdel += mathm.Minus;
    //        calculdel += mathm.Multiply;
    //        calculdel += mathm.Divide;
    //        calculdel(10,5);

    //        Console.WriteLine("델리게이트 체인에서 함수를 빼보겠음");

    //        calculdel -= mathm.Multiply;
    //        calculdel -= mathm.Divide;
    //        calculdel(10, 5);


    //        Console.WriteLine("델리게이트 체인에 빼기 함수 두번 추가함");
    //        calculdel += mathm.Minus;
    //        calculdel += mathm.Minus;

    //        //이렇게 생각지못한 같은 함수가 여러번 작용하는 일이 생길 수 있어서, 델리게이트 체인은 위험함
    //        calculdel(10, 5);
    //    }
    //}

    #endregion

    #region 델리게이트 1
    //delegate string DelegateSample1(int a); //매개변수로 int를 받고, string을 반환하는 메서드를 담을 준비가 된 델리게이트.
    //class Program
    //{
    //    static string AAA(int _a)
    //    {
    //        Console.WriteLine("이건 AAA 함수입니다 ");
    //        return _a.ToString();
    //    }
    //    static void BBB(int b)
    //    {
    //        Console.WriteLine("이건 BBB 함수입니다");
    //    }
    //    static void Main(string[] args)
    //    {
    //        DelegateSample1 delsample = AAA;
    //        //delsample = BBB;

    //        Console.WriteLine("delsample 호출 : " + delsample(999) );
    //    }
    //}
    #endregion

}