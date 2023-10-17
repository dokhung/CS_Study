using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace Mission18
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * 자판기에서 음료사보기..
             * 나의 소지금을 랜덤으로 좀 넉넉하게 생성하고
             * 자판기 음료를 미리 세팅을 해둡시다.
             * 단, 배열 혹은 리스트를 사용해서
             * 자판기 음료의 정보는 음료이름, 가격
             * 내가 사고자하는 음료의 이름 또는 번호를 택해서 구매
             * 나의 소지금에서 금액이 빠져나감..
             * 구매를 클래스랑 함수 선언해서 사용해서 쓰는 쪽으로..
             * 자판기 클래스를 선언하고 해당 자판기 클래스는 음료목록을 소지
             * 음료 목록과 가격을 알려주는 함수와
             * 매개변수로 이름 혹은 번호를 넣으면 가격을 리턴하는 함수
             * 나의 소지금 랜덤으로 선언하고
             * 내가 원하는 만큼 음료 구매하는 작업 진행하기...
             */
            Console.WriteLine("음료를 구매합시다~");
            Console.Write("현재 나의 소지금 : ");
            Random random = new Random();
            int MyMoney = random.Next(20, 61) * 100;
            
            Console.WriteLine(MyMoney);
            
            
            Console.WriteLine("자판기 음료 목록");
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.ShowDrinkList();

            string choose = "";
            int choosenum = 0;
            int price = 0;
            
            while (true)
            {
                if (MyMoney <= 0)
                {
                    Console.WriteLine("소지금이 없습니다.");
                    return; // 프로그램의 종료
                }
                
                Console.WriteLine("구매하실 음료를 선택해주세요");
                choose = Console.ReadLine();
                
                if (int.TryParse(choose, out choosenum))
                {
                    price = vendingMachine.GetDrinkPrice(choosenum);
                }
                else
                {
                    price = vendingMachine.GetDrinkPrice(choose);
                }

                Console.WriteLine();
                if (price == -1)
                    {
                        Console.WriteLine("잘못된 선택 입니다");
                        continue; // 건너뜀
                    }
                    // else
                    // {
                        Console.WriteLine("선택한 음료의 가격은" + price + "원 입니다.");
                        /*
                         * 예외처리.
                         * 음료의 금액이 내 소지금보다 작을떄 일을 수행하고, 내가 살수 없는 상태라면 돌려보내기
                         */
                        if (MyMoney < price)
                        {
                            Console.WriteLine("선택한 음료를 구매하기엔, 소지금이 "+ (price - MyMoney) +"원 부족합니다.");
                            // 얼마 부족한지 알려주면 더 좋음
                            continue;
                        }

                        MyMoney -= price;
                        Console.WriteLine("구매완료.\n 나의 소지금 : " + MyMoney);

            }



        }







        class VendingMachine
        {
            private List<Drink> drinkList = new List<Drink>();


            // 음료목록 가지기
            public VendingMachine()
            {
                drinkList.Add(new Drink("포카리스웨트", 2600));
                drinkList.Add(new Drink("환타", 1500));
                drinkList.Add(new Drink("코카콜라", 1900));
                drinkList.Add(new Drink("커피", 1200));
                drinkList.Add(new Drink("보리차", 1100));
            }



            // 음료목록 보여주기 함수
            public void ShowDrinkList()
            {
                Console.WriteLine("=======================================");
                for (int i = 0; i < drinkList.Count; i++)
                {
                    Console.WriteLine($"음료이름 :{drinkList[i].DrinkName} " +
                                      $"음료가격 : {drinkList[i].DrinkPrice}원");
                }

                Console.WriteLine("=======================================");
            }

            // 음료 가격 알려주는(반환하는) 함수 ( 매개변수로 음료 이름 )
            public int GetDrinkPrice(string _name)
            {
                for (int i = 0; i < drinkList.Count; i++)
                {
                    if (drinkList[i].DrinkName == _name)
                    {
                        return drinkList[i].DrinkPrice;
                    }
                }

                return -1;
            }

            public int GetDrinkPrice(int _num)
            {
                if (_num <= 0 || _num > drinkList.Count)
                {
                    return -1;
                }

                return drinkList[(_num - 1)].DrinkPrice;
            }
        }

        // Drink 목록 가지기.. // 배열이어도 되고 리스트 여도 됩니다.
            public class Drink
            {
                /*
                 * 음료 번호 를 추가해도 됨
                 * 음료이름
                 * 음료가격
                 */
                public string DrinkName = ""; // 음료 이름
                public int DrinkPrice = 0; // 음료 가격

                public Drink()
                {
                }



                public Drink(string name, int price)
                {
                    DrinkName = name;
                    DrinkPrice = price;
                }

            }

            // 음료 가격 알려주는(반환하는) 함수 ( 매개변수로 음료 번호 )
            // public int GetDrinkPrice(int _num)
            // {
            //     for (int i = 0; i < drinkList.Count(); i++)
            //     {
            //         if (_num <= 0 || _num > drinkList.Count)
            //         {
            //             return -1;
            //         }
            //     }
            //
            //     return drinkList[_num - 1].DrinkPrice;
            // }





        }
    }