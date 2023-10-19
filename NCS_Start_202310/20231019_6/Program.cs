/*
 * 플레이어 존재. => 플레이어 이름, 공격력, 채력,
 * 부모클래스 아이템이 있다.
 * 아이템 클래스를 상속 받는 자식 클래스 아이템 삼종 이상 만들고
 * 아이템 사용하기
 *
 * 간이 인벤토리 실습
 *
 * 플레이어가 아이템을 들고 있는데, 랜덤개수만큼 랜덤하게 들고 있고
 * => 보유 아이템 종류/ 개수 먼저 보여주기...
 *
 * 무슨 아이템을 사용하겠다. 하면 이제 아이템 사용하고 ( 플레이엉 보유 아이템에서 삭제 )
 * 뭔가 사용했다는 표시 출력도 하고..
 */

using System;
using System.Collections.Generic;
using Console = System.Console;

namespace _20231019_6
{
    enum ItemType
    {
        Sword,
        Potion,
        Shield,
        
        End
    }

    class Item
    {
        public ItemType itemType = ItemType.End;
        private string name = "";
        private int index = 0;

        Item(string name, int index)
        {
            this.name = name;
            this.index = index;
            
        }
    }

    class Sword : Item
    {
        
        public Sword(string name, int power)
        {
            
            itemType = ItemType.Sword;
        }

        static void SwordFunction()
        {
            Console.WriteLine("검을 사용함");
        }
    }

    class Potion : Item
    {
        static void PotionFunction()
        {
            Console.WriteLine("포션을 사용함");
        }
    }

    class Shield : Item
    {
        static void ShieldFunction()
        {
            Console.WriteLine("방패를 사용함");
        }
    }

    class Player
    {
        private string name = "";
        private int power = 0;
        private int hp = 0;

        private List<Item> myItemList = new List<Item>();
        Player(string name, int power, int hp)
        {
            this.name = name;
            this.power = power;
            this.hp = hp;
        }

        public void StatsInfo(string name, int power, int hp)
        {
            Console.WriteLine("***************");
            Console.WriteLine($"이름 : {name}");
            Console.WriteLine($"공격력 : {power}");
            Console.WriteLine($"채력 : {hp}");
            Console.WriteLine("***************");
        }

        public void GetItem()
        {
            
        }

        public void UseItem()
        {
            
        }
    }

    
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}