using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopProgram
{
    class Shop
    {
        Dictionary<string, int> menuDic = new Dictionary<string, int>();
        Dictionary<string, int> buyDic = new Dictionary<string, int>();

        string[] menuStrs = { "햄버거", "컵라면", "삼각김밥", "핫바", "과자" };
        int[] prices = { 1200, 1800, 800, 1400, 400 };
        
        

        

        // 생성자 - 바로 실행
        public Shop(int Mymoney)
        {
            CreateMenu(Mymoney);

        }

        // 메뉴 생성
        void CreateMenu(int Mymoney)
        {
            for (int i = 0; i < menuStrs.Length; i++)
            {
                menuDic.Add(menuStrs[i], prices[i]);
            }

            SelectMenu(Mymoney);
        }

        // 실행부
        public void Start(int myMoney)
        {
            Console.WriteLine($"현재 내가 가지고 있는 돈은 {myMoney}원 입니다");
            CreateMenu(myMoney);
            PrintMenu();
        }
        

        // 메뉴 선택
        void SelectMenu(int myMoney)
        {
            Console.Write("구입하실 번호를 입력하시오: ");
            int buyNum = int.Parse(Console.ReadLine());

            if (buyNum >= 1 && buyNum <= menuDic.Count)
            {
                Console.Write("몇개를 구입하시겠습니까?: ");
                int purchasesNum = int.Parse(Console.ReadLine());

                if (purchasesNum > 0)
                {
                    string selectedMenu = menuStrs[buyNum - 1];
                    int price = menuDic[selectedMenu];

                    if (buyDic.ContainsKey(selectedMenu))
                    {
                        buyDic[selectedMenu] += purchasesNum;
                    }
                    else
                    {
                        buyDic[selectedMenu] = purchasesNum;
                    }

                    Console.WriteLine($"<<장바구니>>");
                    Console.WriteLine($" {selectedMenu} {buyDic[selectedMenu]}개 >> 총 비용: {buyDic[selectedMenu] * price}원");
                }
                else
                {
                    Console.WriteLine("수량은 1 이상이어야 합니다.");
                }
            }
            else
            {
                Console.WriteLine("올바른 메뉴 번호를 입력하세요.");
            }

            
            PrintBuyList(myMoney);
            Console.WriteLine("다시 장보기를 하려면 y 아니면 n");
            string plusBuy = Console.ReadLine();
            switch (plusBuy)
            {
                case "y":
                    CreateMenu(0);
                    break;
                case "n":
                    Console.Clear();
                    Console.WriteLine("이용해주셔서 감사합니다");
                    break;
            }
            
            


        }

        // 메뉴 
        void PrintMenu()
        {
            Console.WriteLine("<<메뉴>>");
            int index = 1;
            foreach (var item in menuDic)
            {
                Console.WriteLine($"{index}. {item.Key} >> {item.Value}원");
                index++;
            }
        }

        // 구입 목록 - 장바구니
        void PrintBuyList(int myMoney)
        {
            Console.WriteLine("<<장바구니 목록>>");
            foreach (var item in buyDic)
            {
                int price = menuDic[item.Key];
                Console.WriteLine($"{item.Value}개 {item.Key} >> 총 비용: {item.Value * price}원");
                int total = myMoney - item.Value * price;
                Console.WriteLine($"나에게 남은돈 : {total}원 남았습니다");
            }
            
        }
    }
}