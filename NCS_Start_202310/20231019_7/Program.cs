using System;

namespace _20231019_7
{
    public enum ItemType
    {
        Sword,
        Armor,
        Potion,
        End
    }

    struct Info
    {
        public int att;
        public int hp;
        public int maxhp;

        public Info(int att, int hp)
        {
            this.att = att;
            this.hp = hp;
            maxhp = hp;
        }
        
    }

    class Player
    {
        private string name = "";
        private Info info;

        public Player(string name, Info _info)
        {
            this.name = name;
            info = _info;
        }

        public void ShowPlayerInfo()
        {
            Console.WriteLine($"플레이어 이름{name}, 공격력{info.att} 채력은 {info.hp}/{info.maxhp}입니다.");
        }
    }

    abstract class Item // 부모
    {
        public ItemType itemtype = ItemType.End;
        protected Info info;
        public abstract Info UseItem(Info Playerinfo); // 구조체를 받아서 구조체를 넘기는 방식
        
        public abstract void UseItem(Info Playerinfo, out Info afterInfo); // 구조체를 받아서 
        
        public abstract Info UseItem(Player playerinfo);
    }

    class Sword : Item
    {
        public Sword(int att)
        {
            info.att = att;
        }
        public override Info UseItem(Info Playerinfo)
        {
            Playerinfo.att += info.att;
            return Playerinfo;
        }

        public override void UseItem(Player playerinfo, out Info afterInfo)
        {
            
        }
    }

    class Armor : Item
    {
        public override void UseItem()
        {
            info.maxhp = hp
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}