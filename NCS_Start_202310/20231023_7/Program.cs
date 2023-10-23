using System;
using System.Collections.Generic; //List 
using System.Text;

namespace NCS_Start_20231023
{
    class Calculator<T>   //계산기~~~를 제네릭으로 만든다면 이런 시리즈로 만듬..
    {
        public T Plus(T num1, T num2)
        {
            //var i = 0;
            //i = "a";

            //object a = 1;
            //a = "b";
            //a = 'c';
            //object /
            dynamic dynNum1 = num1;
            dynamic dynNum2 = num2;
            T result = dynNum1 + dynNum2;
            return result;
        }
    }

    class GenericClass<T> //나는 제네릭이다~ 제네릭 클래스다..
    {
        public T member;

        public GenericClass(T t)
        {
            member = t;
        }
        public override string ToString() //모든 클래스는 ToString을 재정의 할 수 있음
        {
            return "member의 값 : " + member;
        }

        public void ShowMemberValue()
        {
            Console.WriteLine("member 의 값을 보여준다 :  " + member.ToString());
        }
    }

    class SolveProb
    {
        ////실습2번 stack만 사용한 경우.
        //public int[] RemoveRepeats(int[] arr)
        //{           
        //    Stack<int> stack = new Stack<int>();
        //    int val = 0;
        //    for (int i = arr.Length - 1; i >= 0; i--)
        //    {
        //        if (stack.Count ==0)
        //        {
        //            stack.Push(arr[i]); //stack이 비어있는 상태기 때문에 첫번째 수는 무조건 그냥 더해줌..
        //        }
        //        else
        //        {
        //            val = stack.Peek(); //가장 마지막에 넣은 숫자 삭제하지 않고 받아오기.. 
        //            if (arr[i] != val)
        //            {
        //                stack.Push(arr[i]);
        //            }
        //        }                                
        //    }

        //    return stack.ToArray();
        //}

        ////실습2번 stack과 queue 둘다 쓴 경우
        //public int[] RemoveRepeats(int[] arr)
        //{
        //    //stack 혹은 queue의 활용 / 또는 둘다 활용...
        //    Stack<int> stack = new Stack<int>();
        //    Queue<int> queue = new Queue<int>();

        //    int val = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (stack.Count ==0)
        //        {
        //            stack.Push(arr[i]);
        //            queue.Enqueue(arr[i]);
        //        }
        //        else
        //        {
        //            val = stack.Peek();
        //            if (val != arr[i])
        //            {
        //                stack.Push(arr[i]);
        //                queue.Enqueue(arr[i]);
        //            }
        //        }              
        //    }
        //    return queue.ToArray();
        //}

        //public bool IsRight(string val)
        //{
        //}

        // //실습3번
        //public bool IsRight(string s)
        //{
        //    Stack<char> stack = new Stack<char>(); //여는 괄호들을 담아두는 스택임..
        //    if (s[0] == ')') //문자열의 시작이 ')'== 바깥쪽 괄호  라면 뒤에것은 볼 필요도 없이 틀린 괄호묶음임.
        //    {
        //        return false; 
        //    }

        //    //어쨌거나 문자열의 시작이 ( 로 한다는 얘기..

        //    for (int i = 0; i < s.Length; i++)
        //    {                
        //        if (s[i] == '(')
        //        {
        //            stack.Push(s[i]);
        //        }
        //        else // ')' 닫는 괄호를 만났다면..
        //        {
        //            if (stack.Count == 0) // 짝을 이룰 '('  가 없기 때문에 잘못된 식.
        //            {
        //                return false;
        //            }
        //            else
        //            {
        //                stack.Pop(); //안쪽 괄호인 내용물 하나 빼기. 
        //            }
        //            //if ( stack.TryPop(out char val) == false) // '('
        //            //{
        //            //    return false;
        //            //}
        //        }
        //    }

        //    if (stack.Count > 0)
        //    {
        //        return false;
        //    }
        //    else
        //        return true;
        //}
        //public override string ToString()
        //{
        //    return "SolveProb 클래스입니다";
        //}
    }

    class Program
    {
        static void Swap<T>(ref T val1, ref T val2)
        {
            T temp;
            temp = val1;
            val1 = val2;
            val2 = temp;
        }

