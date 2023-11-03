using System;
using System.Collections.Generic;

namespace NCS_Start_202310
{
    #region 실습

    //당신에겐 포켓몬 세마리가 있습니다. 각각 풀,불, 물 타입입니다.
    //풀은 물에게 강하고, 물은 불에게 강하고, 불은 풀에게 강합니다.
    //각 포켓몬의 피는 20이상 100이하의 랜덤이고, 
    //각 포켓몬의 공격력은 1이상 10이하입니다.

    //같은 성질끼리 싸우면 본래 가진 공격력으로 공격하고,
    //내가 상대방에게 지는 성질이면 나의 공격력은 절반이되고, 상대방의 공격력은 내게 공격할 때 두배가 됩니다.

    //포켓몬의 이름은 사용자가 입력하여 지어줍니다. (후에 포켓몬 선택을 이 이름으로 합니다)

    //적으로 다섯마리의 포켓몬을 연달아 만나며, 각 포켓몬 또한 속성이 있습니다. (속성은 랜덤)

    //전투가 시작되면 포켓몬을 선택하여 싸우게 할 수 있으나, 피가 0이하인 포켓몬은 선택할 수 없습니다.
    //즉, 이전 전투에서 사망시 그 이후 전투에서 그 포켓몬은 더이상 전투 불가

    //전투중 사망시, 남은 포켓몬 중에 골라 진행해야하며, 나의 포켓몬이 전혀 없을 경우 패배가 선언되고 게임이 아예 종료됩니다.

    //전투에서 승리시, 남은 포켓몬들의 정보를 전부 출력합니다.

    public enum Type
    {
        GRASS,
        FIRE,
        WATER,

        END
    }

    public class Pokemon
    {
        public Type pokeType { get; private set; }
        public string name { get; private set; } = "";
        int hp = 0;
        int maxHP = 0;
        int att = 0;
        public bool IsAlive => hp > 0;
        public int Att => att;
        Random random = new Random();

        public Pokemon(string name, Type _type = Type.END)
        {
            this.name = name;
            hp = random.Next(20, 101);
            maxHP = hp;
            att = random.Next(1, 10);

            if (_type == Type.END)
            {
                _type = (Type)random.Next(0, (int)Type.END);
            }
            else
            {
                pokeType = _type;
            }
        }
        public void Attacked(int damage)
        {
            hp -= damage;
        }
        public void ShowInfos()
        {
            Console.WriteLine("===========================");
            Console.WriteLine(name);
            switch (pokeType)
            {
                case Type.GRASS:
                    Console.WriteLine("풀타입 포켓몬");
                    break;
                case Type.FIRE:
                    Console.WriteLine("불타입 포켓몬");
                    break;
                case Type.WATER:
                    Console.WriteLine("물타입 포켓몬");
                    break;
            }
            ShowMyHP();
            Console.WriteLine($"공격력 : {att}");
            Console.WriteLine("===========================");
        }
        public void ShowMyHP()
        {
            Console.WriteLine($"체력 : {hp} / {maxHP}");
        }
    }

    public class Master
    {
        Dictionary<string, Pokemon> myPokemonDic = new Dictionary<string, Pokemon>(); //내 포켓몬 리스트..
        Dictionary<Type, List<string>> myPokeTypeDic = new Dictionary<Type, List<string>>(); //원래 의도는 타입별로 빠르게 내가 뭔가 하고싶을까봐..
        public List<string> aliveList { get; private set; } = new List<string>(); //출전 가능한 리스트...

        public bool SetMyDefaultPokemon(string name, Type _type = Type.END) //나의 포켓몬 등록...
        {
            if (myPokemonDic.ContainsKey(name))
            {
                Console.WriteLine("동일한 이름으로 지을 수 없습니다");
                return false;
            }

            myPokemonDic.Add(name, new Pokemon(name, _type));
            _type = myPokemonDic[name].pokeType;
            if (myPokeTypeDic.ContainsKey(_type))
            {
                myPokeTypeDic[_type].Add(name);
            }
            else
                myPokeTypeDic.Add(_type, new List<string>() { name });

            aliveList.Add(name);

            return true;
        }

        public Pokemon GetMyPokemon(string name) //내 포켓몬을 하나 들려서 보내줌..
        {
            if (myPokemonDic.ContainsKey(name))
                return myPokemonDic[name];
            else
            {
                Console.WriteLine("존재하지 않는 포켓몬 입니다.");
                return null;
            }
        }
        public bool IsAlive(string name)
        {
            if (myPokemonDic.ContainsKey(name))
                return myPokemonDic[name].IsAlive;
            else
                return false;
        }


        public void ShowAllMyPokemons()
        {
            foreach (var item in myPokemonDic)
            {
                item.Value.ShowInfos();
            }
        }

        public void DeadPoke(string name)
        {
            if (aliveList.Contains(name))
            {
                aliveList.Remove(name);
            }
        }
    }

