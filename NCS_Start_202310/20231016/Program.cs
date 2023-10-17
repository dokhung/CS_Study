using System;

namespace _20231016
{
    internal class Program
    {
        public static int sum = 0; // 클래스 내에서 지정된 변수 => 맴버변수
        public static void Main(string[] args)      // 한정자 없음
        {
            // int _a = 3;
            // Console.WriteLine(_a.IsEven());
            
            /*
             *  void == 아무것도 반환하지 않겠다.
             *  그냥 끝내겠다.
             *
             *  다른 데이터 형식 ?
             *
             *  매개변수
             *  예) 계산기
             *  A + B
             *
             *  break; // => 반복문의 탈출
             *  return; // => 함수의 탈출
             *  public int AddFunction(int a, int b)
             * {
             * return a+b;
             *  무언가 뎃셈한 결과를 반환해줌
             * }
             *
             * 클래스 = 붕어빵 틀
             * 인스턴스 = 붕어빵
             */
            A a = new A();
            B b = new B();

            A a1 = new A();
            A a2 = new A();
            a1.aa = 1;
            a2.aa = 2;
            

            AA.A aa = new AA.A();
            // Console.WriteLine(a.Add(1,2,3));
            Console.WriteLine(Plus(1,2));
            Console.WriteLine(Plus(1,2,3));
            Console.WriteLine(Plus());

            string[] strarr = { "안녕", "하이", "스트링여러개" };
            ShowConsol(strarr);
            
            string[] strarr2 = { "ㅁ", "ㄴ", "ㅇ", "ㄹㄹㄹㄹ","ㅁㄴㅇㄹ" };
            ShowConsol(strarr2);
            
            /*
             * Static 한정자
             *
             * 확장 메서드
             */

            Player bb = new Player("김아무개",22);
            bb.age = 10;
            bb.name = "김아무개";

            // Player _aa = new Player();
            // _aa.age = 10;
            // _aa.name = "name";





        }

        class Player
        {
            public string name;
            public int age;

            public Player()
            {
                this.age = 20;
                
            }

            public Player(string name, int age) : this()
            {
                // 여기 생성자

                this.name = name;  // <= 나의 이름
                this.age = age;

            }
        }
        static void Hi() => 
            Console.WriteLine("안녕하세요."); // 화살표 함수
        static void Multiply(int a, int b) => 
            Console.WriteLine(a * b); // 인자값 사용한 화살표 함수

        static int Plus(int a = 0 , int b = 0, int c = 0)
        {
            int sum = 0;  // <== 지역변수  그래서 public 안됨
            sum = a + b + c;
            
            return a + b + c;
        }

        static void ShowConsol(params string[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
            // return;  <= 반환한거 없음
        }

        static int Add(int a, int b, int c)
        {
            return a + b + c;
            /*
             *static은 시작부터 살아있게 하는것.
             * 씨샵 특징
             * 
             */
        }

        class A
        {
            public int aa;
            protected int bb;
            private int cc;
            public int CC => cc; // 속성 (프로퍼티)

            public int dd
            {
                get { return dd; }
                set { dd = value; } // 속성(프로퍼티)
            }
            }
            void ABC()
            {
             // aa 접근 가능
             // 한정자를 지정 안하면 기본적으로 private 상태임
             
             
            }

            public int _Add(int a, int b, int c)
            {
                return a + b + c;
            }
            
        }

        class B
        {
            
        }
    }

    namespace AA
    {
        /*
         * 다른성씨의 아무개
         * 
         */

        class A
        {
            
        }
    }

    // namespace ExtensionMethods  // 확장 메서드
    // {
    //     public static bool IsEven(this int val)
    //     {
    //         return val % 2 == 0; // 짝인지 반환해줌
    //     }
    // }
