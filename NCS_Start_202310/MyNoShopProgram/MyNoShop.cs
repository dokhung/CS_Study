using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MyNoShopProgram
{
    class Shop
    {
        Dictionary<string, int> menuDic = new Dictionary<string, int>();
        Dictionary<string, int> buyDic = new Dictionary<string, int>();

        string[] menuStrs = { "햄버거", "컵라면", "삼각김밥", "핫바", "과자" };
        int[] prices =      { 1200,     1800,       800,        1400,   400 };

        int myMoney = 0;
        //.ContainsKey 딕셔너리에 키가 존재 하는지 확인하는 함수

        // 생성자 - 바로 실행
        public Shop()
        {
            Console.Write("나의 소지금을 입력해주세요.");
            myMoney = int.Parse(Console.ReadLine());
            Console.WriteLine();
            CreateMenu();
            Start();
        }

        // 메뉴 생성
        void CreateMenu()
        {
            for (int i = 0; i < menuStrs.Length; i++)
            {
                menuDic.Add(menuStrs[i], prices[i]);
            }
        }

        // 실행부
        void Start()
        {
            PrintMenu();
            SelectMenu();
        }

        // 메뉴 선택
        void SelectMenu()
        {
            Console.Write("구입하실 번호를 입력 하시오.");
            int select = int.Parse(Console.ReadLine());
            string selectKey = menuStrs[select - 1];
            Console.Write($"[{selectKey}] 몇개를 구입하시겠습니까?");
            int cnt = int.Parse(Console.ReadLine());

            // 상품이 이미 등록 되어있다면...
            if (buyDic.ContainsKey(selectKey))
            {
                buyDic[selectKey] += cnt;
            }
            // 새로운 상품을 등록한다.
            else
            {
                buyDic.Add(selectKey, cnt);
            }

            Console.WriteLine("장바구니에 상품이 등록되었습니다.");
            Console.Clear();
            PrintBuyList();
            Console.WriteLine();
            FinishMenu();
        }

        /// <summary>
        /// 쇼핑이 끝났을때 처리 되는 함수
        /// </summary>
        void FinishMenu()
        {
            Console.WriteLine("쇼핑을 계속 진행하시겠습니까?(y, n)");
            if (Console.ReadLine() == "y")
            {
                Console.Clear();
                Start();
            }
            else
            {
                Console.WriteLine($"나의 소지금 : {myMoney}");
                Console.WriteLine($"쇼핑 총가격 : {BuyPriceSum()}");

                if (myMoney >= BuyPriceSum())
                {
                    Console.WriteLine("모든 상품의 구매가 완료 되었습니다.");
                    myMoney -= BuyPriceSum();
                    Console.WriteLine($"나의 남은 소지금은 : {myMoney}");
                }
                else
                {
                    RemoveMenu();
                }
            }
        }

        /// <summary>
        /// 메뉴의 갯수를 삭제 시키는 함수
        /// </summary>
        void RemoveMenu()
        {
            Console.WriteLine("소지금이 부족합니다.");
            Console.WriteLine("상품의 갯수를 줄여주세요.");
            PrintBuyList();

            int rSelect = int.Parse(Console.ReadLine());
            string key = string.Empty;
            int buyDicCnt = 0;
            foreach (var item in buyDic)
            {
                if (rSelect - 1 == buyDicCnt)
                {
                    key = item.Key;
                    break;
                }
                buyDicCnt++;
            }

            if (buyDic.ContainsKey(key))
            {
                RemoveMenuStep1(key);
            }
            else
            {
                Console.WriteLine("등록된 상품이 존재 하지 않습니다.");
                Console.WriteLine("다시 입력해주세요.");
                FinishMenu();
            }
        }

        /// <summary>
        /// 메뉴의 삭제부분 예외처리 함수
        /// </summary>
        void RemoveMenuStep1(string key)
        {
            Console.WriteLine($"[{key}] 몇개를 빼시갰습니까?");
            int removeCnt = int.Parse(Console.ReadLine());

            if (buyDic[key] < removeCnt)
            {
                Console.WriteLine("보유한 상품의 갯수보다 더 많습니다.");
                Console.WriteLine("다시 입력해주세요.");
                RemoveMenuStep1(key);
            }
            else
            {
                buyDic[key] -= removeCnt;
                if (buyDic[key] <= 0)
                    buyDic.Remove(key);
                PrintBuyList();
                FinishMenu();
            }
        }

        // 메뉴 
        void PrintMenu()
        {
            Console.WriteLine("<< 메뉴 >>");
            int menuCnt = 1;
            foreach (var item in menuDic)
            {
                Console.WriteLine($"{menuCnt++}. {item.Key} >> {item.Value}원");
            }
        }

        // 구입 목록 - 장바구니
        void PrintBuyList()
        {
            int buyCnt = 1;
            Console.WriteLine("-- 장바구니 --");
            foreach (var item in buyDic)
            {
                Console.WriteLine($"{buyCnt++}. {item.Key} >> {item.Value} : {item.Value * GetPrice(item.Key)}");
            }
            Console.WriteLine("-- ------- --");
        }

        /// <summary>
        /// 해당 메뉴의 가격을 가지고 오는 함수
        /// </summary>
        int GetPrice(string key)
        {
            int price = -1;
            foreach (var item in menuDic)
            {
                if (item.Key == key)
                    price = item.Value;
            }

            return price;
        }

        /// <summary>
        /// 장바구니에 담긴 가격의 총합.
        /// </summary>
        int BuyPriceSum()
        {
            int sum = 0;
            foreach (var item in buyDic)
            {
                sum += item.Value * GetPrice(item.Key);
            }
            return sum;
        }
    }
}