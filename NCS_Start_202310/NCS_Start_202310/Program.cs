using System;
using System.Text;

namespace NCS_Start_202310_re
{
    class Program
    {
        // enum Weeks
        // {
        //     MONDAY = 1,
        //     TUESDAY = 2,
        //     WEDNESDAY = 4,
        //     THURSDAY = 8,
        //     FRIDAY = 16,
        //     SATURDAY = 32,
        //     SUNDAY = 64,
        //     한글됨,
        // }
        static void Main(string[] args)
        {
            /*
             * 2023 10 11 첫수업
             * 1 == 1
             * 10 == 2
             * 11 == 3
             * 100 = 4
             * 101
             * 2진수 말하는거임
             *
             * 절차적이랑 객체지향이 있음
             * 절차적 : 순서적으로 하는거
             * 예) C , 에이다 , 베이직
             * 객체적 : 모듈화, 캡슐화
             *  Console.Write랑 WriteLine이 있음
             * Write가 기본임
             * a를 치면 1바이트인데
             * ㅁ을 치면 2바이트임
             * ab == 2byte
             * 말 2byte
             * 2 4 8 16 32 64 128 256 512 1024 (2의 10승) == 데이터 크기의 모든 기본
             * 지금 이 주석은 인간이 쓰는 메모이며 컴퓨터 읽지 말라 라는것임
             */
            // Console.Write("Hello World!"); // 엔터가 기본적으로 없음
            // Console.WriteLine("Hello World!"); // 엔터가 끝에 기본적으로 붙음
            // Console.WriteLine("글자라서 한글도 되고 !@#특수문자도 되고 숫자도 되고 123"); // 엔터가 끝에 기본적으로 붙음
            // Console.WriteLine("Hello World! \n 헬로월드 엔터 됐음"); //엔터가 기본적으로 없음 역슬래시(원) \n
            // Console.WriteLine("주석처리 안한 줄"); // 주석처리 안했음
            //
            // int aaaaaaa; // 변수선언
            // // float bbb, ccc, ddd;
            // // double eee;
            // // a = 123;
            // float bbb = 2,
            //     ccc = -1.54654f,
            //     ddd = 0.5f;
            // // float는 f를 붙혀야 에러가 안난다.
            // double eee = 0.52154623;
            
            // Console.WriteLine(aaaaaaa);
            // Console.WriteLine(bbb);
            // Console.WriteLine(ccc);
            // Console.WriteLine(ddd);
            // Console.WriteLine(eee);
            /*
             * 변수명 규칙 진행하기
             * 1. 숫자로 시작할 수 없음
             * 2. 특수무나중에는 언더바만 가능
             * 3. 이름짓기.. 다 보니까 회사마다 규칙이 조금씩 다름
             * 4. 소문자로 시작해서 단어뜻이 바뀌는 앞머리마다 대문자]
             *
             * 예) solveProblem, takeSomething
             * 카멜 표기법 == 이유는 낙타등처러 ㅁ내려갔다 올라가는
             *
             * FirstTry
             * 파스칼 표기법
             *
             * 스네이크 표기법
             * snake_move_to
             *
             * 헝가리안표기법
             * 예)i_value
             * str_value
             * f_value
             * d_value
             *
             * 예) 매개변수 기입 방식
             * int _a;
             *
             * char a;
             * a = ''; 한글자만 가능합니다.
             * string b = ""; 문자열 가능
             *
             * bool c = true; // 1
             * bool d = false; // 0
             */

            // int a = 10;
            // int b = 3;
            // int c = a % b;
            // Console.WriteLine(c);
            // Console.WriteLine(a%b);
            
            // 변수 선언하여 4칙연산 출력 해보기

            // {
            //     // +
            //     int _a = 1;
            //     int _b = 2;
            //     int _c = _a + _b;
            //     Console.WriteLine(_c);
            // }
            //
            // {
            //     // -
            //     int _a = 1;
            //     int _b = 2;
            //     int _c = _a - _b;
            //     Console.WriteLine(_c);
            // }
            // {
            //     // *
            //     int _a = 1;
            //     int _b = 2;
            //     int _c = _a * _b;
            //     Console.WriteLine(_c);
            // }
            // {
            //     // /
            //     int _a = 1;
            //     int _b = 2;
            //     int _c = _a / _b;
            //     Console.WriteLine(_c);
            // }
            // {
            //     // %
            //     int _a = 1;
            //     int _b = 2;
            //     int _c = _a % _b;
            //     Console.WriteLine(_c);
            // }
            // {
            //     int a = 10;
            //     int b = 3;
            //
            //     int c = a % b;
            //     Console.WriteLine("c의 값은 = " + c); // 위에는 c였고
            //
            //     string d = " a % b 의 값은 : ";
            //     Console.WriteLine(d + (a % b)); // 아래는 계산식이었음
            //     string e = (a % b).ToString();
            //
            //     string f = a.ToString();
            //     string g = b.ToString();
            //
            //     d = d + 23121;
            //     d = d + (a % b);
            //
            //     string h = d + (a % b);
            //     Console.WriteLine(h);
            // }

            // {
            //     int a = 10;
            //     int b = 3;
            //     
            //     Console.WriteLine("전위증가한 a 값 : " + ++a);
            //     Console.WriteLine("후위증가한 a값 : " + a++);
            //     Console.WriteLine("후위증가한 a 값 : " + ( a + 1));
            //     Console.WriteLine("전위감소한 a 값" + --a);
            //     Console.WriteLine("후위감소한 a값 : " + a--);
            //     // Console.WriteLine("후위감소한 a 값 : " + a - 1); 글자니까 
            //     Console.WriteLine("후위감소한 a값 :" + (a - 1));
            // }
            // {
            //     int a = 10;
            //     int b = 3;
            //
            //     a = b; // a를 b와  동일하게 하겠다.a는 b의 내용이다.
            //
            //     bool value = a == b; // a랑 b가 같으냐???
            //     Console.WriteLine("bool value 확인 : " + value);
            //
            //     bool value2 = a != b; // a랑 b랑 다르냐?
            //     Console.WriteLine($"bool value 확인 : {value2}");
            //     Console.WriteLine($"b의값은{b}, \n bool value확인 : {value2}");
            // }

            // {
            //     // bool value의 값은 ' ~ ' 일 것이다. : {value}
            //     //1.
            //     const int a = 10;
            //     const int b = 20;
            //     bool value = a < b;
            //     Console.WriteLine($"a의값은 {a}이고 b의 값은 {b}이며 a보다 b가 커서 true가 나올것이다. => {value}");
            // }

            // int a = 3;
            // int b = 6;
            //
            // Console.WriteLine(" a & b  = " + (a & b));
            // Console.WriteLine(" a | b  = " + (a | b));
            // Console.WriteLine(" a ^ b  = " + (a ^ b));
            
            // 쉬프트연산자 : >> 사용함 
            // 즉 왼쪽으로 2칸 민다고 ( 2진수 )
            // bool a = true;
            // bool b = false;
            //
            // Console.WriteLine(a && b); // 그리고~ and => 거짓~ false
            // Console.WriteLine(a || b); // 혹은~ or => 참~ true
            //
            // Console.WriteLine("원래 a : " + a + "\t a를 뒤집음 : " + !a); // /\t 탭

            // int a = 14;
            // a = a >> 2;
            // Console.WriteLine(a == 3 ? "a와 3이 동일하다" : "a는 3이 아니다."); // 삼항 연산자
            //
            // int b = (3 > 6) ? 10 : -1;
            // float c = (a != b) ? (a + b) : (a - b);
            // // int d = (a != b) ? (c * d) : (a / b); // 정수에는 실수를 넣을 수 없음
            
            // Console.WriteLine("(3 > 6) ? 10 : -1;"); // -1
            // Console.WriteLine("(a != b) ? ( a * b ) : ( a / b)를 진행한 c의 값 :" + c);

            // {
            //     // int a = 14;
            //     // a = a >> 2; // 3
            //     // if (a == 3) // 만약
            //     // {
            //     //     Console.WriteLine("a와 3이 동일하다.");
            //     // }
            //     // else if( a != 3) // 만약 아니면
            //     // {
            //     //     Console.WriteLine("a는 3이 아니다.");
            //     // }
            //     // // else if
            //     // else
            //     // {
            //     //     Console.WriteLine("a는 3이 아니다.");
            //     // }
            //     
            //     
            // }
            // {
            //     /*
            //      *int i_value = Convert.ToInt32(aaa); // aaa를 int형으로 바꾸겠다.
            //      *float f_value = float.Parse(aaa);
            //      * double d_value;
            //      * double.TryParse(aaa, out double d_value); 권장
            //      */
            //    // Console.WriteLine("aaa에 들어갈 내용을 입력해주세요");
            //    // Console.Write("aaa = ");
            //    // string aaa = Console.ReadLine();
            //    //
            //    // if (aaa == "a")
            //    // {
            //    //     Console.WriteLine("a가 입력 되었습니다.");
            //    // }
            //    // else
            //    // {
            //    //     Console.WriteLine(aaa + "가 입력되었습니다.");
            //    // }
            // }

            // {
            //     Console.WriteLine("a + b의 덧셈식을 수행합니다. a와 b에 들어갈 내용을 입력해주세요");
            //     
            //     Console.Write("a = ");
            //     string temstr = Console.ReadLine();
            //     int a = 0;
            //     int.TryParse(temstr, out a);
            //     
            //     Console.Write("B = ");
            //     if (int.TryParse(Console.ReadLine(), out int b))
            //     {
            //         Console.WriteLine("입력값이 성공적으로 int형으로 바뀌었습니다.");
            //     }
            //     else
            //     {
            //         Console.WriteLine("입력값이 정수형이 아님");
            //     }
            //
            //     if (a > b)
            //     {
            //         Console.WriteLine("a가 b보다 큽니다.");
            //     }
            //     else if (a < b)
            //     {
            //         Console.WriteLine("a와 b가 같습니다.");
            //     }
            //     else
            //     {
            //         Console.WriteLine("a와 b가 같습니다.");
            //     }
            // }

            // int a = 3;
            // switch (a)
            // {
            //     case 1:
            //         Console.WriteLine("a의 값은 1입니다.");
            //         break;
            //     case 2:
            //         Console.WriteLine("a의 값은 2입니다.");
            //         break;
            //     case 3:
            //         Console.WriteLine("a의 값은 3입니다.");
            //         break;
            //     default:
            //         Console.WriteLine("a의 값에 해당되는 보기가 없습니다.");
            //         break;
            // }
            
            // Console.WriteLine("설문조사입니다. 1. 매우작음 ~ 매우 큼 알맞은 숫자를 입력해주세요");
            // string value = Console.ReadLine();

            // switch (value)
            // {
            //     case "1":
            //     case "2":
            //         Console.WriteLine("작다고 응답하셨습니다.");
            //         break;
            //     case "3":
            //         Console.WriteLine("적당하다고 응답하셨습니다.");
            //         break;
            //     case "4":
            //         case "5": 
            //         Console.WriteLine("크다고 응답하셨습니다.");
            //         break;
            //     default:
            //         Console.WriteLine("잘못된 응답입니다.");
            //         break;
            //     
            // }
            
            // Console.WriteLine("설문조사 if문");
            // // value : 전역변수
            // if (value == "1" || value == "2")
            // {
            //     Console.WriteLine("작다");
            // }
            // else if (value == "3" || value == "5")
            // {
            //     Console.WriteLine("적당");
            // }
            // else if (value == "4")
            // {
            //     Console.WriteLine("크다");
            // }
            // else
            // {
            //     Console.WriteLine("잘못된 응답");
            // }

            // Weeks a;
            // Console.WriteLine(Weeks.MONDAY);
            // a = Weeks.THURSDAY;
            // Console.WriteLine("Weeks 형식의 a입니다." + a); // a == weeks 상태
            //
            // string b = a.ToString();
            // Console.WriteLine("b의 내용입니다. : " + b);
            //
            // int c = (int)a;
            // Console.WriteLine("(int)로 명시적 형변환 한 c의 내용입니다. : " + c);
            //
            // int d;
            // int.TryParse(b, out d);
            // Console.WriteLine("tryparse로 string b를 int d로 형변환 내용입니다. : " + d);
            // Console.WriteLine("숫자를 요일로 바꿔드립니다.");
            // int value;
            // if (int.TryParse(Console.ReadLine(), out value))
            // {
            //     if (value == (int)Weeks.MONDAY)
            //     {
            //         
            //     }
            //     
            // }
            // else
            // {
            //     Console.WriteLine("잘못된 입력");
            // }

            // Weeks a = Weeks.SATURDAY | Weeks.SUNDAY;  // 주말
            //
            // Console.WriteLine("토요일과 일요일을 합한 weeks : " + a);
            //
            // switch (a)
            // {
            //     case Weeks.MONDAY:
            //         break;
            //     case Weeks.TUESDAY:
            //         break;
            //     case Weeks.WEDNESDAY:
            //         break;
            //     case Weeks.THURSDAY:
            //         break;
            //     case Weeks.FRIDAY:
            //         break;
            //     case Weeks.SUNDAY:
            //         break;
            //     default:
            //         break;
            // }

            // string strValue = "asdfghj";
            // Console.WriteLine(strValue.Contains('a') ? "strValue 문자열에 'a'가 들어있음" : "strValue 문자열 'a'가 안들어있음 ");
            // Console.WriteLine(string.Format($"strValue의 값은 {0} 입니다. {1} {2}", strValue, "!", "확인차 세번째"));

            // string a = "abcdefg";
            // Console.WriteLine("a를 replace한 결과" + a.Replace('c','_'));
            // Console.WriteLine("a 원본 : " +a);
            // a = a.Replace('c', '_');
            // Console.WriteLine("a 원본 : " + a);
            // StringBuilder 스트링 빌더
            // 대량으로 스트링 작업을 할때 쓸만함

            Random random = new Random();
            /*
             * 난수 생성기. 무작위 수를 뽑아줌.
             * 최소 이상 ~ 최대 미만
             * 가위바위보 구현하기
             * 
             * 
             */
            Console.WriteLine("가위바위보 게임을 시작합니다.");
            Console.WriteLine("가위는 0, 바위는 1, 보자기는 2입니다.");
            Console.Write("플레이어의 가위, 바위, 보 선택 : ");
            /*
             *  해서 입력받기
             * 
             */

            int value = random.Next(0, 3); // 0 ~ 2 나옴
            
            // 난수로 컴퓨터의 가위바위보 만들어서 판별해서 결과 알려주기


        }
    }
}