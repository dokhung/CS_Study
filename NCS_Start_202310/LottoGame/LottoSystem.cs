using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoGame
{
    public class LottoSystem
    {
        public List<int> anwerNumber = new List<int>();

        public void Lotto()
        {
            anwerNumber = GetNumbers();
        }

        // 실행부
        public void Start()
        {
            Console.WriteLine("몇개의 번호를 뽑으시겠습니까?");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                List<int> list = GetNumbers();
                Print(list);
            }
        }

        // 랜덤으로 번호를 1~45까지 뽑은 뒤 6개를 반환하는 함수
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
            string str = "";
            int anserCnt = 0;

            for (int i = 0; i < anwerNumber.Count; i++)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (anwerNumber[i] == numbers[j])
                    {
                        anserCnt++;
                    }
                }
            }

            switch (anserCnt)
            {
                case 6:
                    Console.WriteLine("1등");
                    break;
                case 5:
                    Console.WriteLine("2등");
                    break;
                case 4:
                    Console.WriteLine("3등");
                    break;
                case 3:
                    Console.WriteLine("4등");
                    break;
                case 2:
                    Console.WriteLine("5등");
                    break;
                case 1:
                    Console.WriteLine("6등");
                    break;
                default:
                    return "꽝";
            }
            return str;
        }

        void Print(List<int> list)
        {
            string rank = GetStrRank(list);
            Console.Write("정답번호 : ");
            for (int i = 0; i < anwerNumber.Count; i++)
            {
                Console.Write(anwerNumber[i] + "\t");
            }
            Console.WriteLine();
            Console.Write("나의 번호 :");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + "\t");
            }
            Console.WriteLine(rank);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}