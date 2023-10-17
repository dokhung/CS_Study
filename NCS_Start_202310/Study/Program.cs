using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int num = 10;
            float f = 10.2f;
            string s = "만나서 반갑습니다";
            char c = 'A'; // 문자열이 안들어갈것이다. ex => "안녕하세요";
            bool b = true;
            bool b1 = false;
           

            Console.WriteLine(num);
            Console.WriteLine("num");

            int num1 = 10;
            Console.WriteLine(num1);
            Console.WriteLine(num1++);
            Console.WriteLine(++num1);
            num = num + 3;
            Console.WriteLine(num);
            num *= 3;
            Console.WriteLine(num);



            // 함수 : 하나의 목적을 구현하기 위한 명령문드르이 집합

            Console.WriteLine("1. Welcome to the Hell");
            Console.WriteLine("2. Welcome to the Hell");
            */

            /*
             int a = int.Parse(Console.ReadLine());
            int b = 3;
            Console.WriteLine($"a => {a}");
            Console.WriteLine($"++a => {++a}");
            Console.WriteLine($"a++ => {a++}");
            b = 10;
            b++;
            Console.WriteLine($"b{b}");
            int c = 10;
            ++c;
            Console.WriteLine($"c{c}");
             */




            /*
             if (a > b)
            {
                Console.WriteLine("a가 b보다 크다");
            }
            else if (a < b)
            {
                Console.WriteLine("a가 b보다 작다");
            }
            else if (a == b)
            {
                Console.WriteLine("a와 b가 같다.");
            }
            else if (a == 1)
            {
                Console.WriteLine("a1");
            }
            else if (a == 2)
            {
                Console.WriteLine("a2");
            }
            else if (a == 3)
            {
                Console.WriteLine("a3");
            }
            else
            {
                Console.WriteLine("a는 3보다 크다.");
            }

            switch (a)
            {
                case 10:
                    Console.WriteLine("a의 값은 10입니다.");
                    break;

                case 100:
                    Console.WriteLine("a의 값은 100입니다.");
                    break;
                default:
                    Console.WriteLine("a는 10도 아니고 100도 아니다.");
                    break;

            }
             */

            // 2023 09 11

            /*
               int gold = int.Parse(Console.ReadLine());

              if(gold >= 10)
              {
                  Console.WriteLine("a1");
              }
              else
              {
                  Console.WriteLine("돈이 부족하다.");
              }

              switch (gold)
              {

                   case 10:
                      Console.WriteLine("gold is 10");
                      break;
                  case 20:
                      Console.WriteLine("gold id 20");
                      break;


                  case 10:
                      {
                          Console.WriteLine("a");
                          int a = 10;
                      }
                      break;




              }
             */
            /*
                        Console.WriteLine("if------------");
                        Console.WriteLine("if문 문제");
                        Console.WriteLine("값을 입력하시오");
                        int val = int.Parse(Console.ReadLine());
                        Console.WriteLine($"입력한 값은 {val}입니다");
                        Console.WriteLine();
                        Console.WriteLine();
                        if (val >= 0)
                        {
                            Console.WriteLine($"val은 {val}입니다. 양수 입니다.");
                        }
                        else if (val < 0)
                        {
                            Console.WriteLine($"val은 {val}입니다. 음수 입니다.");
                        }

                        if (val > 50)
                        {
                            Console.WriteLine($"val은 {val}입니다. 입력한 값이 50이상 입니다.");

                        }
                        else if (val < -20)
                        {
                            Console.WriteLine($"val은 {val}입니다. 입력한 값이 -20이하 입니다.");

                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("switch------------");
                        Console.WriteLine("swich문 문제");
                        Console.WriteLine("값을 입력하시오");
                        string s = Console.ReadLine();
                        switch (s)
                        {
                            case "정수":
                                Console.WriteLine("int");
                                break;
                            case "실수":
                                Console.WriteLine("float");
                                break;
                            case "문자열":
                                Console.WriteLine("string");
                                break;
                            case "참거짓":
                                Console.WriteLine("bool");
                                break;
                            default:break;

                        }
             */

            /*
             for((1)초기값; (2->5->8) 조건; 4->7)증감
            {
            (3->6)문장:: -> (조건->문장->증감)->반복
            }

            초기값: num = 0;, 초기 선언값; int num = 0;
            while((2)조건: num < 10 )
            {
            (4-1)증감 : num++;
            (3)문장 : 실행부분
            (4-2)증김 " num++
            }
             */
            /*
             int sum = 0;
            for(int i=1; i<10; i++)
            {
                Console.WriteLine(i);
                sum += i;
                Console.WriteLine("for :" + sum);
            }
            Console.WriteLine(sum);
             */

            /*
             *  int count = 0;
             int sum = 0;
             while (count < 10)
             {
                 sum += count;
                 count++;
             }
             Console.WriteLine(sum);
             *

             */




            // 2023 09 12


            /*
             for(int i =0; i < 10; i++)
            {
                Console.WriteLine(i + 1); // 1부터 10까지 찍힘 이유는 이게 0부터 시작되기에 1을 더해야됨

                Console.WriteLine(i);




            }


              int a = 0;
            while (a < 10)
            {
                Console.WriteLine(a++);
            }
             */



            /*
             for(int i = 2; i <=4; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    Console.WriteLine($"{i}*{j + 1}={j * (j + 1)}");
                }
            }
             */

            /*
             for(int i = 9; i > 0; i--)
            {
                Console.WriteLine(i);
            }
             */












            //   int sgugu = int.Parse(Console.ReadLine());
            //   int egugu = int.Parse(Console.ReadLine());
            //  for(int i = 1; i < 9; i++)
            // {
            // for(int j = sgugu; j <= egugu; i++)
            // {
            //     Console.Write($"{j} * {i} = {j * i}\t");
            // }
            //
            // Console.WriteLine();
            // }

            // Console.WriteLine("가로");
            // for(int i = 1; i < 9; i++)
            // {
            //     for(int j = 2; j <= 9; j++)
            //     {
            //         Console.Write($"{i}*{j}={i * j}\t");
            //     }
            //     Console.WriteLine();
            // }
            //
            // Console.WriteLine("세로");
            //
            // for (int j = 1; j <= 9; j++)
            // {
            //     for (int i = 2; i <= 8; i++)
            //     {
            //         Console.Write($"{i}*{j}={i * j}\t");
            //     }
            //     Console.WriteLine();
            // }


            //2023 09 13
            // 내 맘대로 어떤 조건에 따라서 제어를 한다. = 제어문
            // return, continue, break

            // int a = 10;
            // if (a == 10)
            // {
            //     Console.WriteLine("조건문 안에서 실행");
            // }
            // Console.WriteLine("조건문 밖에서 실행");

            // int a = 5;
            // for (int i = 0; i < a; i++)
            // {
            //     if (i == 3)
            //     {
            //         break;
            //     }
            //     Console.WriteLine(i);
            // }
            // Console.WriteLine("조건문 밖 첫번쨰 실행 에서 실행");

            // int a = 5;
            // for (int i = 0; i < a; i++)
            // {
            //     if (i == 3)
            //     {
            //         continue; // 3스킵
            //     }
            //     Console.WriteLine(i);
            // }
            // Console.WriteLine("조건문 밖 첫번쨰 실행 에서 실행");

            // int a = 5;
            // for (int i = 0; i < a; i++)
            // {
            //     if (i == 3)
            //     {
            //         return;
            //     }
            //     Console.WriteLine(i);
            // }
            // Console.WriteLine("조건문 밖 첫번쨰 실행 에서 실행");

            /*

           *
           **
           ***
           ****
           *****

            */
            // Console.WriteLine("------------------");
            //
            // for (int i = 0; i < 5; i++)
            // {
            //     for(int j = 0; j <= i; j++)
            //     {
            //         Console.Write("*");
            //     }
            //     Console.WriteLine();
            // }
            //
            // Console.WriteLine("------------------");
            //
            // for (int i = 0; i <= 5; i++)
            // {
            //     for (int j = 5; j > i; j--)
            //     {
            //         Console.Write("*");
            //     }
            //     Console.WriteLine();
            // }

            // Console.WriteLine("------------------");
            //
            // for (int i = 0; i < 5; i++)
            // {
            //     for (int j = 4; j > i; j--)
            //     {
            //         Console.Write(" ");
            //     }
            //
            //     for (int k = 0; k < i+1; k++)
            //     {
            //         Console.Write("*");
            //     }
            //     Console.WriteLine();
            // }
            //
            // Console.WriteLine("------------------");
            //
            // for (int i = 0; i < 5; i++)
            // {
            //     for (int j = 0; j < i; j++)
            //     {
            //         Console.Write(" ");
            //     }
            //
            //     for (int k = 5; k > i; k--)
            //     {
            //         Console.Write("*");
            //     }
            //     Console.WriteLine();
            // }



            // 2023 09 14
            // 제어문 : 뒤로 실행되지 않습니다.
            // 컨티뉴 : 건너뛰기
            // 브레이크 : 벗어나기
            // 리턴 : 반환

            /*
             자료구조 : 어레이 리스트 디셔너리 해쉬테이블, [스택, 큐]
            Array, List, Dicitionary, Hashtable, [Stack,Queue]

             */

            /*
             int[] array = new int[100]; // 10개
             */

            /*
             for (int i = 0; i < array.Length; i++)
            {
                Random r = new Random(); // Random은 꼭 알아놔라
                array[i] = r.Next(1, 10);
                Console.WriteLine($"array[{i}] : {array[i]}"); // array의 i번째
            }
             */

            /*
             List<int> randList = new List<int>();
            Console.WriteLine(randList.Count);

            for (int i = 0; i < 100; i++)
            {
                int check = int.Parse(Console.ReadLine());
                if(check == -1)
                    break;
                if(check == -10)
                {
                    check = int.Parse(Console.ReadLine());
                    randList.RemoveAt(check);
                    Console.WriteLine(randList.Count);
                    continue;
                }
                randList.Add(new Random().Next(1, 100));
                Console.WriteLine(randList.Count);
                Console.WriteLine($"randList[{i}:{randList[randList.Count - 1]}]");

               
            }
             
             */

            // 2023 09 15
            // int[] array = new int[400];
            // array[299] = 100;
            // int a = array[299];
            //
            // List<int> listint = new List<int>();
            // listint.Add(100);
            // listint.Add(200);

            // int[] array = new int[10];
            // // int[] array = {5,1,3,2,8,7,6,4,9};
            // for (int i = 0; i < array.Length; i++)
            // {
            //     // 1부터 100까지
            //     array[i] = new Random().Next(1, 100);
            // }
            //
            // for (int i = 0; i < array.Length; i++)
            // {
            //     for (int j = i + 1; j < array.Length; j++)
            //     {
            //         if (array[i] > array[j])
            //         {
            //             int a = array[i];
            //             array[i] = array[j];
            //             array[j] = a;
            //         }
            //     }
            // }
            // foreach는 초기값도 없고 증감값도 없다. 
            // 단점이 무조건 0부터 함
            // foreach (int val in array)
            // {
            //     Console.WriteLine(val);
            // }
            /*
             *자료구조 : 어레이, 리스트, Dictionary, Hashtable, [Stack, Queue]
             * 리스트 선언방법 : List<자료형> dlfma = new List<자료형>();
             * 리스트 사용방법 : 자료형이름.Add(자료형의 값);
             * 이름.Remove : 내가 넣었던 값을 찾아 삭제한다.
             * 이름.RemoveAt : index 참조값에 의해 삭제한다.
             * 이름.RemoveRange : 첫번째값은 시작 참조index,  두번쨰값 갯수 의해 삭제
             * 자료구조 길이값 구하는 방법 : 1)배열 -> 이름.Length(갯수) 2) 이름.Count(갯수)
             * 
             */

            // Dictionary<string,int> dic = new Dictionary<string,int>(); // List랑 같은데 2개의 자료구조를 사용함
            // dic.Add("학원",500);
            // dic.Add("집",1000); // 집 이라는것을 통해서 1000이라는 값을 얻었다.
            // Console.WriteLine(dic["집"]); // key값이 집
            // dic.Add("몰라",0);
            // // 출력은 집이 아니고 집의 값인 1000이 나타난다.
            // foreach (var item in dic)
            // {
            //     if (item.Value == 500)
            //     {
            //         Console.WriteLine(item.Key);
            //     }
            // }
            //
            // List<int> aList = new List<int>();
            // for (int i = 0; i < 20; i++)
            // {
            //     aList.Add(i);
            // }
            //
            // foreach (var item in dic)
            // {
            //     Console.WriteLine(item.Key);
            // }
            
            /*
             * 2023 09 18
              Hashtable ht = new Hashtable();
             ht.Add("스트링", 10);
             ht.Add("스트링", 10f);
             ht.Add("문자열", "스트링");
             ht.Add(1.2f, "실수");
             ht.Add(1.3f, 30);
             ht.Add(1.3f, "뭐지");
             */
            // 키값이 다 다르기 떄문에 가능
            // 별로 안쓰임
            // 들어가는 데이터가 순서대로 먼저 나옴 (  * 막혀있다.  1 2 3 4 => 1 2 3 4) = 힙
            // 막혀있지 않다. 1 2 3 4 => 4 3 2 1 = 큐 
            /*
             List<int> list = new List<int>();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < 5; i++)
            {
                stack.Push(i);
            }

            int cnt = stack.Count;
            for (int i = 0; i < cnt; i++)
            {
                Console.WriteLine(stack.Pop());

            }
             */
            /*
             Queue<int> qu = new Queue<int>();

            for (int i = 0; i < 5; i++)
            {
                qu.Enqueue(i);
                // 넣고
            }
            int cnt = qu.Count;
            for (int i = 0; i < cnt; i++)
            {
                Console.WriteLine(qu.Dequeue());
                // 빼고
            }
             */

            


           // Sum(1,2);
           // Console.WriteLine("-------------------");
            // S(1, 2);
           // int a = S(1, 2);
           // P(a.ToString());
          // Print();
          // 클래스 : class 즉 큰거다.
          // new Print().Write("다이렉트");
          // Print pt = new Print();
          // pt.Write("생성자");



          Monster orc = new Monster(100, 5);
          orc.Move();

          Monster goblic = new Monster(500, 10);
          goblic.Move();
        }

        /*
         *static int S(int a, int b)
        {
            return a + b;
        }
         * 
         */

       // static void Sum(int a, int b)
       // {
            // Console.WriteLine(a + b);
         //   P((a+b.ToString()));
            // void는 반환할 값 return이 없다. 라는 뜻이다.
            
        //}

        //static void P(string s)
        //{
        //    Console.WriteLine(s);
        //}
        // 재귀함수 : 나를 다시 보는것을 뜻함

        // static void Print()
        // {
        //     // Console.WriteLine("Print()");
        //     // if (Console.ReadLine() == "y")
        //     // {
        //     //     Print();
        //     // }
        //
        //     // int a = 0; // 전역변수
        //     // if (true)
        //     // {
        //     //     // 지역변수
        //     //     int b = 0;
        //     //     b = 10;
        //     //     if (true)
        //     //     {
        //     //         int c = 0;
        //     //         b = 10;
        //     //     }
        //     //     // 갖쳐있는것을 잘 확인하라
        //     // }
        // }
        
        /*
         * 2023 09 19
         *
         * Dictionary = 사전
         * key값을 사용함
         * HashTable은 자료형 차이
         * 규칙적이지 않아서 사용하지 않는 편
         * 스택 : 먼저 넣은것이 나중에
         * 큐 : 먼저 넣은것이 먼저 나옴
         *
         * 
         * string Print(){
         * return ""; 이게 맞음
         * return string; 이거 안됨
         * }
         * new Print().Write("print");
         * Write는 인스턴스이며 그래서 .을 사용해야됨
         * ----------------------------
         using System;

            namespace Study
            {
                public class Print
                {
                    public void Write(string s)
                    {
                        Console.WriteLine(s);
                        // Console 이거 클래스
                    }
                    
                    protected void Write1(string s)
                    {
                        Console.WriteLine(s);
                        // Console 이거 클래스
                    }
                    
                    private void Write2(string s)
                    {
                        Console.WriteLine(s);
                        // Console 이거 클래스
                    }
                    
                }
            }
         * ----------------------------
         * 접근제어자
         * public 공개
         * protected 보호
         * private 비공개
         * 
         */
        
        /*Monster.cs
         using System;

namespace Study
{
    // 상속
    public class Monster
    {
        // 비공개 사항
        
        
        

        private int hp;
        private int speed;

        public Monster(int hp, int speed)
        {
            Console.WriteLine("생성했다.");
            this.hp = hp;
            this.speed = speed;
        }
        private bool isMove = false;
        
        
        // 행동
        // protected void Attack()
        // {
        //     
        // }
        
        public void Move()
        {
            isMove = true;
            /*
             * int speed = 10;
             * speed값이 있으면 this 해야됨
             * /
        }
        
        // protected void Dead()
        // {
        //     
        // }
        //
        // protected void Hit()
        // {
        //     
        // }
        // public int hp = 10;
        
    }

    // class Orc : Monster // <- 상속받음
    // {
    //     public void Main()
    //     {
    //         // Move(); // 이동을 한다. 그러면 Move()가 활성화된다.
    //         // Hit();
    //         // Move();
    //         // Hit();
    //         Hp = 20;
    //     }
    // }
    //
    // class Goblin : Orc
    // {
    //     public void GMain()
    //     {
    //         
    //     }
    // }
}
         
         */
        
        

        
        


    }
    }


/*
 *C:\Users\user\source\repos
 * 여기에 넣어야됨
 * 
 */
