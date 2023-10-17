using System;
using System.Collections.Generic;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 배열 & 리스트 활용문제 2            

            //입력받을 명수를 맨처음에 입력하고
            //해당 수 만큼 사람의 이름과, 나이를 입력합니다

            //입력이 완료되면, 사람의 이름으로 검색시 나이를 반환해 줍니다.
            string findName = ""; //찾고자 한 사람의 이름
            int findNum = 0; //돌려줄, 찾고자 했던 사람의 index번호

            Console.WriteLine("입력받을 명수를 입력해주세요");
            if (int.TryParse(Console.ReadLine(), out int count))
            {
                string[] person = new string[count]; //입력받을 명수만큼의 string 배열 선언
                int[] age = new int[count]; //입력받을 명수 만큼의 int 배열 선언

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(i + "번째 사람의 이름을 입력해주세요");
                    person[i] = Console.ReadLine();
                    Console.WriteLine(i + "번째 사람의 나이를 입력해주세요");
                    age[i] = Convert.ToInt32(Console.ReadLine()); //숫자를 정상적으로 입력했다면 문제없이 컨버트 해서 들어갈 것임....
                }
                //원하는 명수만큼의 입력이 종료됨...

                //검색 => 직접검색과  IndexOf(이거는 List일 경우....)의 사용. 두가지 방법 존재
                Console.WriteLine("나이를 알고 싶은 사람의 이름을 입력해주세요");
                findName = Console.ReadLine(); //찾고자 한 사람의 이름


                //검색 방법 1번
                for (int i = 0; i < count; i++)
                {
                    //string 비교 방법1
                    if (person[i] == findName)
                    {
                        findNum = i;
                        break;
                    }

                    ////string 비교 방법 2
                    //if (string.Equals(person[i], findName))
                    //{
                    //    findNum = i;
                    //    break;
                    //}
                }


                Console.WriteLine(findName + "의 나이는 " + age[findNum] + "살 입니다");
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다");
            }

            #endregion

            #region 리스트를 활용한 문제

            ////무한 입력 받을 거에요...
            ////종료~ 같은걸 입력하면 프로그램이 완전히 종료될 것임

            ////n개의 숫자를 입력받을 것인데, 숫자 입력의 끝은 0미만 숫자로 알림. (ex. -1입력시 숫자 입력을 종료한다는 뜻임)

            ////이렇게 입력받은 n개의 숫자의 평균을 내고, 그와 동시에 가장 큰 수를 찾기

            /////=========================
            ////할 작업이 많아서 헷갈린다면
            ////일의 순서를 주석으로 먼저 다 써놓고 그 밑에 구현하는 것이 좀 편할 것..
            ///
            //만약 입력한 것이 숫자로 바뀌지 않는다면 일반 문자일것
            //만약 종료를 입력한 것이였다면
            //프로그램의 완전한 종료    
            //그게 아니면 숫자
            //입력받은 숫자가 0미만일 경우
            // 입력받은 n개의 숫자 평균과 가장 큰 수를 찾기
            //입력받은 숫자가 0이상일 경우
            //리스트에 더해서 목록을 작성해둠                        

            //string strValue = "";
            //int inputValue = 0;
            //List<int> intList = new List<int>();
            //int sum = 0;
            //int max = 0;
            //while (true) //무한입력
            //{
            //    Console.WriteLine("숫자를 입력해주세요");
            //    strValue = Console.ReadLine(); //입력받기

            //    if (int.TryParse(strValue, out inputValue) ) //
            //    {
            //        //내가입력한것이 숫자임
            //        if (inputValue < 0)
            //        {
            //            //숫자 입력을 중단함
            //            //평균을 내고, 가장 큰수를 찾는 작업을 할 것임.
            //            //평균 == (총합 / 개수)
            //            for (int i = 0; i < intList.Count; i++)
            //            {
            //                sum += intList[i]; //리스트의 각 요소를 sum에다가 누적 더함
            //                if (max < intList[i])
            //                {
            //                    max = intList[i];
            //                }
            //            }

            //            //반올림 == Math.Round() / 올림 == Math.Ceiling() / 버림 == Math.Truncate()

            //            Console.WriteLine("여태 입력한 값의 평균 : " + Math.Round( ((float)sum / intList.Count), 1 ) );
            //            Console.WriteLine("가장 큰 수 : " + max);

            //            intList.Clear(); //목록 청소. 다시 목록에 새로운 애들을 적재하기 위함.
            //            sum = 0;
            //            max = 0;
            //        }
            //        else
            //        {
            //            //정상적인 숫자를 입력해서, 리스트에 추가하는 작업을 할 것임.
            //            intList.Add(inputValue);
            //        }
            //    }
            //    else
            //    {
            //        //입력한것이 숫자가 아님
            //        Console.WriteLine("프로그램을 종료합니다");                    
            //        //break;
            //        return;
            //    }                                        
            //}



            //sort는 정렬이고 reverse 인덱스의 역전...
            //List<int> intlist = new List<int>() { 5, 1, 4, 6, 3, 2 }; //2 3 6 4 1 5
            //intlist.Sort( new Comparison<int>((n1, n2)=> n2.CompareTo(n1)) ); //람다식을 이용한 sort...

            //for (int i = 0; i < intlist.Count; i++)
            //{
            //    Console.WriteLine(intlist[i]);
            //}

            #endregion

            #region 기본 함수 추가로..

            //List<int> intlist = new List<int>() { 5, 1, 4, 6, 3, 2};

            //Console.WriteLine("리스트안에 3이 있는가 ?  : " + intlist.Contains( 3  ) );  // 나의리스트.Contains( 내가 찾고자 하는 대상 )
            ////있다면 True 반환 없다면 False 반환

            //Console.WriteLine("3이 리스트 안에 어디에 있는가 ? : " +  intlist.IndexOf(3)); //3 이라는 숫자가 몇번 index에 있는지 알려줌
            //Console.WriteLine("7이 리스트 안에 어디에 있는가 ? : " + intlist.IndexOf(7)); //내가 찾는 대상이 없다면 -1을 줌.

            //int[] intarr = intlist.ToArray(); //리스트를 배열로 바꿈

            //for (int i = 0; i < intarr.Length; i++)
            //{
            //    Console.WriteLine( "배열에 리스트가 잘 들어갔는지 확인 " +intarr[i]);
            //}

            ////====================
            //Console.WriteLine(); //보기 좋으라고 엔터 넣음
            ////=======================
            ////물론 배열도 리스트로 만들수는 있지만

            //List<int> newList = new List<int>();
            //newList.AddRange(intarr); //배열을 리스트에 넣음..

            //for (int i = 0; i < newList.Count; i++)
            //{
            //    Console.WriteLine("배열에 리스트가 잘 들어갔는지 확인 " + newList[i]);
            //}

            //newList.Sort(); //오름차순
            //Console.WriteLine("\n오름차순 실행함");
            //for (int i = 0; i < newList.Count; i++)
            //{
            //    Console.WriteLine("리스트 확인 " + newList[i]);
            //}
            //Console.WriteLine("\n내림차순 실행함");
            //newList.Reverse(); //넣은 것의 역순
            //for (int i = 0; i < newList.Count; i++)
            //{
            //    Console.WriteLine("리스트 확인 " + newList[i]);
            //}


            //Array.Sort(intarr); //배열의 오름차순 실행
            //Array.Reverse(intarr); //배열의 역순 실행


            #endregion

            #region 리스트 일부 지우기

            ////7개의 리스트 생성
            ////한번 내용을 쫙 보여준 후에
            ////짝수의 index마다 요소를 삭제할것..
            ////잘 삭제되었는지 또 보여줄것..


            //Random random = new Random();            

            //List<int> intList = new List<int>();
            //for (int i = 0; i < 7; i++)
            //{
            //    intList.Add( random.Next(-20, 20) );

            //    Console.WriteLine(i+"번째 리스트 내용 : "+   intList[i]);
            //}

            //for (int i = intList.Count - 1; i >= 0; i--)
            //{
            //    //1번 방법
            //    if (i % 2 ==0 ) //짝수의 인덱스
            //    {
            //        intList.RemoveAt(i);
            //    }

            //    //========================

            //    ////2번 방법
            //    //if (i % 2 == 1) //홀수의 인덱스
            //    //{
            //    //    continue;
            //    //}
            //    //intList.RemoveAt(i);
            //}

            //Console.WriteLine();

            //for (int i = 0; i < intList.Count; i++)
            //{                
            //    Console.WriteLine(i + "번째 리스트 내용 : " + intList[i]);
            //}


            #endregion

            #region 리스트 하나씩 비워내기

            ////리스트 선언. 최소 5개이상 더하기.
            ////반복문을 이용하여 하나씩 다 지워내기.

            //List<int> intList = new List<int>() /*{ 1,2,3,4,5 }*/ ;

            //Random random = new Random();
            //int val = random.Next(5, 8);

            //for (int i = 0; i < val; i++)
            //{
            //    intList.Add(random.Next(-10, 11));
            //    Console.WriteLine(i+"번째 리스트의 값 : " + intList[i]);
            //}
            //Console.WriteLine("리스트의 개수 : " + intList.Count);

            //Console.WriteLine("\n========삭제 작업 시작=========\n");

            ////에러는 나지않지만, 절반밖에 지울 수 없음
            ////for (int i = 0; i < intList.Count; i++)
            ////{
            ////    Console.WriteLine("i의 수 : " +i +  "    /    리스트의 개수 체크 : " + intList.Count);
            ////    intList.RemoveAt(i);                
            ////}

            ////리스트 개수는 줄어드는데 반복문의 횟수와 접근할 인덱스 i는 계속 늘어나서 에러남
            ////int count = intList.Count;
            //////count는 이 밑으로 항상~ 숫자 5임...
            ////for (int i = 0; i < count; i++)
            ////{
            ////    Console.WriteLine("i의 수 : " + i + "    /    리스트의 개수 체크 : " + intList.Count);
            ////    intList.RemoveAt(i);
            ////}

            //for (int i = intList.Count - 1; i >= 0; i--)
            //{
            //    intList.RemoveAt(i);
            //}

            //Console.WriteLine("삭제 작업 후의 리스트의 개수 : " + intList.Count);
            //for (int i = 0; i < intList.Count; i++)
            //{
            //    Console.WriteLine(i + "번째 리스트의 값 : " + intList[i]);
            //}

            ////=> 어차피 다 지워야 한다면

            //intList.Clear(); //다지워짐

            #endregion

            #region 리스트
            //List<string> strList = new List<string>();
            ////strList.Add("값");


            //Console.WriteLine("리스트의 개수 : " + strList.Count);

            //strList.Add("가");
            //strList.Add("나");
            //strList.Add("다");
            //strList.Add("라");

            //Console.WriteLine("리스트의 개수 : " + strList.Count);


            //for (int i = 0; i < strList.Count; i++)
            //{
            //    Console.WriteLine(i + "번째 리스트 내용 : " + strList[i]);
            //}

            //strList.Remove("다");  //리스트안의 값을 검색해서 해당 값을 지움

            //Console.WriteLine("\n '다'를 삭제한 리스트의 개수 : " + strList.Count + "\n");

            //for (int i = 0; i < strList.Count; i++)
            //{
            //    Console.WriteLine(i + "번째 리스트 내용 : " + strList[i]);
            //}


            //strList.RemoveAt(2); //해당 인덱스를 지움

            //Console.WriteLine("\n 인덱스 '2'번째를 삭제한 리스트의 개수 : " + strList.Count + "\n");


            //for (int i = 0; i < strList.Count; i++)
            //{
            //    Console.WriteLine(i + "번째 리스트 내용 : " + strList[i]);
            //}

            #endregion

            #region 2차원배열 역행연습
            ////2차원 배열 선언, 각각 칸에 랜덤값 넣기
            ////값이 채워진 2차원 배열을 역행 출력하기.

            ////    int[,] 이름짓기 = new int[행, 열];
            ////    행렬이름.Length == (행x열)의 크기..
            ////    행렬이름.GetLength(0) == 행의 크기
            ////    행렬이름.GetLength(1) == 열의 크기

            //Random random = new Random();

            //int[,] intarr = new int[3, 4];

            //for (int i = 0; i < intarr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < intarr.GetLength(1); j++)
            //    {
            //        intarr[i, j] = random.Next();
            //    }
            //}

            //for (int i = intarr.GetLength(0) - 1; i >= 0; i--)
            //{
            //    for (int j = intarr.GetLength(1) - 1; j >= 0; j--)
            //    {
            //        Console.WriteLine($"[{i} , {j}] 의 값 : " + intarr[i, j]);
            //    }
            //}

            #endregion

            #region 1차원 배열 역행연습
            ////1차원 배열선언을 해서
            ////그 안에 랜덤 값(각각)을 다 넣어보기 //float int char double short...
            ////채운걸 역행하여 출력해보기  (감소형 반복문 => 증감식이 i-- 이런형태를 말하는것)

            //// * 배열은 크기를 "정해줘야" 함

            ////데이터형식[] 이름 = new 데이터형식[크기] { };
            //int[] intarr = new int[10]; //10칸짜리 1차원배열 생성

            //Random random = new Random(); //쓸준비함                        
            ////int value = 0;

            //for (int i = 0; i < intarr.Length; i++)
            //{
            //    //1번 방법
            //    intarr[i] = random.Next(/*최소값이상, 최대값미만*/);
            //    ////2번방법
            //    //value = random.Next(/*최소값이상, 최대값미만*/);
            //    //intarr[i] = value;
            //}

            //for (int i = intarr.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(i+"번째 배열 출력 : " + intarr[i]);
            //}

            #endregion

        }
    }
}