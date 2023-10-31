using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace TextRPGProject
{
    public class Monster
    {
        private string name;
        private int level;
        private int hp;
        private int maxhp;
        private int exp;
        private int speed;
        private int power;

        class Level1Monster
        {
            private Random random = new Random();
            public string name = "monster";
            public int hp = 10;
            public int maxhp = 10;
            public int power = 1;
            public int exp = 0;
            public int level = 1;
            public Player player = new Player();

            public void Att(int x)
            {
                x = random.Next(1, 2);
                player.hp -= x;

            }

            public int DropExp(int x)
            {
                return x = random.Next(1, 2);
            }
            
        }

        public void MonsterInfo()
        {
            Level1Monster level1Monster = new Level1Monster();
            Player player = new Player();
            Console.WriteLine("---------");
            Console.WriteLine($"이름 : {level1Monster.name}");
            Console.WriteLine($"현재 채력 : {level1Monster.hp} / {level1Monster.maxhp}");
            Console.WriteLine($"공격력 : {level1Monster.power}");
            Console.WriteLine($"레벨 : {level1Monster.level}");
            Console.WriteLine("---------");
            Console.WriteLine();
            Console.Write("1. 뒤로가기");
            char key = Console.ReadKey().KeyChar;
            switch (key)
            {
                case '1':
                    player.BetteJon();
                    Console.Clear();
                    break;
                default:
                    break;
            }
        }
    }

    public class Player : Monster
    {
        private int hp;
        private int power;
        private int maxhp;
        private int exp;
        private int maxexp;
        private int level;
        private string name = "user";

        public void StartMain()
        {
            Console.Clear();
            Console.WriteLine("<Home>");
            Console.WriteLine("----------------");
            Console.WriteLine("1. 나의 정보");
            Console.WriteLine("2. 던전으로 가기");
            Console.WriteLine("3. 상점으로");
            Console.WriteLine("4. 내 방으로");
            Console.WriteLine("----------------");
            Console.Write("키를 누르세요 : ");
            char key = Console.ReadKey().KeyChar;

            switch (key)
            {
                case '1':
                    PrintPlayerInfo();
                    break;
                case '2':
                    BetteJon();
                    break;
                default:
                    break;
            }
            
        }

        public void PrintPlayerInfo()
        {
            int hp = 50;
            int power = 5;
            int maxhp = 50;
            int exp = 0;
            int maxexp = 10;
            int level = 1;
            string name = "user";

            Console.Clear();
            Console.WriteLine("<정보>");
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"이름 : {name}");
            Console.WriteLine($"현재 채력 : {hp} / {maxhp}");
            Console.WriteLine($"공격력 : {power}");
            Console.WriteLine($"레벨 : {level}");
            Console.WriteLine($"현재 경험치 : {exp} / {maxexp}");
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
            Console.Write("1. 뒤로가기");
            char key = Console.ReadKey().KeyChar;
            switch (key)
            {
                case '1':
                    StartMain();
                    Console.Clear();
                    break;
                default:
                    break;
            }
            
            
        }
        

        public void BetteJon()
        {
            Monster monster = new Monster();
            Console.Clear();
            Console.WriteLine("<던전>");
            Console.WriteLine("---------------");
            Console.WriteLine("몬스터와 조우했습니다.");
            Console.WriteLine("1.몬스터 정보 보기");
            Console.WriteLine("2.도망치기");
            Console.WriteLine("3.배틀");
            Console.WriteLine("---------------");
            Console.Write("입력하세요 : ");
            char key = Console.ReadKey().KeyChar;
            switch (key) 
            {
                case '1':
                    Console.Clear();
                    monster.MonsterInfo();
                    break;
                default:
                    break;
            }
        }

    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Player player = new Player();
            player.StartMain();
        }
    }
}