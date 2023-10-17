using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class Day2
    {
        static void main(string[] args)
        {
            //\t  == 탭 
            //2차원 배열

            //심화를 바란다면.. 요렇게 출력 해볼것..
            //가     라 
            //나     마
            //다     바

            string[,] arr = new string[2, 3];
            string[,] arr2 = new string[2, 3]
            {
                { "가", "나", "다"},
                { "라", "마", "바"}
            };

            Console.WriteLine("길이 체크 : " + arr2.Length);

            Console.WriteLine("arr2.GetLength(0)길이 체크 : " + arr2.GetLength(0));
            Console.WriteLine("arr2.GetLength(1)길이 체크 : " + arr2.GetLength(1));

            Console.WriteLine();

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write(arr2[i, j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }


            //try
            //{
            //    //배열써서 국영수 점수 입력해서 평균내기...                
            //    //국영수 점수를 입력해주세요~
            //    //세가지 항목을 다 입력시 평균은 얼마입니다 하고 알려주는 방식으로 작성할 것.
            //    //종료 혹은 -1 같은 것을 입력시에 프로그램을 종료할 것..

            //    //+++++추가로 국어/영어/수학 점수 불러오기 수행도 가능하도록 추가하기

            //    //Array.Clear(charArr, 0, charArr.Length); //배열 초기화...

            //    int[] score = new int[3] { 0,0,0}; //요거 반드시 활용할 것...
            //    int sum = 0;

            //    while (true)
            //    {
            //        sum = 0; 
            //        Console.WriteLine("국영수 점수의 평균을 알려주는 프로그램입니다");

            //        for (int i = 0; i < 3; i++)
            //        {
            //            if (i == 0)
            //            {
            //                Console.Write("국어 점수를 입력해주세요 : ");
            //            }
            //            else if (i == 1)
            //            {
            //                Console.Write("영어 점수를 입력해주세요 : ");
            //            }
            //            else if (i == 2)
            //            {
            //                Console.Write("수학 점수를 입력해주세요 : ");
            //            }

            //            if (int.TryParse(Console.ReadLine(), out int val))
            //            {
            //                if (val <= 0)
            //                {
            //                    i--; //다시 영어점수를 받고 싶다면... 이걸 추가하기..
            //                    Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요");
            //                    //continue;
            //                    break;
            //                }
            //                score[i] = val;
            //                sum += val;
            //            }
            //            else
            //            {
            //                Console.WriteLine("잘못된 입력입니다. 입력을 종료합니다");
            //                return;
            //            }
            //        }  //국영수 입력의 끝

            //        Console.WriteLine("국영수 점수의 평균값은 " + (sum / score.Length) + "점 입니다");


            //        //다시 국영수 점수 입력을 할 것인지 / 혹은 국어,영어,수학 점수 중 특정 점수를 확인할 것인지...

            //    }

            //    Console.WriteLine("while문 밖임");


            //    //아스키코드로써의 활용
            //    //char[] charArr = new char[10];

            //    //for (int i = 0; i < charArr.Length; i++)
            //    //{
            //    //    charArr[i] = (char)('a' + i); // 97 + i 

            //    //    Console.WriteLine(i + "번째 charArr[] 요소 : " + charArr[i]);
            //    //}
            //    //Console.WriteLine(); //띄어쓰기

            //    //for (int i = 0; i < charArr.Length; i++)
            //    //{
            //    //    Console.WriteLine(i + "번째 charArr[] 요소 : " + (char)(charArr[i] - 32));
            //    //}                                


            //    //==============================

            //    //string str = "가나다라마바사아자차";
            //    //// string == char의 집합이다~                    
            //    //// char[] != string
            //    //// char a = str[i];

            //    //for (int i = 0; i < str.Length; i++)
            //    //{                    
            //    //    Console.WriteLine(str[i]);
            //    //}


            //    //"가","나","다","라"   가     들은    string배열 선언하기

            //    //string[] strarr = new string[4] { "가", "나", "다", "라" };

            //    //Console.WriteLine("index 2번째 요소 : " + strarr[2]);

            //    //Console.WriteLine("라 의 index 찾기 : " +Array.IndexOf(strarr, "라"));

            //    ////strarr의 요소 출력하기 
            //    //for (int i = 0; i < strarr.Length; i++)
            //    //{
            //    //    Console.WriteLine( i +"번째 요소 : "  +  strarr[i] );
            //    //}

            //    //==============================
            //    //int[] intarr = new int[3];

            //    //Console.WriteLine("intarr 배열의 길이 : "+intarr.Length);

            //    ////float[] intarr2 = new float[13];

            //    ////Console.WriteLine("intarr2 배열의 길이 : " + intarr2.Length);

            //    //for (int i = 0; i < 3; i++)
            //    //{
            //    //    intarr[i] = i + 1; //배열 채워넣기
            //    //    Console.WriteLine(intarr[i]);
            //    //}

            //    ////for (int i = 0; i < intarr.Length; i++)
            //    ////{
            //    ////    Console.WriteLine(intarr[i]);
            //    ////}

            //    //Array.Resize(ref intarr, 5); //리사이즈 권장하지 않음... 배열은 정해진 그대로 쓰는편이 좋다.
            //    //Console.WriteLine("intarr 배열의 길이 : " + intarr.Length);

            //    //Console.WriteLine("Array.IndexOf(intarr, 2) : " + Array.IndexOf(intarr, 2));
            //}
            //catch (Exception ex)
            //{

            //    throw ex;
            //}



            ////1차원 배열
            //int[] intarr = new int[5]; //속이 비어있는 5칸짜리 int 배열
            //int[] intarr2 = new int[] { 0, 0, 0, 0, 0 }; //5칸짜리 0으로 채워진 int 배열
            //int[] intarr3 = new int[5] { 0, 0, 0, 0, 0 }; //5칸짜리 0으로 채워진 int 배열

            //int[] intarr4;//= new int[] { };                        
            //intarr4 = new int[5]; //이 경우 혹은
            //intarr4 = new int[] { 0,0,0,0,0}; //이 경우 혹은
            //intarr4 = new int[5] { 0, 0, 0, 0, 0 }; //이 경우




            //===================================================

            ////try catch 

            //try
            //{
            //    int num1, num2;
            //    while (true)
            //    {
            //        Console.WriteLine("숫자를 두개 입력해주세요. 정상적인 입력이면 나눈 결과를 알려줍니다");
            //        Console.Write("첫번쨰 숫자 입력 : ");
            //        num1 = Convert.ToInt32(Console.ReadLine());

            //        Console.Write("두번재 숫자 입력 : ");
            //        num2 = int.Parse(Console.ReadLine());

            //        Console.WriteLine("처음숫자를 두번쨰 숫자로 나눈 결과 : " + (num1 / num2));
            //    }
            //}
            //catch (DivideByZeroException divideEx) //오류 캐치
            //{
            //    Console.WriteLine("0으로 나눈 문제가 발생함");
            //    //예외처리
            //    throw divideEx;
            //}
            //catch (OverflowException overEx)
            //{
            //    Console.WriteLine("오버플로우 발생");
            //    throw overEx;
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception("오류가 발생했습니다", ex);
            //}
            //finally //만약 오류보고서  제출을 위한 뭔가 밑작업...
            //{
            //    //
            //}

            //finally  //예외발생 여부와 상관없이 마지막에 반드시 실행할 내용
            //{
            //}

            ////증감연산자 중에 전위증가 후위증가... 친구들 체크

            //int a = 1;
            //Console.Write($"a의 값 = {a}, ");
            //int b = ++a;

            //Console.WriteLine($"전위증가한 a의 값 = {b} ");

            //a = 1;
            //Console.Write($"a의 값 = {a}, ");
            //b = a++; //a를 넣고
            ////이다음줄에서 a가 2가 되어있음

            //Console.WriteLine($"후위증가한 a의 값 = {b} ");

            //Console.WriteLine();

            //a = 1;
            //Console.Write($"a의 값 = {a}, ");
            //b = --a;

            //Console.WriteLine($"전위감소한 a의 값 = {b} ");

            //a = 1;
            //Console.Write($"a의 값 = {a}, ");
            //b = a--;
            ////a가 변해있음

            //Console.WriteLine($"후위감소한 a의 값 = {b} ");
            //Console.WriteLine($"후위 감소가 적용된 a 자체의 값 = {a} ");



            ////숫자 입력하면 해당 구구단 출력 하는 프로그램 만들기.  (만약 좀더 어렵게 진행하고 싶으신분은 구구단 역행으로 출력하기 ex. 2 x 9 = 18 / 2 x 8 = 16 / 2 x 7 = 14 ....)
            ////0이하의 숫자나 숫자가 아닌 것을 입력하면 종료하도록 만들기(종료 입력을 하지않으면 무한 반복함)

            //    int value = 0; //출력할 구구단 숫자

            //    while (true)
            //    {
            //        Console.WriteLine("출력하실 구구단의 숫자를 입력해주세요. (1보다 작거나, 종료 라고 입력시 종료됩니다) ");
            //        Console.Write("출력할 구구단 : ");                

            //        if (int.TryParse(Console.ReadLine(), out value))
            //        {
            //            if (value ==0)
            //            {
            //                Console.WriteLine("0을 입력하여 반복입력을 중단합니다\n"); //\n == 엔터
            //                goto GOAL; //goto문은 안쓰는 것이 좋음
            //            }
            //            else if (value < 1)
            //            {
            //                //goto GOAL2; 
            //                Console.WriteLine("자연수를 입력해주세요\n"); //\n == 엔터
            //                continue; //반복문의 맨처음으로 돌아감. 포문에서 쓸 경우, 증감식으로 돌아감.
            //            }


            //            //정상적인 숫자 입력함

            //            for (int i = 9; i > 0; i--)
            //            {
            //                Console.WriteLine($"{value} x {i} = { value * i } ");
            //            }

            //            Console.WriteLine(); //한줄 띄워주기

            //        }
            //        else //숫자를 쓰지 않은 경우
            //        {
            //            //GOAL2: //else 안에 있어서 if ~else로 나뉜 경우고.. 조건식 밖에 있어야함...

            //            Console.WriteLine("프로그램을 종료합니다");
            //            //break; //반복문을 나감
            //            return; //메서드를 나감. => 현재 메서드가 프로그램의 메인 함수이기 때문에 프로그램의 종료로 직결됨.
            //        }
            //    }

            //GOAL: //value를 0 눌렀을때 goto에서 이쪽으로 올 것임.
            //    Console.WriteLine("프로그램을 종료합니다");





            //// 무한루프의 while 문에서 continue와 break를 활용하여
            //// 30까지 3의 배수를 제외한 모든 자연수 더하기

            //int sum = 0;
            //int i = 1;
            //while (true) 
            //{
            //    if (i > 30)
            //    {
            //        break;
            //    }

            //    if (i % 3 == 0) //3의 배수니까
            //    {
            //        continue; //제외
            //    }

            //    sum += i; //위에서 걸러지지않은 3의 배수가 아닌 애들을 누적 더함

            //    i++;
            //}



            //반복문의 탈출

            //for (int i =0 ;  ; i++) //무한루프
            //{
            //    if (i % 2 == 0) //짝수면 스킵하고 다음조건 실행.
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i+"번째 반복중");

            //    if (i >= 10)
            //    {
            //        Console.WriteLine("i가 10이 되었음");
            //        break; //반복문의 탈출
            //        //return; //내가 있는 이 함수(메서드)의 탈출
            //    }

            //    Console.WriteLine("if문 다음 출력"); //i==10일때 이건 출력되지 않음. 위에서 이미 나가버렸기 때문.
            //}

            //Console.WriteLine("return 과 break 차이 위한 줄"); //return일때는 아예 위에서 이 함수를 나가버렸기 때문에 출력되지 않음.


            //==========================================

            //20보다 작은 자연수 == (1,2,3,4,5,,.....이런친구들) 중에서 3 또는 5의 배수를 모두 더한 값 구하기
            //x의 배수는 나머지가 0 인 경우겠죠
            //3과 5의 배수 둘다 해당되는 수를 두번 더하지 않도록 유의할 것
            //while문 사용해서 해결하기

            //int i = 1;
            //int sum = 0; //내가 구하고 싶은 값 변수 선언

            //while (i < 20)
            //{
            //    if (i % 3 == 0  || i % 5 == 0)//i가 현재 3의 배수 혹은 5의 배수다.
            //    {
            //        sum += i;
            //    }
            //    //else if (i % 5 ==0) //윗줄에 함께 하는것이 싫으면 이렇게 따로.
            //    //{
            //    // sum += i;
            //    //}

            //    i++; //조건부합할때까지 돌리기위함
            //}


            //while (false)
            //{
            //    Console.WriteLine("while문 입니다");
            //}

            //int i = 0;
            //do
            //{
            //    Console.WriteLine("do ~ while문 입니다");
            //    i++;
            //} while (i < 3);


            //int i = 0;
            //while ( i < 20 ) //조건이 계속 맞으니까 무한으로 돕니다
            //{
            //    Console.WriteLine(i + "번째 입니다");

            //    i++;
            //}

            ////동일한 별찍기

            //string str = ""; //빈 스트링 변수선언
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        str += "*";                    
            //    }
            //    Console.WriteLine(str);
            //    str = "";
            //}

            ////동일한 별찍기

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //구구단
            //for (int i = 2; i < 10; i++)
            //{
            //    //Console.WriteLine(); //그냥 한줄띄우기

            //    for (int j = 1; j < 10; j++)
            //    {
            //        Console.WriteLine(  $"{i} x {j} = { i * j } "    );                   
            //    }

            //    Console.WriteLine(); //그냥 한줄띄우기
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        Console.WriteLine(i + "번째 입니다");
            //    }                                                
            //}


            //2씩증가해서 5번 출력하는   반복문 만들어보기

            //for (int i = 0; i < 10 ; i = i + 2 ) //조건식을 건듦
            //{
            //    Console.WriteLine(i + "번째 입니다");
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine( i * 2 + "번째 입니다"); //출력 건듦
            //}

            //Console.WriteLine("===========================");

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine( "번째 입니다" + i + 2); //string +string+string의 경우
            //}

            //감소형 반복문
            //for (    int i = 3   ;     i > 0      ;    i--     ) //리스트 의 제거.. 
            //{
            //    Console.WriteLine( i + "번째 입니다");
            //}
        }
    }
}