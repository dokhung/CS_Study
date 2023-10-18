using System;
using System.Collections.Generic;
//using System.Text;
//using ExtensionMethods; //확장메서드 사용용...

namespace NCS_Start_202310
{
    #region 실습2. 구조체와 ref와 out의 사용
    //점의 좌표값을 표시할 구조체 선언 ( 예를들어 int x, int y  를 멤버변수로 갖는 형식)

    //사용자가 사각형을 이룰 한 점의 좌표와 사각형의 가로길이, 세로길이를 입력했을때
    //나머지 꼭짓점 세 개에 대한 좌표를 출력하기 //3개의 함수
    //단, 한번은 구조체로 반환하는 함수
    //한번은 void형이고, ref 키워드로 좌표를 받는 함수
    //한번은 void형이고 out 키워드로 좌표를 받는 함수

    //이렇게 사각형을 이루는 네 좌표를 모두 출력하기
    struct Point //구조체 선언
    {
        public int x;
        public int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Program
    {
        static Point GetLeftTop(Point firstPoint, int width, int height )
        {
            //1번 방법
            Point point = new Point(); //기본생성자를 사용한 경우
            point.x = firstPoint.x;
            point.y = firstPoint.y + height;
            return point;

            //2번방법
            firstPoint.y += height; //어차피 firstPoint 요 변수는 본문의 원래 point에 영향을 미치지 않으므로 괜찮음
            return new Point(firstPoint.x, firstPoint.y); //내가 선언한 생성자 사용.
        }
        //ref를 사용하는 경우 두가지 방법
        static void GetRightBottom(ref Point firstPoint, int width, int height)//1번방법 원래 플레이어가 입력했던 그 좌표를 참조하겠음.
        {
            firstPoint.x += width; //원본에 영향을 끼침
        }
        static void GetRightBottom( Point firstPoint, int width, int height, ref Point resultPoint) //2번방법 결과점을 참조하여 수정하겟음
        {
            //2번방법은 원래 사용자가 입력한 점을 수정하지 않으므로 좀더 안전함.. 원래 정보를 바꾸지 않음
            resultPoint = new Point(firstPoint.x + width, firstPoint.y);
        }

        static void GetRightTop(Point editedPoint, int width, int height, out Point resultPoint) //1번방법에서 수정당한 firstPoint를 그대로 넣는다면..
        {
            //방법 1 내가 추가한 생성자를 사용
            resultPoint = new Point(editedPoint.x , editedPoint.y + height);

            ////방법2 기본생성자를 사용
            //resultPoint = new Point();
            //resultPoint.x = editedPoint.x;
            //resultPoint.y = editedPoint.y + height;
        }
        static void GetRightTop2(Point firstPoint, int width, int height, out Point resultPoint) //2번방법에서 수정없이 firstPoint를 그대로 넣는다면..
        {
            //방법 1
            resultPoint = new Point(firstPoint.x+width, firstPoint.y + height);

            //방법2
            resultPoint = new Point();
            resultPoint.x = firstPoint.x + width;
            resultPoint.y = firstPoint.y + height;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("한 점과, 가로, 세로 길이로 사각형의 모든 꼭짓점을 출력하겠습니다.");
            Console.WriteLine("한 점의 좌표값을 입력해주세요");
            Console.Write("x = ");
            // Console.ReadLine(); //숫자로 바꾸기
            Console.Write("y = ");
            // Console.ReadLine(); //숫자로 바꾸기
           
            //=> 이렇게 받은 x,y 값을 구조체 안에 넣기..

            Console.WriteLine("가로값을 입력해주세요");
            // Console.ReadLine(); //숫자로 바꾸기
            Console.WriteLine("세로값을 입력해주세요");
            // Console.ReadLine(); //숫자로 바꾸기
        }
    }
   
    #endregion

    #region 실습1. 반환형 없이(void) 형식의 함수로 계산기 만들기
    ////사용자가 수식을 입력하면 그에 따른 계산결과를 알려주는 계산기 만들기
    ////항은 두가지만 받고, 각 항은 한자리 수 여야함.
    ////연산은 사칙연산 == +,-,*,/ 이다
    ////예를들어 사용자가 1+2 를 입력하면
    //// 더하기를 수행하는 함수를 불러 매개변수로 1과 2를 넣고 결과값인 3을 돌려줘야하는것
    ////단, 모든 함수는 반환형 없이 (void) ref키워드 혹은 out 키워드를 쓰도록 한다.

