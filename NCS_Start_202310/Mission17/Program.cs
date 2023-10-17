using System;

namespace Mission17
{
    public enum ItemType
    {
        Potion, // 회복시켜주는 포션
        Sword, // 공격력을 올려주는 검
        Armor, // 최대 채력 올려주는 갑옷
        End
        
    }
    internal class Program
    {
        static int enemyNum = 0;
        
        public static void Main(string[] args)
        {
            Random random = new Random(); // 랜덤 1 3 5 2 4
            Player myPlayer = new Player("나의 캐릭터", random.Next(2, 6), random.Next(10,21));
            myPlayer.ShowMyStatus(); // 내정보 일람
            string choose = "";
            while (true)
            {
                Console.WriteLine("1번 입력시 적을 찾아 떠납니다 \n 2번 입력시 아이템을 사용합니다");
                choose = Console.ReadLine();
                if (choose == "1")
                {
                    MeetEnemy(myPlayer); // 적과 전투하는 함수
                }
                else if(choose == "2")
                {
                    // 아이템 사용 기능 구현
                    myPlayer.UseItem();
                }
                else
                {
                    Console.WriteLine("잘못된 입력 입니다. 게임을 종료합니다.");
                    return;
                }
            }
            
        }

        
        static void MeetEnemy(Player _player) // 적을 만나서 싸우기...
        {
            
            enemyNum += 1;
            Random random = new Random();
            Player enemy = new Player("적" + enemyNum,random.Next(1,3), random.Next(5,11) );
            Console.WriteLine("========적을 만났습니다.=============");
            enemy.ShowMyStatus(); // 적의 정보 출력
            for (int i = 0; ; i++) // 초기화식과 증감식이 있지만, 조건식이 비었기 떄문에 무한반복
            {
                if (enemy.IsAlive == false)
                {
                    Console.WriteLine("적이 사망하였습니다.");
                    
                    // _player.ShowMyStatus(); // 나의 정보 확인
                    // 전리품 획득
                    // 무언가 랜덤으로 습득함
                    Item item = new Item(
                       (ItemType) random.Next(0,(int)ItemType.End), 
                        random.Next(1, 6));
                    _player.SetItem(item);
                    _player.ShowMyStatus(); // 나의 정보 확인
                    break;
                }
                else if (_player.IsAlive == false) // 적이나 내가 죽으면 이 전투를 종료
                {
                    Console.WriteLine("플레이어가 사망하였습니다.");
                    break;
                }
                else // 아무도 죽지 않음
                {
                    
                    // 전투 진행
                    if (i % 2 == 0)
                    {
                        // 내가 먼저 적을 공격함
                        enemy.Attack(_player); // 적의 채력을 매개변수로 들어온(플레이어)의 공격력으로 깍음
                        Console.WriteLine("내가 적을 공격하여, 적의 피가"+enemy.Hp);
                    }
                    else
                    {
                        // 그다음 적이 나를 공격함
                        _player.Attack(enemy);
                        Console.WriteLine("적이 나를 공격하여, 나의 피가 " + _player.Hp);
                    }
                }
            }
        }
    }
    
    /*
     * 플레이어와 적이 있고, 아이템 ( 물약, 검 , 갑옷) // 물약 == HP를 일정이상, 단 최대 HP가 넘지 않도록 늘려줌
     * 검 == 공격력 올림 / 갑옷 == 최대 HP 늘림
     * 나의 플레이어 => 이름 / 공격력 / HP /  최대 hp +++ 레벨 + 경험치
     * 적 => 이름 / 공격력 / HP /  (최대 HP ) 
     */

    class Player
    {
        public Item myItem { get; private set; } = null; // 변수선언
        public bool IsEnemy = true; // 아군인지 적인지 여부
        private string Name = "";
        private int Att = 0;
        public int Hp { get; private set; } = 0;
        private int MaxHp = 0;