    class Battle
    {
        Master Master = null; //나
        Master Enemy = null; //적

        public void BattleStart()
        {
            Master = new Master(); //나ㅓ는 나만의 포켓몬 소유...
            Enemy = new Master(); //얘는 얘만의 포켓몬 소유

            SettingMasterInfos(); //나와 적의 생성 및 포켓몬 리스트 세팅과, 목록 확인하기 완료

            while (Enemy.aliveList.Count > 0) //상대 포켓몬의 카운트가 사라질때까지 전투.
            {
                if (Master.aliveList.Count == 0)
                {
                    Console.WriteLine("당신의 패배입니다. 배틀을 종료합니다");
                    return;
                }

                Console.WriteLine("배틀을 시작합니다");
                Console.WriteLine("=========상대 포켓몬==========");
                Console.Write("타입 : ");
                string enemyname = Enemy.aliveList[0];
                Console.WriteLine(Enemy.GetMyPokemon(enemyname)/*Pokemon클래스. 적이 가진 리스트중에 하나 뽑아옴*/.pokeType);
                Console.WriteLine("출전할 포켓몬을 입력해주세요");
                //제가 가진 타입별+ 이름 의 나열...
                string name = Console.ReadLine();

                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                if (DoBattle(Enemy.GetMyPokemon(Enemy.aliveList[0]), Master.GetMyPokemon(name)))
                {
                    Console.WriteLine($"플레이어의 포켓몬{name}이 {enemyname}을 이겼습니다");
                    Enemy.DeadPoke(enemyname);
                }
                else
                {
                    Console.WriteLine($"상대 포켓몬{enemyname}이 {name}을 이겼습니다");
                    Master.DeadPoke(name);
                }
            }

            Console.WriteLine("배틀에 승리하셨습니다");
            Master.ShowAllMyPokemons();
        }

        bool DoBattle(Pokemon enemypoke, Pokemon playerpoke)
        {
            while (true)
            {
                Console.WriteLine("플레이어의 공격");
                Attack(playerpoke, enemypoke);
                Console.WriteLine();

                Console.Write("적의 ");
                enemypoke.ShowMyHP();
                Console.WriteLine();
                if (enemypoke.IsAlive == false)
                {
                    return true;
                }

                Console.WriteLine("적의 공격");
                Attack(enemypoke, playerpoke);
                Console.WriteLine();
                Console.Write("플레이어의 ");
                playerpoke.ShowMyHP();
                Console.WriteLine();
                if (playerpoke.IsAlive == false)
                {
                    return false;
                }
            }
        }

        void Attack(Pokemon attackPoke, Pokemon hitPoke)
        {
            int val = (int)(attackPoke.Att * IsWin(attackPoke.pokeType, hitPoke.pokeType)); //val == 최종공격력
            Console.WriteLine($"{attackPoke.name}의 공격력 : {val} (원래 공격력 : {attackPoke.Att})");
            hitPoke.Attacked(val);
        }

        float IsWin(Type type1, Type type2)
        {
            switch (type1)
            {
                case Type.GRASS:
                    if (type2 == Type.FIRE)
                        return 0.5f;
                    else if (type2 == Type.WATER)
                        return 2;
                    break;
                case Type.FIRE:
                    if (type2 == Type.WATER)
                        return 0.5f;
                    else if (type2 == Type.GRASS)
                        return 2;
                    break;
                case Type.WATER:
                    if (type2 == Type.GRASS)
                        return 0.5f;
                    else if (type2 == Type.FIRE)
                        return 2;
                    break;
            }

            return 1;
        }
        void SettingMasterInfos()
        {
            string name = "";
            Console.WriteLine("당신의 포켓몬에게 이름을 정해주세요");
            Console.Write("풀타입 포켓몬 : ");
            name = Console.ReadLine();
            Master.SetMyDefaultPokemon(name, Type.GRASS);
            Console.Write("불타입 포켓몬 : ");
            name = Console.ReadLine();
            Master.SetMyDefaultPokemon(name, Type.FIRE);
            Console.Write("물타입 포켓몬 : ");
            name = Console.ReadLine();
            Master.SetMyDefaultPokemon(name, Type.WATER);
            //==============================

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                Enemy.SetMyDefaultPokemon("포켓몬" + (i + 1), (Type)random.Next(0, (int)Type.END));
            }

            Console.WriteLine();
            Console.WriteLine("================================");
            Console.WriteLine("플레이어 포켓몬");
            Master.ShowAllMyPokemons();
            Console.WriteLine();
            Console.WriteLine("################################");
            Console.WriteLine();
            Console.WriteLine("적의 포켓몬");
            Enemy.ShowAllMyPokemons();
            Console.WriteLine("================================");
            Console.WriteLine();
        }
    }

    //class Program
    //{
    //    static void Main(string[] a)
    //    {
    //        Battle battle = new Battle();
    //        battle.BattleStart();

    //    }
    //}
    #endregion
}