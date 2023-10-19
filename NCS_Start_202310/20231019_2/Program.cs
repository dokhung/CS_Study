/*
 * 명시적 형변환
 * 자료형.parse()
 * 자료형.TryPArse()
 * Convert.데이터형식 바꾸기 가능
 *
 * enum은 숫자로도 쓸수있고, 문자열로 바로 바꿀수도 있음.. 그렇게 쓰려면 명시적 변환 필요
 *
 */

using System;

enum ItemType
{
    WEAPON, // ==0
    ARMOR, // == 1
    POTION, // ==2
    END // == 3
}

namespace _20231019_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            ItemType itemType = ItemType.END;
            Console.WriteLine("itemtype.ToString() :" + itemType.ToString());
            Console.WriteLine("(int)itemtype : " + (int)itemType);

            itemType = ItemType.WEAPON;
            Console.WriteLine("itemtype.ToString() : " + itemType.ToString());
            Console.WriteLine("(int)itemtype : " + (int)itemType);
        }
    }
}