        public bool IsAlive => Hp > 0;// 살아있는지 여부를 알려줄겁니다.

        public Player(string name, int att, int maxhp)
        {
            Name = name;
            Att = att;
            MaxHp = maxhp;
            Hp = maxhp;
        }

        public void SetAlliance(bool _enemy)
        {
            IsEnemy = _enemy;
        }

        public void SetItem(Item _item)
        {
            myItem = _item;
        }

        public void ShowMyStatus() // 나의 스탯치를 전부 보여줌
        {
            Console.WriteLine("이름 : " + Name);
            Console.WriteLine("공격력 : " + Att);
            Console.WriteLine("HP : " + Hp + " / " + MaxHp);
            if (myItem != null)
            {
                myItem.ShowItemInfo();
            }
            Console.WriteLine("=================\n");
            
        }
        
        // 두 Attack이 동일함...
        public void Attack(int att) // 매개변수로 공격력만 받기
        {
            Hp -= Att;
            /*
             * this.HP -= Att; 가능
             */
        }

        public void Attack(Player _enemy) // 매개변수로 클래스를 받기
        {
            this.Hp -= _enemy.Att;
            //_enemy.Attack( this.Att
            //     /*this*/ /*this 를 넣어버리면 똑같이 Player 정보를 넣게 돼서 Attack(Player _enemy ) 함수를 계속 도는 무한반복이 됨..*/ );

            //_enemy.HP -= this.Att; //만약 HP 요소가 public 으로 수정할 수 있는 사항이라면, 내가 상대방에게 피해를 입히는것도 바로 가능...
        }

        public void UseItem()
        {
            
            
            if (myItem == null)
            {
                Console.WriteLine("가진 아이템이 없습니다.");
            }
            else // 일단 내 아이템이 존재함....
            {
                switch (myItem.itemType)
                {
                    case ItemType.Potion:
                        Hp += myItem.value;
                        if (Hp > MaxHp)
                        {
                            Hp = MaxHp;
                        }
                        break;
                    case ItemType.Sword:
                        Att += myItem.value;
                        break;
                    case ItemType.Armor:
                        MaxHp += myItem.value;
                        // 내가 만약 풀피였는데 최대 피통이 늘어나서 원래 피는 유지해버려서 마치 피가 깍인것 같은 효과를 준다면?
                        Hp += myItem.value;
                        break;
                    default:
                        break;
                }

                myItem = null;
                ShowMyStatus();
            }
        }

        // public void Attack(Player _enemy) // _person = null 하지 말라  // 매개변수로 클래스를 받기
        // {
        //     this.Hp -= _enemy.Att;
        //     _enemy.Attack(/*this.Att*/ this /*this를 넣어버리면 똫같이 Player 정보를 넣게 돼서 Attack(Player _ enemy) 함수를 계속 도는 무한반복이 됨..*/);
        //  //   _enemy.Hp -= this.Att; // 만약 Hp 요소가 public 으로 수정할 수 있는 사항이라면, 내가 상대방에게 피해를 입히는것도 바로 가능...
        // }
    }

    class Item
    {
        public ItemType itemType { get; private set; } // 무슨 아이템인지
        public int value = 0; // 뭐가 됐건 이 아이템의 효력 수치...

        public Item(ItemType _type, int value)
        {
            itemType = _type;
            this.value = value;
        }

        public void ShowItemInfo()
        {
            switch (itemType)
            {
                case ItemType.Potion:
                    Console.WriteLine("이 아이템은 포션이고," + value + "만큼 피를 회복해 줍니다.");
                    break;
                case ItemType.Sword:
                    Console.WriteLine("이 아이템은 검이고," + value + "만큼 피해를 줍니다.");
                    break;
                case ItemType.Armor:
                    Console.WriteLine("이 아이템은 갑옷이고," + value + "만큼 최대 Hp를 늘려 줍니다.");
                    break;
                default:
                    break;
            }
        }
    }
}