using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLotto
{
    using System.Collections.Generic;
    using System;
    namespace MyLotto
    {
        public class Lotto
        {
            public void Start()
            {
                List<int> entryNum = new List<int>();
                Console.WriteLine("로또를 시도할 횟수를 입력하세요");
                int lottoCount = int.Parse(Console.ReadLine());
                Console.WriteLine($"{lottoCount}회를 시도 합니다");
                Console.WriteLine("랜덤으로 숫자를 지정하여 로또에 응모합니다");

            }

            public List<int> GetNumbers()
            {
                List<int> list = new List<int>();
                List<int> saveList = new List<int>();
                for (int i = 0; i < 45; i++)
                {
                    saveList.Add(i + 1);
                }

                for (int i = 0; i < 6; i++)
                {
                    int rnd = new Random().Next(0, saveList.Count);
                    list.Add(saveList[rnd]);
                    saveList.RemoveAt(rnd);
                }

                return list;
            }

            // string GetStrRank(List<int> numbers)
            // {
            //     string str = "";
            //     int entryCnt = 0;
            //
            //     for (int i = 0; i < UPPER; i++)
            //     {
            //         
            //     }
            // }

            public void Print(List<int> list)
            {

            }
        }
    }
}