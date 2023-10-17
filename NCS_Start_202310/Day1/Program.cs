using System;
using System.Text;

namespace Day1
{
    class Day1
    {
        //enum == 내가 선언한 변수에 대해서 string과 int로써 동시에 사용 가능.
        //public enum Weeks 
        //{            
        //    MONDAY , 
        //    TUESDAY ,
        //    WEDNESDAY ,
        //    THURSDAY,
        //    FRIDAY ,
        //    SATURDAY ,
        //    SUNDAY
        //}
        public enum RSP
        {
            가위,
            바위,
            보
        }
        static void main(string[] args) //인간이 쓰는메모. 컴퓨터 읽지마봐
        {                       

            //#######난수로 컴퓨터의 가위바위보 만들어서 판별해서 결과 알려주기

            Random random = new Random(); //난수 생성기. 무작위 수를 뽑아줌. 

            //최소 이상~ 최대 미만
            //가위바위보 구현하기

            int value = random.Next(0, 3); //0 ~ 2 나옴  ///컴퓨터의 가위바위보 무언가

            Console.WriteLine("가위바위보 게임을 시작합니다");
            Console.WriteLine("가위는 0, 바위는 1, 보자기는 2입니다");
            Console.Write("플레이어의 가위, 바위, 보 선택 : ");
            //해서 입력받기

            string playerChoiceOrigin = Console.ReadLine(); //플레이어의 선택
            int playerChoice;
            int.TryParse(playerChoiceOrigin, out playerChoice); //플레이어 선택이 숫자로 바뀜

            if (playerChoice == value) //동일하다면 비겼음
            {
                Console.WriteLine("비겼습니다");
            }
            else if ((playerChoice == 1 && value == 0) || (playerChoice == 2 && value == 1) || (playerChoice == 0 && value == 2))
            {
                Console.WriteLine("플레이어가 이겼습니다");
            }
            else //
            {
                Console.WriteLine("컴퓨터가 이겼습니다");
            }




            //============================


            //string a = "이름:abc|나이:10|키:200";

            //Console.WriteLine("a 문자열의 길이 : " + a.Length);


            //===============================

            //StringBuilder strbuilder = new StringBuilder();            

            //for (int i = 0; i < 1000; i++)  //100번을 괄호안의 일을 반복함
            //{
            //    strbuilder.Append("aa");
            //}

            //Console.WriteLine(strbuilder.ToString());

            //============================

            //Console.WriteLine(a.ToUpper());

            //Console.WriteLine("a" == "A" ? "같습니다 " : "ㄷ다릅니다"); // a.Equals("A")  // a == "A"
            //Console.WriteLine("a" == "a" ? "같습니다 " : "ㄷ다릅니다");



            //Console.WriteLine( a.Substring(1, 4)); 


            //string[] strArr = a.Split("|");
            //foreach (var item in strArr)
            //{
            //    Console.WriteLine(item);
            //}


            //========================

            //replace했다고 원본이 replace 한 것으로 바뀌어저장되진 않음.
            //Console.WriteLine("a를 replace한 결과" + a.Replace('c', '_')); 

            //Console.WriteLine("a 원본 : " +a); 

            //a = a.Replace('c', '_'); 

            //Console.WriteLine("a 원본 : " + a);

            //Console.WriteLine( a.IndexOf('z') ); // 없으면 -1, 있다면 첫번째 자리가 0인걸로 시작하여 카운팅해서 넘겨줌.
            //자릿수.. / 쉼표

            //Console.WriteLine(string.Format("{0: 0.00}", 123456789.987654321));
            //Console.WriteLine(string.Format("{0: 0,0}", 123456789));

            //string strValue = "asdfjkl";

            //Console.WriteLine( strValue.Contains('a') ? "strValue 문자열에 'a'가 들어있음 "  : "strValue 문자열에 'a'가 안들어있음 ");

            //Console.WriteLine( string.Format( "strValue의 값은 {0} 입니다 {1} {2}", strValue/*{0}*/, "!" /*{1}*/, "확인차 세번째" /*{2}*/) ) ;

            //string Format은 종류가 많으니 필요할때마다 찾아보는 것이 빠를 것..                        

            //==============================================
            //Weeks a = Weeks.SATURDAY | Weeks.SUNDAY; //주말

            ////Console.WriteLine("토요일과 일요일을 합한 weeks :  " +a); //

            //if (a.HasFlag(Weeks.SATURDAY))
            //{
            //    Console.WriteLine("토요일이 속해있습니다"); //    
            //}
            //else
            //{
            //    Console.WriteLine("토요일이 없습니다"); //    
            //}

            //switch (a)
            //{
            //    case Weeks.MONDAY:
            //        break;
            //    case Weeks.TUESDAY:
            //        break;
            //    case Weeks.WEDNESDAY:
            //        break;
            //    case Weeks.THURSDAY:
            //        break;
            //    case Weeks.FRIDAY:
            //        break;
            //    case Weeks.SATURDAY:                    
            //    case Weeks.SUNDAY:

            //        Console.WriteLine("어찌됐건 주말임");
            //        break;
            //    default:
            //        Console.WriteLine("해당변수가 없음");
            //        break;
            //}

            //Console.WriteLine("숫자를 요일로 바꿔드립니다");
            //int value;
            //if (int.TryParse(Console.ReadLine(), out value))
            //{
            //    a = (Weeks)value;

            //    Console.WriteLine( "입력한 숫자의 Weeks :  "  +  a   );

            //}
            //else
            //{
            //    Console.WriteLine("잘못된 입력 입니다");
            //}

            //Console.WriteLine(Weeks.MONDAY);
            //a = Weeks.TUESDAY;

            //Console.WriteLine("Weeks 형식의  a 입니다 : " + a); //a == weeks 상태.

            //string b = a.ToString();
            //Console.WriteLine("b의 내용입니다 : " + b); //

            //int c = (int)a;
            //Console.WriteLine("(int)로 명시적 형변환 한 c의 내용입니다 : " + c); //

            //int d;
            //int.TryParse(b, out d );
            //Console.WriteLine("tryparse로 string b를 int d로 형변환 내용입니다 : " + d); //

            //Console.WriteLine("Sunday의 숫자 확인 : " + (int)Weeks.SUNDAY );                        

            //===========================================
            //Console.WriteLine("설문조사입니다 1 매우작음 ~  5 매우큼 알맞은 숫자를 입력해주세요 ");
            //string value = Console.ReadLine();

            ////int value =Convert.ToInt32( Console.ReadLine());                                             

            //if (value == "1" || value == "2")            
            //    Console.WriteLine("작다고 응답하셨습니다");            

            //else if (value == "3")            
            //    Console.WriteLine("적당하다고 응답하셨습니다");

            //else if (value == "4" || value == "5")
            //{
            //    Console.WriteLine("크다고 응답하셨습니다");
            //}
            //else            
            //    Console.WriteLine("잘못된 응답입니다");            


            ////=======================================
            ////if else 문으로 바꿔보기
            //switch (value)
            //{
            //    case "1":  //value가 1 혹은 2 라면 ~ 
            //    case "2": 
            //        Console.WriteLine("작다고 응답하셨습니다");
            //        break;

            //    case "3":
            //        Console.WriteLine("적당하다고 응답하셨습니다");
            //        break;

            //    case "4": //value가 4 혹은 5 라면 ~
            //    case "5":
            //        Console.WriteLine("크다고 응답하셨습니다");
            //        break;

            //    default: //그 외...
            //        Console.WriteLine("잘못된 응답입니다");
            //        break;
            //}

            //===========================

            //switch ( value )
            //{
            //    case "1":
            //        Console.WriteLine("매우 작다고 응답하셨습니다");
            //        break;
            //    case "2":
            //        Console.WriteLine("조금 작다고 응답하셨습니다");
            //        break;
            //    case "3":
            //        Console.WriteLine("적당하다고 응답하셨습니다");
            //        break;
            //    case "4":
            //        Console.WriteLine("조금 크다고 응답하셨습니다");
            //        break;
            //    case "5":
            //        Console.WriteLine("매우 크다고 응답하셨습니다");
            //        break;
            //    default:
            //        Console.WriteLine("잘못된 응답입니다");
            //        break;
            //}

            //==================================

            //Console.WriteLine("A와 B에 들어갈 내용을 입력해주세요 ");

            //Console.Write("A = ");
            //string tmpstr = Console.ReadLine();
            //int a = 0;
            //int.TryParse(tmpstr, out a);

            //Console.Write("B = ");
            //if (int.TryParse(Console.ReadLine(), out int b))
            //{                
            //    Console.WriteLine("입력값이 성공적으로 int형으로 바뀌었습니다");
            //}
            //else
            //{
            //    Console.WriteLine("입력값이 정수형이 아님");
            //}

            ////Console.WriteLine(); //

            //if ( a > b )
            //{
            //    Console.WriteLine("a가 b보다 큽니다");//
            //}
            //else if (a < b)
            //{
            //    Console.WriteLine("a가 b보다 큽니다");
            //}
            //else
            //{
            //    Console.WriteLine("a와 b가 같습니다");
            //}


            //string aaa = Console.ReadLine();

            //int i_value = Convert.ToInt32(aaa); // aaa를 int형으로 바꾸겠다

            //float f_value = float.Parse(aaa);

            //double d_value = 0;
            //double.TryParse(aaa, out d_value);  // 권장~


            //if (aaa == "a")
            //{
            //    Console.WriteLine("a가 입력되었습니다");
            //}
            //else
            //{
            //    Console.WriteLine(aaa + "가 입력되었습니다");
            //}
            //============================

            //int a = 14;
            //a = a >> 2; //3

            //if ( a == 3 ) //만약~ 
            //{
            //    Console.WriteLine("a와 3이 동일하다");
            //}
            ////else if ( /*판별식2~*/) //아니면 만약~
            ////{
            ////}
            //else //아니면...
            //{
            //    Console.WriteLine("a는 3이 아니다");
            //}


            //if (a == 3) //만약~ 
            //{
            //    Console.WriteLine("a와 3이 동일하다");
            //}
            //else if ( a != 3 ) //아니면 만약~
            //{
            //    Console.WriteLine("a는 3이 아니다");
            //}

            //Console.WriteLine(a == 3 ? "a와 3이 동일하다 " : "a는 3이 아니다"); //



            //=======================================

            //int b = (3 > 6) ? 10 : -1 ; //-1

            //float c = ( a != b ) ? (a * b) : (a / b); //실수에는 정수를 넣을 수 있음

            //Console.WriteLine("(3 > 6) ? 10 : -1  를 진행한 b의 값 : " + b);

            //Console.WriteLine("( a != b ) ? (a * b) : (a / b)  를 진행한 c의 값 : " + c);

            //int d = (a != b) ? (c * b) : (a / b); //정수에는 실수를 넣을 수 없음.

            //================================
            //int a = 3;
            //int b = 6;

            //Console.WriteLine("a & b = " +  ( a & b )) ;
            //Console.WriteLine("a | b = " + (a | b));
            //Console.WriteLine("a ^ b = " + (a ^ b));
            //bool a = true;
            //bool b = false;

            //Console.WriteLine( a && b );  // 그리고~ and  => 거짓~ false

            //Console.WriteLine( a || b );  // 혹은~ or  => 참~ true

            //Console.WriteLine("원래 a : " + a + "\ta를 뒤집음 : " + !a); ///\t 탭 
            //=====================================
            //4칙연산은 같은 형끼리 가능.
            //혹은 더해서 같은 형이 될 수 있을 경우에 가능

            //int a = 10;
            //int b = 3;

            //a += b; // a =  a + b;

            //a = +b; //  a =   b다

            //a -= b; // a = a - b;

            //a = -b;  //a  -b를 넣어버림

            //============================

            //bool value = a >= b;  //   >=  a가 b보다 크거나 같은가?        <=  a가 b보다 작거나 같은가?

            //Console.WriteLine($"a의 값 : {a} ," +
            // $" b의 값 : {b}, \n " +
            // $"bool value의 값은 '  ~  '일 것이다 :  {value}");

            //=================================

            //a = b; //a를 b와 동일하게 하겠다. a는 b의 내용이다.

            //bool value = a != b; //a랑 b가 다르냐???

            //Console.WriteLine($"a의 값 : {a} ," +
            //    $" b의 값 : {b}, \n bool value 확인 :  {value}");


            //========================
            //a = b; //a를 b와 동일하게 하겠다. a는 b의 내용이다.

            //bool value =     a == b ; //a랑 b가 같으냐???

            //Console.WriteLine("bool value 확인 : " + value);         

            //=====================================

            //int c = a % b;
            //Console.WriteLine( "c의 값은 = " + c ); //위에는 c였고

            //string d = "a % b 의 값은 : ";            

            //Console.WriteLine( d + ( a % b ) ); //아래는 계산식이었음

            //string e = (a % b).ToString();

            //string f = a.ToString();
            //string g = b.ToString();

            //string h = d + (a % b);

            //Console.WriteLine( h ); //string 더하기 int결과나오는 계산식 더한 string

            //f % g 글자를 글자로 나머지는 안됨.


            //변수 선언하여 4칙연산 출력 해보기.                        

            //==================================
            //char a = ' ';
            //string b = "";

            //bool c = true; //1
            //bool d = false; //0                        

            ///=============================
            //변수명 규칙
            //숫자로 시작할 수 없음
            //특수문자중에는 언더바만 가능

            //이름짓기.. 다 보니까 회사마다 규칙이 조금씩 다름
            //소문자로 시작해서 단어뜻이 바뀌는 앞머리마다 대문자

            //카멜 표기법 == 이유는 낙타등처럼 내려갔다 올라가는
            //solveProblem
            //takeSomething

            //파스칼 표기법
            //FirstTry

            //스네이크 표기법
            //snake_move_to

            //헝가리안표기법 //거의 c쓰는 아저씨들이 많이 씀...
            //i_value
            //str_value
            //f_value
            //d_value

            //====================
            //int aaaaaaaa;//변수선언 
            //aaaaaaaa = 123; //아무상관 없어짐....
            //aaaaaaaa = 123124321;
            //long abig = 111111111111111;

            //float bbb = 2f, 
            //    ccc = -1.54654f,
            //    ddd = 0.123456789123456789123456789f;

            //double eee = 0.123456789123456789123456789;

            //Console.WriteLine( aaaaaaaa );
            //Console.WriteLine(bbb);
            //Console.WriteLine(ccc);
            //Console.WriteLine(ddd);
            //Console.WriteLine(eee);


            //; ; ; ; ; ; ; ; ; ; ; ; //내가 앞에 뭘 했고 ;를 만나는 순간 앞에 내용은 여기서 끝이라는 뜻.
            //형식 이름선언 ;(끝났음) 

            //Console.Write("Hello World! \n 헬로월드 엔터 됐음"); //엔터가 기본적으로 없음 역슬래시(원) \n 은 엔터와 동일
            //Console.WriteLine("주석처리 안한 줄");//엔터가 끝에 기본적으로 붙음
            //Console.WriteLine("글자라서 한글도 되고 !@#특수문자도 되고 숫자도 되고 123  ");//엔터가 끝에 기본적으로 붙음
            /*
             엔터를
             쓴다고 해도
             쭉 다 주석처리를 하고싶다면
             슬래시 곱하기          곱하기 슬래시
             */
        }
    }
}