    //class Program
    //{
    //    static void Plus(int a, int b, ref int result) //ref  /   out
    //    {
    //        result = a + b; //a+b 한 값을  a에다가 넣게되고.. a+b한것을 main함수에서도 쓸수있기때문...
    //        //return;
    //    }
    //    static void Minus(char a, char b, out int result)
    //    {
    //        result = (a - '0') - (b - '0');
    //    }
    //    //여기서 하나더 주의할 점...!!!!
    //    //곱하기는 상관없는데

    //    static void Divide(int a, int b, ref int result)
    //    {
    //        int c = a / b ;
    //        //result에 반영을 안한채 사용해도 모름...
    //    }

    //    static void Divide2(int a, int b, out int result)  //    2 / 4 ==  0.5f
    //    {
    //        // result = a / b;
    //        int c = a / b;
    //        result = c;
    //    }

    //    static void Main(string[] args)
    //    {
    //        string maths = ""; //maths[ ] 로 한글자씩 접근 가능...

    //        Console.WriteLine("수식을 입력해주세요. 두 개의 항을 받으며, 항의 값은 1이상 10미만의 값입니다. ");
    //        Console.Write("수식 입력 : "); //수식은 무조건  a수식b 의 형식이다  스페이스를 치게되면 스페이스도 한글자이기때문에 유의할것
    //        maths = Console.ReadLine(); //a수식b 의 string

    //        int result = 0;

    //        switch (maths[1]) //maths == string 으로 선언했기때문에 string형식이지만, 하나씩 접근하게되면 걔는 char형식이다..
    //        {
    //            case '+': //char형식은 "" 쌍따옴표가 아니고, '' 작은따옴표...                
    //                Plus((int)(maths[0] - '0'), (int)(maths[2] - '0'), ref result);
    //                break;
    //            case '-':
    //                Minus(maths[0], maths[2], out result);
    //                break;
    //            case '*':
    //                break;
    //            case '/':
    //                break;
    //            default:
    //                Console.WriteLine("잘못된 수식입니다");
    //                break;
    //        }

    //        Console.WriteLine("해당 수식의 결과 : " + result);

    //        ////추가힌트

    //        ////첫번째 방법.char를 string으로 변환후, string에서 int로 변환
    //        ////char를.ToString() 하면 string 형식으로 변환가능
    //        //char a = '1';
    //        //int.TryParse(a.ToString(), out int b);
    //        //Console.WriteLine(b);

    //        ////두번째 방법. char == int 가능한 점을 이용하여, char - char 한 값을 int로 바꿈
    //        ////또는 아스키코드로... '0' == 48 / '1' == 49 / '2'==50... 이렇게 되므로
    //        //a = '9';
    //        //int c = a - '0';
    //        //Console.WriteLine(c);
    //    }
    //}

    #endregion

    #region out키워드 체크
    //class Program
    //{
    //    void AA(int a, ref int b)
    //    {

    //    }
    //    void AA(ref int a, ref int b)
    //    {

    //    }
    //    void AA( out int b)
    //    {
    //        b = 10; //out 키워드가 붙은 매개변수의 값은 함수 나가기전에 반드시 설정 해줘야함.
    //    }

    //    static bool Compare(int a, int b, out int result)
    //    {
    //        //a가 b보다 크거나 같을 경우 true반환하고, result 값에다가 a-b 한 것을 넣기..
    //        if (a >= b)
    //        {
    //            result = a - b;
    //            return true;
    //        }
    //        else//a가 b보다 작을 경우, false를 반환하고, result는 -1을 세팅하기.
    //        {
    //            result = -1;
    //            return false;
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        //string a = "1234";
    //        ////int b = 10;
    //        //int.TryParse(a, out int b);
    //        //Console.WriteLine(b);

    //        //Compare 불러보고, 각각 넣은 값과 result 출력하기..
    //        int a = 10;
    //        int b = 20;            
    //        Compare(a , b , out int result); //함수를 실행하면 bool의 반환과.. result값이 채워짐...

    //        Console.WriteLine($"매개변수1의 값 : {a}, 매개변수2의 값 : {b} 을 넣어서" +
    //            $" 결과값 = {result}를 획득하였습니다");

    //        a = 15;
    //        b = 10;
    //        Compare(a, b, out result); //함수를 실행하면 bool의 반환과.. result값이 채워짐...

    //        Console.WriteLine($"매개변수1의 값 : {a}, 매개변수2의 값 : {b} 을 넣어서" +
    //            $" 결과값 = {result}를 획득하였습니다");

