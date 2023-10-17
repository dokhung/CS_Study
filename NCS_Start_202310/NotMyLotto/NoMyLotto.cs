using System;
using System.Collections.Generic;
using System.Text;

namespace Study
{
    class Lotto
    {
        List<int> anwerNumber = new List<int>();
        public Lotto()
        {
            anwerNumber = GetNumbers();
        }

        // 실행부
        public void Start()
        {
            Console.WriteLine("몇개의 번호를 뽑으시갰습니까~?");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                List<int> list = GetNumbers();
                Print(list);
            }
        }

        // 랜덤으로 번호를 1~45까지 뽑은뒤 6개를 반환하는 함수
        List<int> GetNumbers()
        {
            List<int> list = new List<int>();
            List<int> tempList = new List<int>();

            for (int i = 0; i < 45; i++)
            {
                tempList.Add(i + 1);
            }

            for (int i = 0; i < 6; i++)
            {
                int rand = new Random().Next(0, tempList.Count);
                list.Add(tempList[rand]);
                tempList.RemoveAt(rand);
            }

            list.Sort();
            return list;
        }

        // List 안에 있는 값을 출력할때 쓰는 함수
        string GetStrRank(List<int> numbers)
        {
            int anwerCnt = 0;
            for (int i = 0; i < anwerNumber.Count; i++)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    if(anwerNumber[i] == numbers[j])
                    {
                        anwerCnt++;
                    }
                }
            }

            switch(anwerCnt)
            {
                case 5:
                    return "1등";
                case 4:
                    return "2등";
                case 3:
                    return "3등";
                default:
                    return "꽝";
            }
        }

        // 마지막 문자열을 조합하여 노출시켜준다.
        void Print(List<int> list)
        {
            string rank = GetStrRank(list);
            Console.Write("정답번호 : ");
            for (int i = 0; i < anwerNumber.Count; i++)
            {
                Console.Write(anwerNumber[i] + "\t");
            }
            Console.WriteLine();
            Console.Write("나의번호 : ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + "\t");
            }
            Console.Write(rank);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}