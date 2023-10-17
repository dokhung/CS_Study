using System;
using System.Collections.Generic;

namespace Mission13
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * 무한 입력 받을 거에요...
             * 종료~ 같은걸 입력하면 프로그램이 완전히 종료될 것임
             * n개의 숫자를 입력받을 것인데, 숫자 입력의 끝은 0미만 숫자로 알림.(ex. -1 입력시 숫자 입력을 종료한다는 뜻임)
             * 이렇게 입력받은 n개의 숫자의 평균을 내고, 그와 동시에 가장 큰 수를 찾기
             */

            
            // while (true)
            // {
            //         
            //         List<int> intList = new List<int>();
            //         Console.WriteLine("숫자를 입력하세요 종료를 입력하면 종료합니다.");
            //         Console.Write("1번째 숫자 입력");
            //         int a = int.Parse(Console.ReadLine());
            //         Console.Write("2번째 숫자 입력");
            //         int b = int.Parse(Console.ReadLine());
            //         Console.Write("3번째 숫자 입력");
            //         int c = int.Parse(Console.ReadLine());
            //         intList.Add(a);
            //         intList.Add(b);
            //         intList.Add(c);
            //         if (a == -1 || b == -1 || c == -1)
            //         {
            //             Console.WriteLine("-1이 입력되어 종료 합니다.");
            //             return;
            //         }
            //         else
            //         {
            //             int sum = 0;
            //             double avage = 0;
            //             sum = a + b + c;
            //             avage = sum / intList.Count;
            //             Console.WriteLine($"평균은{avage}입니다.");
            //             int tree = a;
            //             if (tree < b)
            //             {
            //                 tree = b;
            //             }
            //             else if(tree < c)
            //             {
            //                 tree = c;
            //             }
            //
            //             if (tree == a)
            //             {
            //                 Console.WriteLine("a가 가장 큽니다.");
            //             }
            //             else if (tree == b)
            //             {
            //                 Console.WriteLine("b가 가장 큽니다.");
            //             }
            //             else
            //             {
            //                 Console.WriteLine("c가 가장 큽니다.");
            //             }
            //             
            //             
            //         }
            //     }
            // 정답
            {
                // List<int> inilist = new List<int>();
                // inilist.Sort(new Comparison<int>((n1,n2)=>n2.CompareTo(n1))); // 람다식을 이용한 sort
                // for (int i = 0; i < inilist.Count; i++)
                // {
                //     Console.WriteLine(inilist[i]);
                // }
                string strvalue = "";
                int inputValue = 0;
                List<int> inilist = new List<int>();
                int sum = 0;
                int max = 0;
                while (true) // 무한입력
                {
                    Console.WriteLine("숫자를 입력해주세요");
                    strvalue = Console.ReadLine(); // 입력받기
                    if (int.TryParse(strvalue, out inputValue )) // TryParse가 반환값이 bool임
                    {
                        // 내가 입력한것이 숫자임
                        if (inputValue < 0)
                        {
                            //숫자 입력을 중단함
                            //평균을 내고, 가장 큰수를 찾는 작업을 할 것임.
                            //평균 == (총합/개수)
                            for (int i = 0; i < inilist.Count; i++)
                            {
                                sum += inilist[i]; // 리스트의 각 요소를 sum에다가 누적 더함
                                if (max < inilist[i])
                                {
                                    max = inilist[i];
                                }
                            }
                            // 반올림 == Math.Round() / 올림 == MAth.Ceiling() / 버림 == MAth.Truncate()
                            Console.WriteLine("여태 입력한 값의 평균 : " + Math.Round((float)(sum / inilist.Count),1));
                            Console.WriteLine("가장 컨 수 : " + max);
                            inilist.Clear(); // 목록 청소. 다시 목록에 새로운 애들을 적재하기 위함.
                            sum = 0;
                            max = 0;
                        }
                        else
                        {
                            //정상적인 숫자를 입력해서, 리스트에 추가하는 작업을 할 것임.
                            inilist.Add(inputValue);
                        }
                    }
                    else
                    {
                        Console.WriteLine("프로그램을 종료합니다.");
                        // 입력한것이 숫자가 아님
                        break;
                        return;
                    }
                }
            }
        }
        }
    }