    //    }
    //}

    #endregion

    #region ref 키워드 체크
    //class Program
    //{
    //    static void Swap(int x, int y) //값형식 값형식의 경우
    //    {
    //        int temp = x;
    //        x = y;
    //        y = temp;
    //    }
    //    static void SwapRef(ref int x, int y) //참조형식 , 값형식 의 경우
    //    {
    //        int temp = x;
    //        x = y;
    //        y = temp;
    //    }

    //    static void SwapRef(ref int x, ref int y) //참조형식, 참조형식의 경우
    //    {
    //        int temp = x;
    //        x = y;
    //        y = temp;
    //    }
    //    static void Swap(Structure _aa) //값형식 값형식의 경우
    //    {
    //        int temp = _aa.x;
    //        _aa.x = _aa.y;
    //        _aa.y = temp;
    //    }
    //    static void Swap(ref Structure _struct)
    //    {            
    //        int temp = _struct.x;
    //        _struct.x = _struct.y;
    //        _struct.y = temp;
    //    }

    //    static void Main(string[] args)
    //    {
    //        //int x = 1;
    //        //int y = 2;
    //        //Swap(x, y);
    //        //Console.WriteLine($"x = {x} , y = {y}");

    //        // x = 1;
    //        // y = 2;
    //        //SwapRef(ref x, y);
    //        //Console.WriteLine($"x = {x} , y = {y}");

    //        //x = 1;
    //        //y = 2;
    //        //SwapRef(ref x, ref y);
    //        //Console.WriteLine($"x = {x} , y = {y}");
    //        Structure aa = new Structure(11,22); //x = 11, y = 22라는 요소를 가진 구조체가 만들어짐=> 그 구조체의 이름은 aa임.

    //        Console.WriteLine("생성된 구조체 aa = "  + aa.x + "," + aa.y);

    //        Swap(aa);
    //        Swap(aa.x, aa.y);

    //        Console.WriteLine("그냥 스왑 후의 구조체 aa = " + aa.x + "," + aa.y);

    //        Swap(ref aa);
    //        SwapRef(ref aa.x, ref aa.y);//동일

    //        Console.WriteLine("ref키워드를 사용한 스왑 후의 구조체 aa = " + aa.x + "," + aa.y);
    //        //그리고 구조체 결과값 출력..
    //        //구조체 값이 바뀌어있길 바라는 것..
    //    }
    //    //멤버변수를 int x, int y 를 가지는 구조체 선언 하여

    //    //int~ 들을 구조체로 바꿔보기
    //}

    //struct Structure
    //{
    //    public int x;
    //    public int y;
    //    public Structure(int x, int y)
    //    {
    //        this.x = x;
    //        this.y = y;
    //    }        
    //}

    ////class A
    ////{
    ////    int a = 0; //선언과 동시에 초기화가 가능
    ////}
    ////struct B
    ////{
    ////    public int a; //선언과 동시에 초기화가 불가능
    ////}
    #endregion
    #region 값복사와 참조복사
    //class Program
    //{
    //    static void Swap(Point point) //구조체를 매개변수로 넘김
    //    {            
    //        float temp = point.x;
    //        point.x = point.y;
    //        point.y = temp;

    //        Console.Write("그냥 Swap함수 안에서의, 구조체를 매개변수로 받은 point = ");
    //        point.PrintValue();
    //    }

    //    static void Swap(AA _a) //클래스를 매개변수로 넘김
    //    {
    //        float temp = _a.point.x;
    //        _a.point.x = _a.point.y;
    //        _a.point.y = temp;

    //        Console.Write("그냥 Swap함수 안에서의, AA클래스를 매개변수로 받은 point = ");
    //        _a.point.PrintValue();
    //    }

    //    static void Main(string[] args)
    //    {
    //        Point point = new Point(10,20);
    //        Swap(point); //구조체 만들어서 구조체 그냥 넘김
    //        Console.Write("현재 메인함수, Swap함수 실행 후의, 그냥 구조체로서의 point = ");
    //        point.PrintValue(); //이미 본 샘플....

    //        Point point2 = new Point(1,2);
    //        AA aa = new AA(point2);//클래스의 멤버변수로 point2를 선언하여 넣어주고
    //        Swap(aa); //클래스를 매개변수로 넘김
    //        Console.Write("현재 메인함수, Swap함수 실행 후의, 메인함수의 point2 = ");
    //        point2.PrintValue(); //얘는 과연 그냥 선언된 구조체인데 클래스 매개변수로 넘겼다고 얘도 같이 변할지?

