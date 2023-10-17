using System;
using System.Collections.Generic;

namespace Mission14
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * 입력받을 명수를 맨 처음에 입력하고
             * 해당 수 만큼 사람의 이름과 나이를 입력합니다.
             * 입력이 완료되면 사람의 이름으로 검색시 나이를 반환해 줍니다.
             */
            // int intValue = 0;
            // string strValue = "";
            // List<int> intList = new List<int>();
            //
            // while (true)
            // {
            //     Console.Write("사람의 수를 입력하세요: ");
            //     int personCount = int.Parse(Console.ReadLine());
            //
            //     List<string> peopleList = new List<string>();
            //
            //     for (int i = 0; i < personCount; i++)
            //     {
            //         Console.Write("이름을 입력하세요: ");
            //         string name = Console.ReadLine();
            //
            //         Console.Write("나이를 입력하세요: ");
            //         int age = int.Parse(Console.ReadLine());
            //         string ageS = age.ToString();
            //         peopleList.Add(name);
            //         peopleList.Add(ageS);
            //     }
            //     Console.WriteLine("입력된 정보: ");
            //     for (int i = 0; i < peopleList.Count; i++)
            //     {
            //         Console.WriteLine(peopleList[i]);
            //     }
            //     Console.Write("등록이 완료 되었습니다. 검색하시겠습니까? 1번 Yes 2번 No");
            //     int serching = int.Parse(Console.ReadLine());
            //     if (serching == 1)
            //     {
            //         Console.Write("이름을 입력하세요 검색후 나이가 출력됩니다.");
            //         string serch = Console.ReadLine();
            //         
            //         for (int i = 0; i < UPPER; i++)
            //         {
            //             
            //         }
            //     }
            //     else
            //     {
            //         Console.WriteLine("종료합니다.");
            //         return;
            //     }
            //

            Console.WriteLine("입력받을 명수를 입력해주세요");
            if (int.TryParse(Console.ReadLine(), out int count))
            {
                string[] person = new string[count];
                // string[] age = new string[count];
                int[] age = new int[count];
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(i + "번째 사람의 이름을 입력해주세요");
                    person[i] = Console.ReadLine();
                    Console.WriteLine(i+"번째 사람의 나이를 입력해주세요");

                    age[i] = Convert.ToInt32(Console.ReadLine()); // 숫자를 정상적으로 입력했다면 문제없이 컨버트 됨
                    
                }

                string findeName = Console.ReadLine();
                int findNum = 0; // 돌려줄, 찾고자 했던 사람의 index번호
                Console.WriteLine("나이를 알고 싶은 사람의 이름을 알려주세요");
                for (int i = 0; i < count; i++)
                {
                    if (person[i] == findeName) // string 비교는 string.Equals(person[i], find
                    {
                        findNum = i;
                        break;
                    }
                    
                    /*
                     * 2번째 방법
                     * if(string.Equals(personp[i], findName))
                     * {
                     *findNum = i;
                     * break;
                     * }
                     */
                }

                Console.WriteLine(findeName + "의 나이는" + age[findNum] + "살 입니다.");
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
            }

            }

        }
    }