        enum BB
        { }
        struct AA
        { }
        static void Main(string[] args)
        {
            ///char 를 키로 갖고, 값으로 숫자를 갖는 딕셔너리를 선언
            //5개의 값을 더하고 
            //  char 'a'를 검색해서 키가 존재한다면 내가이름지은딕셔너리.ContainsKey('a')
            //걔를 없애라...
            //하고 전체 출력...
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            char key = 'a';
            for (int i = 0; i < 5; i++)
            {
                dictionary.Add((char)(key + i), (int)key + i);
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($" [ {item.Key} / {item.Value} ] ");
            }

            Console.WriteLine("'a'키를 검색하여 존재한다면 삭제");
            if (dictionary.ContainsKey('a'))
            {
                dictionary.Remove('a');
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($" [ {item.Key} / {item.Value} ] ");
            }

            Console.WriteLine("'c'인 키가 존재한다면 그 내용물을 99999로 바꿔라");
            if (dictionary.ContainsKey('c'))
            {
                dictionary['c'] = 99999;
            }


            foreach (var item in dictionary)
            {
                Console.WriteLine($" [ {item.Key} / {item.Value} ] ");
            }

            //value로 찾아서 해당 값을 지우고자 한다면 이하와같이 한다..
            char findkey = 'a';
            foreach (var item in dictionary)
            {
                if (item.Value == 100)
                {
                    //dictionary[ item.Key ] 
                    findkey = item.Key;
                    break;
                }
            }

            if (dictionary.ContainsKey(findkey))
            {
                dictionary.Remove(findkey);
            }



            //Dictionary<키의 데이터형식, 값의 데이터형식 > dictionary = new Dictionary<키의 데이터형식, 값의 데이터형식>();

            //키는 검색하기 쉬워야하고.. 유일무이 해야한다...
            //Dictionary<int, string> dictionary = new Dictionary<int, string>();
            //Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
            //Dictionary<string, int> dictionary3 = new Dictionary<string, int>();
            //Dictionary<SolveProb, int> dictionary4 = new Dictionary<SolveProb, int>();
            //Dictionary<BB, AA> dictionary5 = new Dictionary<BB, AA>();

            //dictionary.Add(1, string.Empty);
            //dictionary.Add(2, "두번째 내용");
            //dictionary.Add(3, "세번째 내용");

            //dictionary.Remove(키);

            //foreach (var item in dictionary) //키 와 값
            //{
            //    Console.WriteLine("키의 내용 : " + item.Key + ", 값의 내용 : " + item.Value);
            //}

            //Console.WriteLine("dictionary[ 2] 를 출력함 : " + dictionary[ 2]);

            //dictionary3.Add("aaaa" , 10);
            //dictionary3.Add("bbb", 30);
            //dictionary3.Add("ccc", 850);
            //foreach (var item in dictionary3) //키 와 값
            //{
            //    Console.WriteLine("키의 내용 : " + item.Key + ", 값의 내용 : " + item.Value);
            //}

            //Console.WriteLine("dictionary[ccc] 를 출력함 : " + dictionary3["ccc"]);

            #region 제네릭 함수            
            //int a = 10;
            //int b = 20;
            //Console.WriteLine($"a = {a} , b = {b} 의 원래 값");

            //Swap<int>(ref a, ref b);
            //Console.WriteLine($"a = {a} , b = {b} 의 스왑한 후의 값");

            //string aa = "가";
            //string bb = "나";
            //Console.WriteLine($"aa = {aa} , bb = {bb} 의 원래 값");

            //Swap<string>(ref aa, ref bb);
            //Console.WriteLine($"aa = {aa} , bb = {bb} 의 스왑한 후의 값");

            #endregion

            #region 제네릭 클래스의 기본
            //SolveProb prob = new SolveProb();
            //Console.WriteLine("prob으로 생성한 SolveProb클래스의 ToString을 불렀습니다 : \n" + prob.ToString());

            //GenericClass<int> genInt = new GenericClass<int>(10);
            //Console.WriteLine("제네릭 클래스 int형의 ToString을 부름 : " +genInt.ToString() );

            //genInt.ShowMemberValue(); //이안에 console.Writeline이 있음


            //GenericClass<float> genFloat = new GenericClass<float>(10.5f);
            //Console.WriteLine("제네릭 클래스 float형의 ToString을 부름 : " + genFloat.ToString());

            //genFloat.ShowMemberValue(); //이안에 console.Writeline이 있음

            #endregion
            //Stack , Queue 동일..
            //List<int>
            //List<char>
            //List<float>
            //    List<double>
            //    List<string>
            //    List<SolveProb>
            //List<AA>
            //List<BB>
            #region 실습4
            ////어떤 수가 입력되었을 때, 천단위 구분 기호 콤마 (,) 넣어서 그 수를 다시 출력하기

            //// ex) 1000 => 1,000   
            ////     165421230325 =>  165,421,230,325

            //Stack<char> stack = new Stack<char>(); 

            //Console.WriteLine("천단위 구분기호를 넣어줄 숫자를 입력해주세요");
            //string str = Console.ReadLine();

            //for (int i = 1; i <= str.Length; i++)
            //{
            //    stack.Push(str[str.Length - i]);
            //    if (i % 3 == 0)
            //    {
            //        if (i != str.Length)
            //        {
            //            stack.Push(',');
            //        }
            //    }
            //}

            ////for문 증감식은 조건이 여러개 가능..
            ////조건 두개를 이용한 방법
            //int j = 1;           

            //for (int i = str.Length - 1; i >= 0; i--, j++) // 123456
            //{
            //    stack.Push(str[i]);
            //    if (j % 3==0)
            //    {
            //        if (i != 0)
            //        {
            //            stack.Push(',');
            //        }
            //    }
            //}

            // Console.WriteLine("천단위 구분기호를 넣은 결과물 : " + new string(stack.ToArray()));

            //#####팁
            //char[] 배열을 string 으로 바꾸는 쉬운 방법
            //char[] charArr = new char[]{}; //뭔가 내용이 있는, charArr이라는 이름의 char 배열이 있을때,
            //string str = new string(charArr);  //하면 charArr의 char들을 이어붙인 str이라는 문자열을 사용 가능.

            #endregion

            #region 실습3
            ////괄호가 바르게 짝지어졌다는 것은 '(' 문자로 열렸으면 반드시 짝지어서 ')' 문자로 닫혀야 한다는 뜻입니다.예를 들어

            ////"()()" 또는 "(())()" 는 올바른 괄호입니다.
            ////")()(" 또는 "(()(" 는 올바르지 않은 괄호입니다.
            ////'(' 또는 ')' 로만 이루어진 문자열 s가 주어졌을 때,
            ////문자열 s가 올바른 괄호이면 true를 return 하고, 올바르지 않은 괄호이면 false를 return 하는 solution 함수를 완성해 주세요.

            ////제한사항            
            ////문자열 s는 '(' 또는 ')' 로만 이루어져 있습니다.

            //SolveProb prob = new SolveProb();
            //string s = "()()";
            //Console.WriteLine(prob.IsRight(s) ? "알맞은 괄호식입니다" : "잘못된 괄호식입니다"); //  O
            //s = "(())()";  
            //Console.WriteLine(prob.IsRight(s) ? "알맞은 괄호식입니다" : "잘못된 괄호식입니다"); //  O
            //s = ")()(";
            //Console.WriteLine(prob.IsRight(s) ? "알맞은 괄호식입니다" : "잘못된 괄호식입니다"); //  X
            //s = "(()(";
            //Console.WriteLine(prob.IsRight(s) ? "알맞은 괄호식입니다" : "잘못된 괄호식입니다"); //  X
            #endregion

            #region 실습2
            ////배열 arr가 주어집니다.배열 arr의 각 원소는 숫자 0부터 9까지로 이루어져 있습니다.
            ////이때, 배열 arr에서 연속적으로 나타나는 숫자는 하나만 남기고 전부 제거하려고 합니다.
            ////단, 제거된 후 남은 수들을 반환할 때는 배열 arr의 원소들의 순서를 유지해야 합니다. 예를 들면,
            ////arr = [1, 1, 3, 3, 0, 1, 1] 이면 [1, 3, 0, 1] 을 return 합니다.
            ////arr = [4, 4, 4, 3, 3] 이면[4, 3] 을 return 합니다.
            ////배열 arr에서 연속적으로 나타나는 숫자는 제거하고 남은 수들을 return 하는 solution 함수를 완성해 주세요.

            //int[] arr = new int[7] { 1, 1, 3, 3, 0, 1, 1 };
            //int[] arr2 = new int[5] { 4, 4, 4, 3, 3 };

            //SolveProb prob = new SolveProb();
            //int[] ans = prob.RemoveRepeats(arr);  //
            //for (int i = 0; i < ans.Length; i++)
            //{
            //    Console.WriteLine("ans의 " + i + "번째 요소 : " + ans[i]);
            //} //결과 1,3,0,1

            //int[] ans2 = prob.RemoveRepeats(arr2);
            //for (int i = 0; i < ans2.Length; i++)
            //{
            //    Console.WriteLine("ans2의 " + i + "번째 요소 : " + ans2[i]);
            //} //결과 4,3

            #endregion

            #region 실습1

            ////입력받은 문자열들을 역순으로 출력하기...
            //// ex ) abcde를 입력한다면  edcba 라고 출력하기...

            //Console.WriteLine("역순으로 출력할 문자를 입력해주세요");
            //string val = Console.ReadLine();

            //Stack<char> charstack = new Stack<char>();

            //for (int i = 0; i < val.Length; i++) //string 문자열의 길이만큼
            //{
            //    charstack.Push(val[i]);
            //}

            //int count = charstack.Count;

            //for (int i = 0; i < count; i++)
            //{
            //    Console.Write(charstack.Pop());
            //}

            #endregion

            #region 큐
            ////스택과 비슷
            //Queue<int> queue = new Queue<int>();

            ////큐 10개정도 요소를 채우고

            //for (int i = 1; i <= 10; i++)
            //{
            //    queue.Enqueue(i);
            //}

            ////3개 삭제...
            //for (int i = 0; i < 3; i++)
            //{
            //   Console.WriteLine("내가 꺼낸 숫자 : " + queue.Dequeue()); //내가 꺼낸대상을 알려줌..
            //}
            ////큐 전체 내용 출력하기 

            //Console.WriteLine("Dequeue 하고 남은 대상");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 스택
            //Stack<int> aaaaa_stack = new Stack<int>();

            //for (int i = 1; i <= 5; i++)
            //{
            //    aaaaa_stack.Push(i);
            //}

            //foreach (var item in aaaaa_stack) //해당 컬렉션을 복사해서 그 복사한 대상안에 있는 요소들을 한번씩 확인하는 기능
            //{
            //    Console.WriteLine(item);
            //}

            //aaaaa_stack.Pop();
            //Console.WriteLine("맨위에 것을 꺼냈음");

            //Console.WriteLine("맨 위의 요소 : "+ aaaaa_stack.Peek());

            //aaaaa_stack.Pop();
            //Console.WriteLine("맨위에 것을 꺼냈음");

            //Console.WriteLine("맨 위의 요소 : " + aaaaa_stack.Peek());

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Peek() : " + aaaaa_stack.Peek());
            //}                        

            //for (int i = 0; i < aaaaa_stack.Count; i++)
            //{
            //    aaaaa_stack.Pop();
            //}  /// aaaaa_stack.Clear();  와 동일.

            //foreach (var item in aaaaa_stack) //해당 컬렉션을 복사해서 그 복사한 대상안에 있는 요소들을 한번씩 확인하는 기능
            //{
            //    Console.WriteLine(item);
            //}                        

            //============CopyTo기능이 있지만, 잘 안씀.. 비추

            //int[] arr = { 11, 22, 33, 44, 55 }; //배열선언
            //aaaaa_stack.CopyTo(arr, 0); //0번째 부터 복사를 할것임 //복사가 시작되는 인덱스...

            //Console.WriteLine("=============배열에다가 복사=============aaaaa_stack 확인");
            //foreach (var item in aaaaa_stack)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("=============배열에다가 복사=============arr 확인");
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //List<int> list = new List<int>() { 111, 222, 333, 444, 555, 666 }; //리스트선언
            //aaaaa_stack.CopyTo(list.ToArray(), 2);//0번째 부터 복사를 할것임

            //foreach (var item in aaaaa_stack)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
}