    //        Console.Write("Swap함수 실행 후의, aa 클래스의 멤버변수 = ");
    //        aa.point.PrintValue(); //aa클래스 친구는 스왑이 잘됏음...

    //        Console.WriteLine("\n ==============================\n");

    //        point2.x = 3;
    //        point2.y = 4;            
    //        aa = new AA(point2);  //3,4 라는 새로운 포인트 값을 가지는 새로운 클래스 생성.
    //        aa.Swap(); //클래스 내부의 함수를 실행함

    //        Console.Write("클래스 안의 point의 내용 확인");
    //        aa.point.PrintValue();

    //        Console.Write("메인 함수의 point2의 내용 확인");
    //        point2.PrintValue();

    //    }
    //}
    //struct Point
    //{
    //    public float x;
    //    public float y;
    //    public Point(float x, float y)
    //    {
    //        this.x = x;
    //        this.y = y;
    //    }
    //    public void PrintValue()
    //    {
    //        Console.WriteLine($"좌표 값 : [{x} , {y}] \n");
    //    }
    //}

    //class AA
    //{
    //    public Point point; //

    //    public AA(Point point)
    //    {
    //        this.point = point;
    //        this.point.PrintValue(); //내 포인트 구조체 내용 확인
    //    }
    //    public void Swap()
    //    {
    //        //AA클래스의 point
    //        float temp = point.x;
    //        point.x = point.y;
    //        point.y = temp;

    //        Console.Write("AA 클래스 안에서의 Swap 실행한 point = ");
    //        point.PrintValue();
    //    }
    //}

    #endregion
    #region Swap해도 안바뀌는 것 확인 (값복사)
    //class Program
    //{
    //    static void Swap( int _x, int _y )
    //    {
    //        int temp = _x;
    //        _x = _y;
    //        _y = temp;

    //        Console.WriteLine($"Swap 함수 안에서의 x = {_x}, y = {_y}");
    //    }

    //    static void Main(string[] args)
    //    {
    //        int x = 10;
    //        int y = 20;
    //        Swap(x,y); //Console.WriteLine($"Swap 함수 안에서의 x = {_x}, y = {_y}");

    //        Console.WriteLine($"메인 함수에서의 x = {x}, y = {y}");
    //    }
    //}
    #endregion

    #region 클래스와 구조체 2
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Point point;
    //        point.x = 5f;
    //        point.y = 1.05f;
    //        Console.WriteLine("좌표 출력 : [" + point.x  +","+ point.y + "]");

    //        A a = new A();
    //        a.AAA(new PersonInfo(), new PersonInfo());

    //        //또다른 뭐 할거하고..

    //    }
    //}

    // class A
    // {
    //     int aaaaaa = 0; //멤버변수// 클래스가 멤버로 가지고있음..
    //
    //     public void AAA(PersonInfo _info, PersonInfo _info2) //매개변수 //매개체로 넘겨줌
    //     {
    //         _info.name = "";
    //         string newname = _info.name; //지역변수 / 지역안에서만 살아있음
    //     }
    // }
    // struct PersonInfo
    // {
    //     public string name;
    //     public string address;
    //     public int age;
    //
    //     //사람이름
    //     //주소지
    //     //나이
    //     //성별
    //     //가족관계
    //     //학년별 성적...
    //     //교우관계
    //     //기타 선생님의 뭐.. 평가...
    //
    // }

    //struct Point //대표적인 예로 좌표 정보를 담은 구조체가 있다.
    //{
    //    public float x;
    //    public float y;
    //    public Point(float x, float y)
    //    {
    //        this.x = x;
    //        this.y = y;
    //    }
    //}
    #endregion
    #region 클래스와 구조체
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //각 클래스 생성해서 불러서 확인 해보시면 더 좋겠죠...

    //        B bstruct = new B();
    //        bstruct.aa = 10;

    //        B bstruct2 = new B(10);
    //    }
    //}
    //class A
    //{
    //    public A()
    //    {
    //        //뭔가 ㅇ내가 원하는 뭔가를 해라~
    //    }

    //    ~A() //소멸자
    //    {
    //    }
    //}
    //struct B  //구조체는 변수내용의 값이 비어있으면 안됨.
    //{
    //   public  int aa;
    //    public B(int bbb) //기본생성자는 불가능함.
    //    {
    //        aa = bbb;
    //    }
    //}
    #endregion
}